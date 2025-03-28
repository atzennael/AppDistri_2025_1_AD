using Microsoft.EntityFrameworkCore;
using WebApiPerson_AD.Models;

namespace WebApiPerson_AD.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base (options)
        {
            
        }
        public DbSet<Person> Persons{ get; set;}
    }
}
