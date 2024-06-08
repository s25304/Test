using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Models;

public class Discount
{
    [Key]
    public int IdDiscount { get; set; }
    
    public int Value { get; set; }
    
    [Required]
    public DateTime DateFrom { get; set; }
    
    [Required]
    public DateTime DateTo { get; set; }
    
    public Subscription Subscription { get; set; }
    
}