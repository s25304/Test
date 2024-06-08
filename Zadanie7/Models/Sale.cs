using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Models;

public class Sale
{
    [Key]
    public int IdSale { get; set; }
    
    public Client Client { get; set; }
    
    public Subscription Subscription { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }
    
}