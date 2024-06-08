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
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }



}