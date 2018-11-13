using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace QuadcopterLibrary
{
    public class Area :IDisposable
    {
        #region Events
        public delegate void RadioComand(int radioSetting, double x, double y);


        internal event Action<Quadcopter> SosEvent;
        internal event Action TimeTickEvent;
        internal event RadioComand RadioEvent;
        #endregion
        #region  properties
        internal Random Rnd { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        #endregion
        #region var
        Thread background;
        List<Quadcopter> quadcopters;
        List<Master> masters;
        List<RadioRemote> radioRemotes;
        #endregion
        public Area(int x, int y)
        {
            Rnd = new Random();
            X = x;
            Y = y;
            quadcopters = new List<Quadcopter>();
            masters = new List<Master>();
            radioRemotes = new List<RadioRemote>();
            background = new Thread(BackgroundCheck);
            background.Start();
        }
        public List<Quadcopter> GetQuadcoptersList() => new List<Quadcopter>(quadcopters);
        public List<Master> GetMastersList() => new List<Master>(masters);
        public List<RadioRemote> GetRadioRemotesList() => new List<RadioRemote>(radioRemotes);
        
        public void AddQuadcopter(int x, int y, int radioSetting)
        {
            if (x < 0 || y < 0 || x >= X || y >= Y)
                throw new Exception();
            Quadcopter quadcopter = new Quadcopter(Rnd, x, y, X, Y, radioSetting);
            quadcopters.Add(quadcopter);
            TimeTickEvent += quadcopter.TimeTick;
            RadioEvent += quadcopter.SetAcceleration;
            quadcopter.SosEvent += StartSosAsync;
        }
        public void AddMaster(int x)
        {
            if (x < 0 || x >= X )
                throw new Exception();
            Master master = new Master(Rnd, x);
            masters.Add(master);
            TimeTickEvent += master.TimeTick;
            SosEvent += master.SosAnswer;
        }
        public void AddRadioRemoute(int radioSetting)
        {
            RadioRemote radioRemote = new RadioRemote(radioSetting);
            radioRemotes.Add(radioRemote);
            radioRemote.RadioRemoteEvent += StartRadioComandAsync;
        }
        public Quadcopter GetQuadcopterByXY(int X, int Y)
        {
            foreach (var item in quadcopters)
            {
                if (Math.Pow(item.X - X, 2) + Math.Pow(item.Y - Y, 2) < Math.Pow(Quadcopter.R, 2))
                    return item;
            }
            return null;
        }


        internal async void StartSosAsync(Quadcopter quadcopter)
        {
            if(SosEvent!=null)
            {
                await Task.Run(() => SosEvent(quadcopter));
            }
        }
        internal async void StartRadioComandAsync(int radioSetting, double x, double y)
        {
            if(RadioEvent!=null)
            {
                await Task.Run(()=>RadioEvent(radioSetting,x,y));
            }
        }
        public async void StartTickAsync()
        {
            if (TimeTickEvent != null)
                await Task.Run(TimeTickEvent);
        }
        private void BackgroundCheck()
        {
            while (true)
            {
                for (int i = 0; i < quadcopters.Count; i++)
                    for (int j = i + 1; j < quadcopters.Count; j++)
                        try
                        {
                            if (quadcopters[i].IsWorking && quadcopters[j].IsWorking &&
                                Math.Pow(quadcopters[i].X - quadcopters[j].X, 2) +
                                Math.Pow(quadcopters[i].Y - quadcopters[j].Y, 2) < 4 * Quadcopter.R * Quadcopter.R)
                            {
                                quadcopters[i].IsWorking = false;
                                quadcopters[j].IsWorking = false;
                            }
                        }
                        catch (Exception) { }
            }
        }

        public void Dispose()
        {
            background.Abort();
        }
    }
}
