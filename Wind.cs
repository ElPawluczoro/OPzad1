using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Wind
    {
        private float speedInKnots;
        private GeographicsDirections windDirection;
        private float windSpeed;

        public GeographicsDirections getWindDirection()
        {
            return windDirection;
        }

        public float GetWindSpeed()
        {
            return windSpeed;
        }



        public Wind(float speedInKnots, GeographicsDirections windDirection)
        {
            this.speedInKnots = speedInKnots;
            this.windDirection = windDirection;

            windSpeed=Speeds.KnotsToMpS(speedInKnots);
        }
    }
}
