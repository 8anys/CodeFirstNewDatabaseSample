using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Ram
{
    [Key]
    public long RamId { get; set; }

    [Required]
    [MaxLength(30)]
    public string RamName { get; set; } = null!;

    public virtual Category RamNavigation { get; set; } = null!;
}
