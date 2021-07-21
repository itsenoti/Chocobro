using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocobro
{

    class Clock
    {
        private int hour = 00;
        private int minute = 00;
        private int second = 00;

        public Clock()
        {
            this.hour = 00;
            this.minute = 00;
            this.second = 00;
        }

        public void Tick()
        {
            this.second++;
            if (this.second == 60)
            {
                this.second = 00;
                this.minute++;
            }

            if (this.minute == 60)
            {
                this.minute = 00;
                this.hour++;
            }

            if (this.hour == 60)
            {
                this.hour = 00;
            }
        }

        public string displayTime()
        {
            string time = this.hour.ToString("D2") + ":" + this.minute.ToString("D2");
            return time;
        }
    }
    
}
