using CourseWork.Models;

namespace CourseWork.BLL.Interfaces
{
    public interface ISolver
    {
        ResultDataModel Solve(string fileNameWithPath, int triesCount);
    }
}
