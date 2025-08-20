using System.Diagnostics;

namespace AsPNetCoreWebApplication1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
    }
}
