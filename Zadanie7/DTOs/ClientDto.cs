﻿using System.Collections;
using Kolokwium.Models;

namespace Zadanie7.DTOs;

public class ClientDto
{

    public ClientDto(Client src)
    {
        IdClient = src.IdClient;
        FirstName = src.FirstName;
        LastName = src.LastName;
        Email = src.Email;
        Phone = src.Phone;
        Subscriptions = new List<SubscriptionDto>();
        
        foreach (var Sale in src.Sales)
        {
            Subscriptions.Add(new SubscriptionDto(Sale.Subscription));
        }
    }
    public int IdClient { get; set; }
    
    public string FirstName { get; set; }
    
   
    public string LastName { get; set; }
    
   
    public string Email { get; set; }
    
    
    public string Phone { get; set; }
    
   public List<SubscriptionDto> Subscriptions { get; set; }
    
}