
namespace spaceships
{
    public class SpaceShips
    {
        public string ShipName;
        public int portalBrackets;
        public int gluonPortalDrives;
        public bool nanowavePulser;
        public bool deltaWaveScrubber;
        public float aftDrivePlateRotation;
        public float forwardDrivePlateRotation;

        public string getData()
        {
            return this.ShipName + " " + this.portalBrackets + " " + this.gluonPortalDrives
           + " " + this.nanowavePulser + " " + this.deltaWaveScrubber + " " + this.aftDrivePlateRotation + " " + this.forwardDrivePlateRotation;


        }
    }
}

        