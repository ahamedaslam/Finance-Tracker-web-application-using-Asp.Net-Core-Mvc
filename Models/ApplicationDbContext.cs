using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext    //By using Entity FrameworkCore
                                                   //It will be converted to corresponding sql server tables
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        { 
        }
        public DbSet<Transaction>Transactions { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
