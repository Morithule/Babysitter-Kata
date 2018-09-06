using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterPayCalculator
{
    public class Babysitter
    {
        private int MaxStartTime { get; set; }
        private int MaxEndTime { get; set; }
        private int StartToBedtimeRate { get; set; }
        private int BedtimeToMidnightRate { get; set; }
        private int MidnightToEndRate { get; set; }

        private int Midnight = 24;

        public Babysitter(int maxtartTime, int maxEndTime, int startToBedtimeRate, int bedtimeToMidnightRate, int midnightToEndRate)
        {
            MaxStartTime = maxtartTime;
            MaxEndTime = maxEndTime;
            StartToBedtimeRate = startToBedtimeRate;
            BedtimeToMidnightRate = bedtimeToMidnightRate;
            MidnightToEndRate = midnightToEndRate;
        }

        public int Calculate(int startTime, int endTime, int bedTime)
        {
            int pay = 0;
            if(endTime > bedTime)
            {
                pay += (endTime - bedTime) * BedtimeToMidnightRate;
                pay += (bedTime - startTime) * StartToBedtimeRate;
            }
            else
            {
                pay += (endTime - startTime) * StartToBedtimeRate;
            }

            

            return pay;
        }
    }
}
