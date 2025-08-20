using AsPNetCoreWebApplication1.Models;
namespace AsPNetCoreWebApplication1.Services
{
    public interface IGradeService
    {
        List<Grade>GetAllGrades();
        Grade GetGradeById(int id);
        Grade GetGradeByIdAndName(int id, string name);
        int AddGrade(Grade grade);
        int UpdateGrade(int gradeId, Grade grade);
        int DeleteGrade(int gradeId);
    }
}
