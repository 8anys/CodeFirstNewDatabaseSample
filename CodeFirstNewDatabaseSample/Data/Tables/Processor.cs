using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Processor
{
    [Key]
    public long ProcessorId { get; set; }

    [Required]
    [MaxLength(30)]
    public string ProcessorName { get; set; } = null!;

    [MaxLength(10)]
    public string ProcessprCore { get; set; } = null!;

    public virtual Category ProcessorNavigation { get; set; } = null!;
}
