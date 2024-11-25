using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Hdd
{
    [Key]
    public long HddId { get; set; }

    [Required]
    [MaxLength(30)]
    public string HddName { get; set; } = null!;

    [MaxLength(10)]
    public string HddMemory { get; set; } = null!;

    public virtual Category HddNavigation { get; set; } = null!;
}
