using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Street
{
    [Key]
    public long StreetId { get; set; }

    public long CityId { get; set; }

    [Required]
    [MaxLength(150)]
    public string Street1 { get; set; } = null!;

    public virtual City City { get; set; } = null!;
}
