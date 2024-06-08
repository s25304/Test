using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Models;

public class Payment
{
    [Key]
    public int IdPayment { get; set; }
    
    [Required]
    public DateTime Date { get; set; }
    
    
    public Client Client { get; set; }
    
    public Subscription Subscription { get; set; }
}