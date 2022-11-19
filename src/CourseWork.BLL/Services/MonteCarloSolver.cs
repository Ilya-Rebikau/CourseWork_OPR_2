using CourseWork.BLL.Interfaces;
using CourseWork.DAL.Interfaces;
using CourseWork.Models;
using Path = CourseWork.Models.Path;

namespace CourseWork.BLL.Services
{
    internal class MonteCarloSolver : ISolver
    {
        private readonly ISerializer _serializer;
        public MonteCarloSolver(ISerializer serializer)
        {
            _serializer = serializer;
        }

        public ResultDataModel Solve(string fileNameWithPath, int triesCount)
        {
            var matrix = _serializer.DeserializeCsvMatrix(fileNameWithPath);
            var pathes = new List<Path>();
            for (int i = 0; i < triesCount; i++)
            {
                var usedCoords = new List<Coords>();
                while (usedCoords.Count != matrix.Size)
                {
                    usedCoords = AddRandomCoords(usedCoords, matrix.Size);
                }

                var path = new Path(usedCoords);
                if (!pathes.Any(p => p.StringPath == path.StringPath))
                {
                    pathes.Add(path);
                }
            }

            return GetBestResult(pathes, matrix);
        }

        private static ResultDataModel GetBestResult(List<Path> pathes, Matrix matrix)
        {
            var listOfContourLengthes = new List<double>();
            for (int i = 0; i < pathes.Count; i++)
            {
                listOfContourLengthes.Add(GetContourLengthForPath(pathes[i], matrix, i));
            }

            var bestLength = listOfContourLengthes.Min();
            var indexOfBest = listOfContourLengthes.IndexOf(bestLength);
            return new ResultDataModel(pathes[indexOfBest], bestLength);
        }

        private static double GetContourLengthForPath(Path path, Matrix matrix, int i)
        {
            var contourLength = 0D;
            for (int j = 0; j < path.CoordsPath.Count; j++)
            {
                contourLength += matrix.Numbers[path.CoordsPath[j].FirstCoord][path.CoordsPath[j].SecondCoord];
            }

            return contourLength;
        }

        private static List<Coords> AddRandomCoords(List<Coords> usedCoords, int matrixSize)
        {
            var random = new Random();
            var firstCoord = 0;
            if (usedCoords.Count != 0)
            {
                firstCoord = usedCoords.Last().SecondCoord;
            }

            if (usedCoords.Count == matrixSize - 1)
            {
                usedCoords.Add(new Coords(firstCoord, 0));
            }
            else
            {
                var secondCoord = random.Next(0, matrixSize);
                while (firstCoord == secondCoord ||
                    secondCoord == 0 ||
                    usedCoords.Any(c => c.SecondCoord == secondCoord) ||
                    usedCoords.Any(c => usedCoords.Last().FirstCoord == secondCoord))
                {
                    secondCoord = random.Next(0, matrixSize);
                }

                usedCoords.Add(new Coords(firstCoord, secondCoord));
            }

            return usedCoords;
        }
    }
}
