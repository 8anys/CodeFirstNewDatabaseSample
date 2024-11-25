using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Ssd
{
    [Key]
    public long SsdId { get; set; }

    [Required]
    [MaxLength(30)]
    public string SsdName { get; set; } = null!;

    [MaxLength(10)]
    public string SsdMemory { get; set; } = null!;

    public virtual Category SsdNavigation { get; set; } = null!;
}
