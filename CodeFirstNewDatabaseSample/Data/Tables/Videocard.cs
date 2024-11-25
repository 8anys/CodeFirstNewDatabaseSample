using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Videocard
{
    [Key]
    public long VideocardId { get; set; }

    [Required]
    [MaxLength(10)]
    public string VideocardSeries { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string VideocardName { get; set; } = null!;

    public virtual Category VideocardNavigation { get; set; } = null!;
}
