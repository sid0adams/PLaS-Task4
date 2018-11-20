using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadcopterLibrary
{
    public class Master
    {
        #region constant
        const int RandomRepair = 50;
        Random rnd;
        #endregion

        Quadcopter target;
        public int X { get; private set; }

        public Master(Random rnd, int x)
        {
            this.rnd = rnd;
            X = x;
        }

        internal void SosAnswer(Quadcopter quadcopter)
        {
            if (target == null)
            {
                if (quadcopter.Master == null)
                {
                    target = quadcopter;
                    quadcopter.Master = this;
                }
                else if (Math.Abs(quadcopter.X - X) < Math.Abs(quadcopter.Master.X - quadcopter.X))
                {
                    target = quadcopter;
                    quadcopter.Master.target = null;
                    quadcopter.Master = this;
                }
            }
            else if (quadcopter.Master == null)
            {
                if (Math.Abs(quadcopter.X - X) < Math.Abs(target.X - X))
                {
                    target.Master = null;
                    target = quadcopter;
                    quadcopter.Master = this;
                }
            }
        }
        

        internal void TimeTick()
        {
            if (target == null)
                return;
            if (target.X + Quadcopter.R < X)
            {
                X--;
                return;
            }
            if(target.X - Quadcopter.R > X)
            {
                X++;
                return;
            }
            if(rnd.Next(RandomRepair) == 0)
            {
                target.IsWorking = true;
                target.Master = null;
                target = null;
            }
        }
    }
}
