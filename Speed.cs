using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Speed
    {
        private float speed;

        public float getSpeed()
        {
            return speed;
        }

        override public string ToString()
        {
            return speed.ToString();
        }

        public Speed(Carpet carpet, Wind wind)
        {
            GeographicsDirections c = carpet.getDirection();
            GeographicsDirections w = wind.getWindDirection();
            if (c == w)
            {
                speed = carpet.GetSpeed() + wind.GetWindSpeed();
            }
            else if ((((c == GeographicsDirections.SOUTH || c == GeographicsDirections.NORTH)) && ((w == GeographicsDirections.SOUTH || w == GeographicsDirections.NORTH))) ||
                    (((c == GeographicsDirections.EAST || c == GeographicsDirections.WEST)) && ((w == GeographicsDirections.WEST) || (w == GeographicsDirections.EAST))))
            {
                speed = carpet.GetSpeed() - wind.GetWindSpeed();
            }
            else speed = carpet.GetSpeed();
        }

        public Speed(Carpet carpet1, Carpet carpet2, Wind wind)
        {
            float s1;
            float s2;
            GeographicsDirections w = wind.getWindDirection();

            GeographicsDirections c1 = carpet1.getDirection();
            GeographicsDirections c2 = carpet2.getDirection();

            if (c1 == w)
            {
                s1 = carpet1.GetSpeed() + wind.GetWindSpeed();
            }
            else if ((((c1 == GeographicsDirections.SOUTH || c1 == GeographicsDirections.NORTH)) && ((w == GeographicsDirections.SOUTH || w == GeographicsDirections.NORTH))) ||
                    (((c1 == GeographicsDirections.EAST || c1 == GeographicsDirections.WEST)) && ((w == GeographicsDirections.WEST) || (w == GeographicsDirections.EAST))))
            {
                s1 = carpet1.GetSpeed() - wind.GetWindSpeed();
            }
            else s1 = carpet1.GetSpeed();

            if (c2 == w)
            {
                s2 = carpet2.GetSpeed() + wind.GetWindSpeed();
            }
            else if ((((c2 == GeographicsDirections.SOUTH || c2 == GeographicsDirections.NORTH)) && ((w == GeographicsDirections.SOUTH || w == GeographicsDirections.NORTH))) ||
                    (((c2 == GeographicsDirections.EAST || c2 == GeographicsDirections.WEST)) && ((w == GeographicsDirections.WEST) || (w == GeographicsDirections.EAST))))
            {
                s2 = carpet2.GetSpeed() - wind.GetWindSpeed();
            }
            else s2 = carpet2.GetSpeed();

            speed = s1 + s2;
        }

        public Speed(Distance distance, Time time)
        {
            speed = distance.GetDistance() / time.ReturnTimeInSeconds();

        }

        public Speed(float speed)
        {
            this.speed = speed;
        }

        public static Speed SubstractSpeeds(Speed speed1, Speed speed2)
        {
            return new Speed(speed1.getSpeed() - speed2.getSpeed());
        }

        public static int CompareSpeeds(Speed speed1, Speed speed2)
        {
            if (speed1.getSpeed() > speed2.getSpeed())
            {
                return 1;
            }
            else if (speed1.getSpeed() < speed2.getSpeed())
            {
                return -1;
            }
            else return 0;
        }

    }
}
