using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Cooler
{
    [Key]
    public long CoolerId { get; set; }

    [Required]
    [MaxLength(30)]
    public string CoolerName { get; set; } = null!;

    public virtual Category CoolerNavigation { get; set; } = null!;
}
