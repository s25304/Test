using Kolokwium.Models;

namespace Zadanie7.DTOs;

public class SubscriptionDto
{
    public SubscriptionDto(Subscription src)
    {
        IdSubscription = src.IdSubscription;
        Name = src.Name;
        RenewalPeriod = src.RenewalPeriod;
        EndTime = src.EndTime;
        Price = src.Price;
    }
    public int IdSubscription { get; set; }
    
    public string Name { get; set; }
    
    public int RenewalPeriod { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public double Price { get; set; }
    
}