using System.Text;

namespace CourseWork.Models
{
    public class Path
    {
        public Path(List<Coords> intPath)
        {
            CoordsPath = intPath;
            InitializeStringPath();
        }

        public List<Coords> CoordsPath { get; private set; }

        public string StringPath { get; private set; }

        private void InitializeStringPath()
        {
            var resultSb = new StringBuilder();
            int currentPoint = 0;
            for (int i = 0; i < CoordsPath.Count; i++)
            {
                if (CoordsPath[i].FirstCoord == currentPoint)
                {
                    currentPoint = CoordsPath[i].SecondCoord;
                    resultSb.Append($"{CoordsPath[i].FirstCoord + 1} → {CoordsPath[i].SecondCoord + 1}");
                    break;
                }
            }

            while (currentPoint != 0)
            {
                for (int i = 0; i < CoordsPath.Count; i++)
                {
                    if (currentPoint == CoordsPath[i].FirstCoord)
                    {
                        currentPoint = CoordsPath[i].SecondCoord;
                        resultSb.Append($" → {currentPoint + 1}");
                    }
                }
            }

            StringPath = resultSb.ToString();
        }
    }
}