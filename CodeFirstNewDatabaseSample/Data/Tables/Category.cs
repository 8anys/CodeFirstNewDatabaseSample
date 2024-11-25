using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Category
{
    [Key]
    public long CategoryId { get; set; }

    [Required]
    [MaxLength(30)]
    public string? CategoryName { get; set; }

    public virtual Cooler Cooler { get; set; }

    public virtual Hdd Hdd { get; set; }

    public virtual Motherboard Motherboard { get; set; }

    public virtual Processor Processor { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual Ram Ram { get; set; }

    public virtual Ssd Ssd { get; set; }

    public virtual Videocard? Videocard { get; set; }
}
