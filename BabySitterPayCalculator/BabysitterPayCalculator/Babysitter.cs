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

        public int Calculate(int startHour, int hours, int bedTime)
        {
            List<int> payHours = new List<int>();
            for (int i = 0; i < hours; i++)
            {
                payHours.Add(GetPayForHour(startHour + i, bedTime));
            }

            return payHours.Sum();
        }

        private int GetPayForHour(int hour, int bedTime)
        {
            int rate = StartToBedtimeRate;

            if (hour >= Midnight)
            {
                rate = MidnightToEndRate;
            }

            if (hour >= bedTime && hour < Midnight)
            {
                rate = BedtimeToMidnightRate;
            }

            return rate;
        }
    }
}
