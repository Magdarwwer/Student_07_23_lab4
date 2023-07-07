using Microsoft.EntityFrameworkCore;

namespace Student
{
   public class StudentContext: DbContext
    {public StudentContext(DbContextOptions options) : base(options) { }
    public DbSet<Student> Student { get; set; } = null!;
}
}
