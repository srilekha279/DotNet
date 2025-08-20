using EFDBCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDBCodeFirstApproach.DTO;
using Microsoft.EntityFrameworkCore;

namespace EFDBCodeFirstApproach
{
    internal class Dto
    {
        StudentDbContext context = new StudentDbContext();
        public StdWithGradeDTO GetStudentsById(int stuId)
        {
            StdWithGradeDTO std = null;
            try
            {
               
                  std = context.Students.Include(s => s.Grade).Select(s => new StdWithGradeDTO 
                     {StudentId = s.StudentId,
                        StudentName = s.StudentName,
                        GradeName = s.Grade.GradeName,
                        Section = s.Grade.Section
                    }).SingleOrDefault(s => s.StudentId == stuId);
                }
            catch(Exception ex)
            {
                throw ex;
            }
            return std;
        }
    }
}
