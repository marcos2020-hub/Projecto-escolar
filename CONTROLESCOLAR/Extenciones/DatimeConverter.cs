using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.Extenciones
{
    public static class DatimeConverter
    {
        public static DateTime UnixADateTime(this long unixtime)
        {
            DateTime sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return sTime.AddSeconds(unixtime);
        }

        public static long ConvertirAUnix(this DateTime MyDateTime)
        {
            DateTime sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            return (long)(MyDateTime - sTime).TotalSeconds;
        }
    }
}


