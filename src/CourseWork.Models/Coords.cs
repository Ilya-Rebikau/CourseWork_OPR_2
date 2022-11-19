using System.Drawing;
using System.Numerics;

namespace CourseWork.Models
{
    public class Coords
    {
        public Coords(int firstCoord, int secondCoord)
        {
            FirstCoord = firstCoord;
            SecondCoord = secondCoord;
        }

        public int FirstCoord { get; set; }

        public int SecondCoord { get; set; }
    }
}
