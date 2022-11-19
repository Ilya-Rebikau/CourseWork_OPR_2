using CourseWork.DAL.Interfaces;
using CourseWork.Models;

namespace CourseWork.DAL.Services
{
    internal class CsvSerializer : ISerializer
    {
        public Matrix DeserializeCsvMatrix(string fileNameWithPath)
        {
            var elements = Array.Empty<double[]>();
            var lines = File.ReadAllLines(fileNameWithPath);
            for (int i = 0; i < lines.Length; i++)
            {
                var row = Array.Empty<double>();
                var elementsInLine = lines[i].Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < elementsInLine.Length; j++)
                {
                    
                    if (elementsInLine[j] == "infinity")
                    {
                        row = row.Append(double.PositiveInfinity).ToArray();
                    }
                    else
                    {
                        row = row.Append(double.Parse(elementsInLine[j])).ToArray();
                    }
                }

                elements = elements.Append(row).ToArray();
            }

            return new Matrix(elements);
        }
    }
}
