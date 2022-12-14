using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Distance
    {
        private float distanceKm;
        private float distanceM;

        public float GetDistance()
        {
            return distanceM;
        }

        public Distance(float distance)
        {
            this.distanceKm = distance;

            this.distanceM = distance * 1000;
        }

        public static Distance CalculateDistance(Speed speed, Time time)
        {
            return new Distance(time.ReturnTimeInSeconds() * speed.getSpeed()/1000);
        }

        public static Distance SupbstractDistance(Distance distance1, Distance distnace2)
        {
            //distance1 - distnace2
            return new Distance((distance1.GetDistance() - distnace2.GetDistance())/1000);
        }

        public static Distance AddDistance(Distance distance1, Distance distnace2)
        {
            //distance1 - distnace2
            return new Distance((distance1.GetDistance() + distnace2.GetDistance()) / 1000);
        }

        public string DistanceToString()
        {
            return distanceM.ToString() + "m";
        }

    }
}
