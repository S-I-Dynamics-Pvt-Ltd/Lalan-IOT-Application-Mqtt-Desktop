using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mqtt
{
    internal class ClassGeneralFunctions
    {
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        private static Random random = new Random();

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public DateTime getCurrentDateTimeISTinDateTime()
        {
            DateTime indianTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);
            return indianTime;
        }

        public string getCurrentDateTimeIST(bool DateAndTime, bool DateOnly, bool TimeOnly)
        {


            string sValue = "";
            DateTime indianTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);

            if (DateAndTime == true)
            {
                sValue = indianTime.ToString("yyyy/MM/dd HH:mm:ss");
                return sValue;
            }

            if (DateOnly == true)
            {
                sValue = indianTime.ToString("yyyy/MM/dd");
                return sValue;
            }

            if (TimeOnly == true)
            {
                sValue = indianTime.ToString("HH:mm:ss");
                return sValue;
            }

            return sValue;
        }


    }
}
