using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using QuadcopterLibrary;

namespace DrawLibrary
{
    public class DrawArea
    {
        public Area Area { get; set; }
        Bitmap bitmap;
        Graphics g;
        private void DrawQuadcopter(Quadcopter quadcopter)
        {
            var X = (float)(quadcopter.X);
            var Y = (float)(Area.Y - quadcopter.Y);
            var R = 30;
            //g.FillEllipse(Brushes.Green,(float)( quadcopter.X - Quadcopter.R),(float)( Area.Y - quadcopter.Y - Quadcopter.R), 2 * Quadcopter.R, 2 * Quadcopter.R);
            g.FillRectangle(Brushes.Black, X - R, Y - 5, 2 * R, 10);
            g.FillEllipse(Brushes.Black, X - R + 10, Y - R + 20, 2 * (R - 10), 2 * (R - 20));
            g.DrawLine(Pens.Black, X, Y, X - 20, Y + R);
            g.DrawLine(Pens.Black, X, Y, X + 20, Y + R);
            g.FillRectangle(Brushes.Black, X - R + 2.5f, Y - 20, 5, 20);
            g.FillRectangle(Brushes.Black, X + R - 7.5f, Y - 20, 5, 20);
            g.FillRectangle(Brushes.Black, X - R-10, Y - 20, 30, 2);
            g.FillRectangle(Brushes.Black, X + R - 20, Y - 20, 30, 2);
        }
        private void DrawMaster(Master master)
        {
            //g.FillRectangle(Brushes.Red, master.X - 10, Area.Y - 60, 20, 60);
            g.FillEllipse(Brushes.Green, master.X - 10, Area.Y - 60, 20, 20);
            g.DrawLine(Pens.Green, master.X, Area.Y - 40, master.X, Area.Y - 20);
            g.DrawLine(Pens.Green, master.X, Area.Y - 20, master.X - 5, Area.Y);
            g.DrawLine(Pens.Green, master.X, Area.Y - 20, master.X + 5, Area.Y);
            g.DrawLine(Pens.Green, master.X, Area.Y - 35, master.X + 5, Area.Y-15);
            g.DrawLine(Pens.Green, master.X, Area.Y - 35, master.X - 5, Area.Y-15);
        }
        public Bitmap GetBitmap()
        {
            bitmap?.Dispose();
            bitmap = new Bitmap(Area.X, Area.Y);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            foreach (var item in Area.GetQuadcoptersList())
            {
                DrawQuadcopter(item);
            }
            foreach (var item in Area.GetMastersList())
            {
                DrawMaster(item);
            }
            return bitmap;
        }

        public DrawArea(Area area)
        {
            Area = area;
        }
    }
}
