#pragma warning disable CS8618
using loginAndRegistration.Models;
using Microsoft.EntityFrameworkCore;
namespace loginAndRegistration.Models;
public class MyContext : DbContext 
{    
    public MyContext(DbContextOptions options) : base(options) { }    
     
      public DbSet<User> Users {get;set;}
}