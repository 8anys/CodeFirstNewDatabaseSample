using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Product
{
    [Key]
    public long ProductId { get; set; }

    public long CategoryId { get; set; }

    [Required]
    [MaxLength(30)]
    public string ProductName { get; set; }

    public virtual Category Category { get; set; } = null!;
}
