using Microsoft.EntityFrameworkCore;
using ThanksCardAPI.Models;

namespace ThanksCardAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<ThanksCards> ThanksCards { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<User_Dep_Kanri> User_Dep_Kanris { get; set; }
        public DbSet<Comment_Rireki> Comment_Rirekis { get; set; }
    }
}
