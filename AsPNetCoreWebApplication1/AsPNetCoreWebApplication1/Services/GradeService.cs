using AsPNetCoreWebApplication1.Models;
using System.Collections.Generic;
using System.Linq;
using AsPNetCoreWebApplication1.Services;
using Microsoft.EntityFrameworkCore;

namespace AsPNetCoreWebApplication1.Services
{
    public class GradeService : IGradeService
    {
        private readonly StudentDbContext context;
        public GradeService(StudentDbContext ctr)
        {
            context = ctr;
            
        }
        public List<Grade> GetAllGrades()
        {
            List<Grade> allGrades;
            try
            {
                allGrades = [..context.Grades];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return allGrades;
        }

        public Grade GetGradeById(int id)
        {
            Grade g = null;
            try
            {
                g = context.Grades.Find(id);
            }
            catch
            {
                throw;
            }
            return g;
        }

        public Grade GetGradeByIdAndName(int id, string name)
        {
            Grade grade = null;
            try
            {
                grade = context.Grades.FirstOrDefault(g => g.GradeId == id && g.GradeName == name);
            }
            catch
            {
                throw;
            }
            return grade;
        }

        public int AddGrade(Grade grade)
        {
            int rowsAffected = 0;
            try
            {
                context.Grades.Add(grade);
                rowsAffected = context.SaveChanges();
               
            }
            catch
            {
                throw;
            }
            return rowsAffected;
        }

        public int UpdateGrade(int gradeId, Grade grd)
        {
            int recordsAffected = 0;
            try
            {
                if (gradeId == grd.GradeId)
                {
                    context.Grades.Entry(grd).State = EntityState.Modified;
                    recordsAffected = context.SaveChanges();
                }
  
            }
            catch 
            {
                throw;
            }
            return recordsAffected;
        }

        public int DeleteGrade(int gradeId)
        {
            int recordsAffected = 0;
            try
            {
                Grade gradeToDelete = context.Grades.Find(gradeId);
                if(gradeToDelete != null)
                {
                    context.Grades.Remove(gradeToDelete);
                    recordsAffected = context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
            return recordsAffected;
        }
    }
}
