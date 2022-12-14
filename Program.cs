using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koncert Young Leosi//
            void Koncert() {
                Carpet carpet = new Carpet(GeographicsDirections.WEST);
                Time startTime = new Time(17, 0, 0);
                Distance distance = new Distance(300);
                Wind wind = new Wind(10, GeographicsDirections.WEST);
                Time timeConcertStarts = new Time(20, 30, 0);
                Speed speed = new Speed(carpet, wind);
                Time movementTime = Time.CalculateTime(speed, distance);
                Time atLocationTime = Time.addTime(movementTime, startTime);
                if (Time.Compare(atLocationTime, timeConcertStarts) > 0)
                {
                    Console.WriteLine("Mag nie zdąży na koncert");
                }
                else Console.WriteLine("Mag zdązy na koncert");
            }

            //Na plaży w Stegnie//
            void Stegna()
            {
                Carpet carpet = new Carpet(GeographicsDirections.SOUTH);
                Time startTime = new Time(11,20,0);
                Distance distanceToGo = new Distance(500);
                Time time1 = new Time(2,30,0);
                Wind wind1 = new Wind(2, GeographicsDirections.NORTH);
                Wind wind2 = new Wind(3, GeographicsDirections.WEST);
                Speed speed1 = new Speed(carpet, wind1);
                Speed speed2 = new Speed(carpet, wind2);
                Distance distance1 = Distance.CalculateDistance(speed1, time1);
                Distance distanceToGo2 = Distance.SupbstractDistance(distanceToGo, distance1);
                Time time2 = Time.addTime(startTime, time1);
                Time time3 = Time.CalculateTime(speed2, distanceToGo2);
                Time atLocationTime = Time.addTime(time2, time3);

                Console.WriteLine("Mag przyleci do Wrocławia o:");
                Console.WriteLine(atLocationTime.ReturnTime());
            }

            //Spotkanie na szczycie//
            void Szczyt()
            {
                Carpet carpet1 = new Carpet(GeographicsDirections.EAST);
                Carpet carpet2 = new Carpet(GeographicsDirections.WEST);
                Wind wind = new Wind(8, GeographicsDirections.EAST);
                Distance distanceToGo = new Distance(270);
                Time startTime1 = new Time(10, 15, 0);
                Time startTime2 = new Time(10, 30, 0);
                Time time1 = new Time(0, 15, 0);
                Speed speed1 = new Speed(carpet1 , wind);
                Speed speed2 = new Speed(carpet1, carpet2, wind);
                Distance distance1 = Distance.CalculateDistance(speed1, time1);
                Distance distanceToGo2 = Distance.SupbstractDistance(distanceToGo, distance1);
                Time time2 = Time.CalculateTime(speed2, distanceToGo2);
                Time timeOnDestination = Time.addTime(startTime2, time2);
                Distance distanceFromWroclaw = Distance.AddDistance(Distance.CalculateDistance(speed1, time2), distance1);
                Console.WriteLine("Spotkają się 0: " + timeOnDestination.ReturnTime());
                Console.WriteLine(distanceFromWroclaw.DistanceToString() + " od wrocławia");
            }

            //Kontrola prędkości//
            void Kontrola()
            {
                Carpet carpet = new Carpet(GeographicsDirections.WEST);
                Wind wind = new Wind(4, GeographicsDirections.WEST);
                Distance distance = new Distance(70);
                Time time = new Time(0, 40, 0);
                Speed speed1 = new Speed(distance, time);
                Speed speed2 = new Speed(Speeds.KnotsToMpS(4));
                Speed speed3 = Speed.SubstractSpeeds(speed1, speed2);
                Speed maxSpeed = new Speed(Speeds.KnotsToMpS(40));

                if (Speed.CompareSpeeds(speed3, maxSpeed) > 0)
                {
                    Console.WriteLine("Mag przekroczył prędkośc");
                }
                else Console.WriteLine("Mag nie przekrtoczył prędkości");

            }

            string choose = "0";

            Console.WriteLine("Wybierz zadanie:");
            Console.WriteLine("1.Koncert Young Leosi\n2.Na Plaży w Stegnie\n3.Spotkanie na szczycie\n4.Kontrola prędkości");
            choose = Console.ReadLine();

            switch (choose)
            {
                case "1": Koncert(); break;
                case "2": Stegna(); break;
                case "3": Szczyt(); break;
                case "4": Kontrola(); break;
            }


        }
    }
}
