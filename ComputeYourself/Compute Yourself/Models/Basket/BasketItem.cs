﻿using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;
using Microsoft.EntityFrameworkCore;

namespace ComputeYourself.Models.Basket;

[Table("BasketItems")]
public class BasketItem
{
    
    public int Id { get; set; }
    public int Quantity { get; set; }

    // Navigation properties
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int BasketId { get; set; }
    public Basket Basket { get; set; }
}