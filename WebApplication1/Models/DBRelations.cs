using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class DBRelations:DbContext
    {
        public DBRelations()
        {

        }
        public DBRelations(DbContextOptions<DBRelations> options):base(options)
        {

        }
        public DbSet<Instrauctor> Instrauctor { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Courses> Course { get; set; }
        public DbSet<Trainee> Trainee { get; set; } 
        public DbSet<Account> Account { get; set; } 
        public DbSet<CourseResult> courseResult { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               

                optionsBuilder.UseSqlServer(@"Data Source =.\SQL_SERVER;Initial Catalog =Day2DB;Integrated Security =True;");
        }
    }
}
