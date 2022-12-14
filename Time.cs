using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Time
    {

        private float hours;
        private float minutes;
        private int seconds;

        public float GetHours()
        {
            return hours;
        }

        public float GetMinutes()
        {
            return minutes;
        }

        public float GetSeconds()
        {
            return seconds;
        }

        public float ReturnTimeInSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;

        }

        public Time(float hours, float minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public string ReturnTime()
        {
            string minutesString;
            string secondsString;

            if (minutes < 10)
            {
                minutesString = "0" + minutes;
            }
            else minutesString = minutes.ToString();

            if (seconds < 10)
            {
                secondsString = "0" + seconds;
            }
            else secondsString = seconds.ToString();

            return hours + ":" + minutesString + ":" + secondsString;
        }

        public static int Compare(Time time1, Time time2)
        {
            if (time1.hours * 3600 + time1.minutes * 60 + time1.seconds < time2.hours * 3600 + time2.minutes * 60 + time2.seconds)
            {
                return -1;
            }else if (time1.hours * 3600 + time1.minutes * 60 + time1.seconds > time2.hours * 3600 + time2.minutes * 60 + time2.seconds)
            {
                return 1;
            }else return 0;
        }

        public static Time addTime(Time time1, Time time2)
        {
            int s=0;
            float m=0;
            float h=0;

            s = time1.seconds + time2.seconds;
            if (s >= 60)
            {
                m += 1;
            }

            m = time1.minutes + time2.minutes;
            if (m >= 60)
            {
                h += 1;
            }

            h = time1.hours + time2.hours;

            return new Time(h, m, s);
        }

        public static Time CalculateTime(Speed s, Distance d)
        {
            float h = 0;
            float m = 0;
            int sec = 0;


            float t = d.GetDistance() / s.getSpeed();
            while (t > 3600)
            {
                t -= 3600;
                h++;
            }
            while (t > 60)
            {
                t -= 60;
                m++;
            }
            sec = (int)t;            

            return new Time(h, m, sec);
        }

    }
}
