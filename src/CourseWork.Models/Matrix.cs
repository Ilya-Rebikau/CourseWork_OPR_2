namespace CourseWork.Models
{
    public class Matrix
    {
        public Matrix(double[][] numbers)
        {
            Numbers = numbers;
            Size = numbers.GetLength(0);
        }

        public double[][] Numbers { get; set; }
        
        public int Size { get; set; }
    }
}