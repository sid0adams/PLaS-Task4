using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadcopterLibrary
{
    public class RadioRemote
    {
        internal event Area.RadioComand RadioRemoteEvent;
        public int RadioSetting { get; set; }

        public RadioRemote(int radioSetting)
        {
            RadioSetting = radioSetting;
        }

        public void StartCommand(double x, double y) => RadioRemoteEvent?.Invoke(RadioSetting, x, y);
    }
}
