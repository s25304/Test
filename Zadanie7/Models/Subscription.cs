using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Models;

public class Subscription
{
    [Key]
    public int IdSubscription { get; set; }
    
    public string Name { get; set; }
    
    public int RenewalPeriod { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public double Price { get; set; }
    
    public ICollection<Payment> Payments { get; set; }
    
    public ICollection<Discount> Discounts { get; set; }
    
    public ICollection<Sale> Sales { get; set; }
}