using Microsoft.EntityFrameworkCore;
using WebUI.Models.Entities;

namespace WebUI.Models.DataAccess
{
    public class SchoolProjectDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=SchoolProjectDb;Trusted_Connection=True;");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamType> ExamTypes { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<StudentExam> StudentsExams { get; set; }


    }
}
