using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Context;

public class Context : DbContext
{

    public Context()
    {
        
    }

    public Context(DbContextOptions<Context> options) : base(options)
    {
        
    }
    
    public DbSet<Client> Clients { get; set; }



}