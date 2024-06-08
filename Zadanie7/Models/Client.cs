﻿using System.ComponentModel.DataAnnotations;

namespace Kolokwium.Models;

public class Client
{
    [Key]
    public int IdClient { get; set; }
    [MaxLength(100)]
    [Required]
    public string FirstName { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string LastName { get; set; }
    
    [MaxLength(100)]
    [Required]
    public string Email { get; set; }
    
    [MaxLength(100)]
    public string Phone { get; set; }
    
    public ICollection<Payment> Payments { get; set; }
    
    public ICollection<Sale> Sales { get; set; }
}