using System;
using System.Collections.Generic;
using spaceships;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<SpaceShips> SpaceShips = new List<SpaceShips>();
            SpaceShips.Add(new SpaceShips());
            SpaceShips[0].ShipName = "January";
            SpaceShips[0].portalBrackets = 2;
            SpaceShips[0].gluonPortalDrives = 4;
            SpaceShips[0].nanowavePulser = true;
            SpaceShips[0].deltaWaveScrubber = false;
            SpaceShips[0].aftDrivePlateRotation = 22.2F;
            SpaceShips[0].forwardDrivePlateRotation = 2.2f;


            SpaceShips.Add(new SpaceShips());
            SpaceShips[1].ShipName = "February";
            SpaceShips[1].portalBrackets = 3;
            SpaceShips[1].gluonPortalDrives = 6;
            SpaceShips[1].nanowavePulser = false;
            SpaceShips[1].deltaWaveScrubber = false;
            SpaceShips[1].aftDrivePlateRotation = 33.1F;
            SpaceShips[1].forwardDrivePlateRotation = 3.1f;

            SpaceShips.Add(new SpaceShips());
            SpaceShips[2].ShipName = "March";
            SpaceShips[2].portalBrackets = 7;
            SpaceShips[2].gluonPortalDrives = 21;
            SpaceShips[2].nanowavePulser = true;
            SpaceShips[2].deltaWaveScrubber = true;
            SpaceShips[2].aftDrivePlateRotation = 21.7F;
            SpaceShips[2].forwardDrivePlateRotation = 2.71F;

            foreach (SpaceShips Ships in SpaceShips)
            {
                Console.WriteLine(Ships.getData());
            }
            Console.ReadLine();
        }
    }
}