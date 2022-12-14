using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Carpet
    {
        private float speed = 25; // m/s
        private GeographicsDirections direction;

        public GeographicsDirections getDirection()
        {
            return direction;
        }

        public float GetSpeed()
        {
            return speed;
        }



        public Carpet(GeographicsDirections geographicsDirections)
        {
            this.direction = geographicsDirections;
        }
    }
}
