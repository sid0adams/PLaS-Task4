using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DrawLibrary
{
    public class DrawStick
    {
        Bitmap bitmap;
        Graphics g;
        public Bitmap Draw(out double Xo, out double Yo,int X = 50, int Y= 50)
        {
            bitmap?.Dispose();
            bitmap = new Bitmap(100, 100);
            g = Graphics.FromImage(bitmap);
            g.DrawEllipse(Pens.Black, 0, 0, 99, 99);
            double l = Math.Sqrt(Math.Pow(X - 50, 2) + Math.Pow(Y - 50, 2));
            if(l>40)
            {
                X = (int)((X - 50)*40 / l + 50);
                Y = (int)((Y - 50)*40 / l + 50);
            }
            g.FillEllipse(Brushes.Black, X - 10, Y - 10, 20, 20);
            Xo = (X - 50)/40.0; Yo = (50-Y)/40.0;
            return bitmap;
        }
    }
}
