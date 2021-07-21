using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocobro
{
    public static class EorzeaTimeConverter
    {
        /// <summary>
        /// Simple converter from Earth time to Eorzea time
        /// Credits to Oliver Trenovth @ olitee.com
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime getEorzeaTime(this DateTime date)
        {
            long epochTicks = date.ToUniversalTime().Ticks - (new DateTime(1970, 1, 1).Ticks);

            long eorzeaTicks = (long)Math.Round(epochTicks * Constants.EORZEA_MULTIPLIER);

            return new DateTime(eorzeaTicks);
        }

        public static DateTime eorzeaToEarthTime(this DateTime date)
        {
            var epochTicks = (long)Math.Round(date.Ticks / Constants.EORZEA_MULTIPLIER);
            var earthTicks = epochTicks + new DateTime(1970, 1, 1).Ticks;
            var utc = new DateTime(earthTicks, DateTimeKind.Utc);
            return utc.ToLocalTime();
        }
    }
}