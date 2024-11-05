using System.Data.Entity;

namespace studentsFinalAssignment
{
    public class StudentDB : DbContext
    {
        public StudentDB() : base("StudentDatabase")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}