using Microsoft.EntityFrameworkCore;

namespace Student
{
    public class IdentityDbContext<T1, T2, T3>
    {
        private DbContextOptions options;

        public IdentityDbContext(DbContextOptions options)
        {
            this.options = options;
        }
    }
}