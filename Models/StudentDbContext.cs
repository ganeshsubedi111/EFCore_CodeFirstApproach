using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirstApproach.Models
{
    public class StudentDbContext: DbContext  // (we ineherit StudentDbContext with DbContext because DbContext
                                              // class is responsible for interact with tables or databases )

    {
        //first crete constructor
        public StudentDbContext(DbContextOptions options):base(options)// base here is use for calling the parent class constructor
        {
            

        }
        public DbSet<Student> Students { get; set; }// Dbset named students here represent table in database
    }
}
