namespace CourseWork.Models
{
    public class ResultDataModel
    {
        public ResultDataModel(Path path, double contourLength)
        {
            Path = path;
            ContourLength = contourLength;
        }

        public Path Path { get; }
        public double ContourLength { get; }
    }
}
