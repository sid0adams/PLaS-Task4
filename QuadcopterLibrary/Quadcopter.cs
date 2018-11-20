using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadcopterLibrary
{
    public class Quadcopter
    {
        #region const
        Random rnd;
        const int RandomFail = 20000;
        public const int R = 30;
        const double speed = 2;
        #endregion
        #region Event
        internal event Action<Quadcopter> SosEvent;
        #endregion
        #region public properties
        public double X { get; private set; }
        public double Y { get; private set; }
        #endregion
        #region  properties
        internal bool IsWorking { get; set; }
        internal Master Master { get; set; }
        public double AccelerationX { get; private set; }
        public double AccelerationY { get; private set; }
        double BoundX { get; set; }
        double BoundY { get; set; }
        public int RadioSetting { get; set; }
        #endregion
        public Quadcopter(Random rnd, double x, double y, double boundX, double boundY, int radioSetting)//init
        {
            IsWorking = true;
            this.rnd = rnd;
            X = x;
            Y = y;
            BoundX = boundX;
            BoundY = boundY;
            RadioSetting = radioSetting;
        }

        public void SetAcceleration(int radioSetting,double x, double y)
        {
            if (radioSetting != RadioSetting)
                return;
            AccelerationX = x * speed;
            AccelerationY = y * speed;
        }
        public async void TimeTickAsynk()
        {
            if (IsWorking)
            {
                X += AccelerationX;
                Y += AccelerationY;
                if(X<R||Y<R-2||X>=BoundX-R || Y>=BoundY-R||rnd.Next(RandomFail) == 0)
                {
                    Y++;
                    X -= AccelerationX;
                    Y -= AccelerationY;
                    IsWorking = false;
                }
            }
            else
            {
                if (Y > R)
                    Y--;
                else if (Master == null || Math.Abs(X - Master.X) > R)
                    await Task.Run(()=>SosEvent?.Invoke(this));
            }
        }
    }
}
