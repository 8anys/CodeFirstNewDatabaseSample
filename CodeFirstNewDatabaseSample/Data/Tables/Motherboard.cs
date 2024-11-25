using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Motherboard
{
    [Key] 
    public long MotherboardId { get; set; }

    [Required]
    [MaxLength(30)]
    public string MotherboardName { get; set; } = null!;

    public virtual Category MotherboardNavigation { get; set; } = null!;
}
