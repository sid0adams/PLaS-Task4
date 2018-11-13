using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuadcopterLibrary;
using DrawLibrary;

namespace QuadcopterApp
{
    public partial class MainForm : Form
    {
        DrawArea draw;
        Area Area;
        Bitmap image;
        List<RadioRemote> radioRemotes;
        DrawStick stick;
        public MainForm()
        {
            InitializeComponent();
        }

        private void updTimer_Tick(object sender, EventArgs e)
        {
            image?.Dispose();
            image = draw.GetBitmap();
            Output.Image = image;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Area = new Area(Output.Width, Output.Height);
            draw = new DrawArea(Area);
            for (int i = 0; i < 4; i++)
            {
                Area.AddRadioRemoute(i);
            }
            radioRemotes = Area.GetRadioRemotesList();
            stick = new DrawStick();
            Bitmap image = stick.Draw(out double x, out double y);
            Input1.Image = image;
            Input2.Image = image;
            Input3.Image = image;
            Input4.Image = image;
            updTimer.Start();
            TikTimer.Start();
        }

        private void TikTimer_Tick(object sender, EventArgs e)
        {
            Area.StartTickAsync();
        }

        private void Input1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            PictureBox pictureBox = (PictureBox)sender;
            int index = int.Parse(pictureBox.Tag.ToString());
            pictureBox.Image = stick.Draw(out double x, out double y, e.X, e.Y);
            radioRemotes[index].StartCommand(x, y);
        }

        private void Input3_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int index = int.Parse(pictureBox.Tag.ToString());
            pictureBox.Image = stick.Draw(out double x, out double y);
            radioRemotes[index].StartCommand(0,0);
        }

        private void Input3_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int index = int.Parse(pictureBox.Tag.ToString());
            pictureBox.Image = stick.Draw(out double x, out double y);
            radioRemotes[index].StartCommand(0, 0);
        }
        Quadcopter SelectedQ;
        private void Output_MouseDown(object sender, MouseEventArgs e)
        {
            if(infoBtn.Checked)
            {
                Quadcopter quadcopter = Area.GetQuadcopterByXY(e.X, Area.Y - e.Y);
                if (quadcopter != null)
                {
                    SelectedQ = quadcopter;
                    SetRadio.Value = quadcopter.RadioSetting;
                    SetRadio.Enabled = true;
                }
                else
                {
                    SelectedQ = null;
                    SetRadio.Enabled = false;
                }

                return;
            }
            if(AddQuadcopterBtn.Checked)
            {
                Area.AddQuadcopter(e.X, Area.Y - e.Y, (int)SetRadio.Value);
                return;
            }
            if(AddMasterBtn.Checked)
            {
                Area.AddMaster(e.X);
                return;
            }
        }

        private void RadioSetting_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int index = int.Parse(numericUpDown.Tag.ToString());
            radioRemotes[index].RadioSetting = (int)numericUpDown.Value;
        }

        private void Btn_CheckedChanged(object sender, EventArgs e)
        {
            SetRadio.Enabled = AddQuadcopterBtn.Checked;
        }

        private void SetRadio_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedQ == null)
                return;
            SelectedQ.RadioSetting = (int)SetRadio.Value;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Area.Dispose();
        }
    }
}
