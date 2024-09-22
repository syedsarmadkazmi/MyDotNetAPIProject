﻿using System.ComponentModel.DataAnnotations;

namespace MyDotNetAPIProject;

public class Product
{
    public int Id {get; set;}

    [Required]
    public string Sku {get; set;} = string.Empty;

    [Required]
    public string Name {get; set;} = string.Empty;
    [Required]
    public string Description {get; set;} = string.Empty;
    [Required]
    public decimal Price {get; set;}
    [Required]
    public bool IsAvailable {get; set;}

    [Required]
    public int CategoryId {get; set;}
    public virtual Category? Category {get; set;}
}
