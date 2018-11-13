namespace QuadcopterApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Output = new System.Windows.Forms.PictureBox();
            this.updTimer = new System.Windows.Forms.Timer(this.components);
            this.TikTimer = new System.Windows.Forms.Timer(this.components);
            this.Input1 = new System.Windows.Forms.PictureBox();
            this.Input2 = new System.Windows.Forms.PictureBox();
            this.Input3 = new System.Windows.Forms.PictureBox();
            this.Input4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SetRadio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.infoBtn = new System.Windows.Forms.RadioButton();
            this.AddQuadcopterBtn = new System.Windows.Forms.RadioButton();
            this.AddMasterBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetRadio)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 12);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(1102, 589);
            this.Output.TabIndex = 0;
            this.Output.TabStop = false;
            this.Output.Tag = "";
            this.Output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Output_MouseDown);
            // 
            // updTimer
            // 
            this.updTimer.Interval = 10;
            this.updTimer.Tick += new System.EventHandler(this.updTimer_Tick);
            // 
            // TikTimer
            // 
            this.TikTimer.Interval = 10;
            this.TikTimer.Tick += new System.EventHandler(this.TikTimer_Tick);
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(1120, 12);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(100, 100);
            this.Input1.TabIndex = 1;
            this.Input1.TabStop = false;
            this.Input1.Tag = "0";
            this.Input1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Input1_MouseDown);
            this.Input1.MouseLeave += new System.EventHandler(this.Input3_MouseLeave);
            this.Input1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Input1_MouseDown);
            this.Input1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Input3_MouseUp);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(1226, 12);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(100, 100);
            this.Input2.TabIndex = 2;
            this.Input2.TabStop = false;
            this.Input2.Tag = "1";
            this.Input2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Input1_MouseDown);
            this.Input2.MouseLeave += new System.EventHandler(this.Input3_MouseLeave);
            this.Input2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Input1_MouseDown);
            this.Input2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Input3_MouseUp);
            // 
            // Input3
            // 
            this.Input3.Location = new System.Drawing.Point(1438, 12);
            this.Input3.Name = "Input3";
            this.Input3.Size = new System.Drawing.Size(100, 100);
            this.Input3.TabIndex = 4;
            this.Input3.TabStop = false;
            this.Input3.Tag = "3";
            this.Input3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Input1_MouseDown);
            this.Input3.MouseLeave += new System.EventHandler(this.Input3_MouseLeave);
            this.Input3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Input1_MouseDown);
            this.Input3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Input3_MouseUp);
            // 
            // Input4
            // 
            this.Input4.Location = new System.Drawing.Point(1332, 12);
            this.Input4.Name = "Input4";
            this.Input4.Size = new System.Drawing.Size(100, 100);
            this.Input4.TabIndex = 3;
            this.Input4.TabStop = false;
            this.Input4.Tag = "2";
            this.Input4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Input1_MouseDown);
            this.Input4.MouseLeave += new System.EventHandler(this.Input3_MouseLeave);
            this.Input4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Input1_MouseDown);
            this.Input4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Input3_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1120, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Setting";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1166, 115);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Tag = "0";
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.RadioSetting_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1273, 115);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Tag = "1";
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.RadioSetting_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1227, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Setting";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(1485, 115);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Tag = "3";
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.RadioSetting_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1439, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Setting";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(1378, 115);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown4.TabIndex = 10;
            this.numericUpDown4.Tag = "2";
            this.numericUpDown4.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.RadioSetting_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1332, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Setting";
            // 
            // SetRadio
            // 
            this.SetRadio.Enabled = false;
            this.SetRadio.Location = new System.Drawing.Point(1166, 216);
            this.SetRadio.Name = "SetRadio";
            this.SetRadio.Size = new System.Drawing.Size(53, 20);
            this.SetRadio.TabIndex = 14;
            this.SetRadio.Tag = "0";
            this.SetRadio.ValueChanged += new System.EventHandler(this.SetRadio_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1120, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Setting";
            // 
            // infoBtn
            // 
            this.infoBtn.AutoSize = true;
            this.infoBtn.Checked = true;
            this.infoBtn.Location = new System.Drawing.Point(1120, 177);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(42, 17);
            this.infoBtn.TabIndex = 16;
            this.infoBtn.TabStop = true;
            this.infoBtn.Text = "info";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            // 
            // AddQuadcopterBtn
            // 
            this.AddQuadcopterBtn.AutoSize = true;
            this.AddQuadcopterBtn.Location = new System.Drawing.Point(1166, 177);
            this.AddQuadcopterBtn.Name = "AddQuadcopterBtn";
            this.AddQuadcopterBtn.Size = new System.Drawing.Size(103, 17);
            this.AddQuadcopterBtn.TabIndex = 17;
            this.AddQuadcopterBtn.Text = "Add Quadcopter";
            this.AddQuadcopterBtn.UseVisualStyleBackColor = true;
            this.AddQuadcopterBtn.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            // 
            // AddMasterBtn
            // 
            this.AddMasterBtn.AutoSize = true;
            this.AddMasterBtn.Location = new System.Drawing.Point(1273, 177);
            this.AddMasterBtn.Name = "AddMasterBtn";
            this.AddMasterBtn.Size = new System.Drawing.Size(79, 17);
            this.AddMasterBtn.TabIndex = 18;
            this.AddMasterBtn.Text = "Add Master";
            this.AddMasterBtn.UseVisualStyleBackColor = true;
            this.AddMasterBtn.CheckedChanged += new System.EventHandler(this.Btn_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 613);
            this.Controls.Add(this.AddMasterBtn);
            this.Controls.Add(this.AddQuadcopterBtn);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.SetRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input3);
            this.Controls.Add(this.Input4);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Output);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetRadio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Output;
        private System.Windows.Forms.Timer updTimer;
        private System.Windows.Forms.Timer TikTimer;
        private System.Windows.Forms.PictureBox Input1;
        private System.Windows.Forms.PictureBox Input2;
        private System.Windows.Forms.PictureBox Input3;
        private System.Windows.Forms.PictureBox Input4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SetRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton infoBtn;
        private System.Windows.Forms.RadioButton AddQuadcopterBtn;
        private System.Windows.Forms.RadioButton AddMasterBtn;
    }
}

