using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class City
{
    [Key]
    public long CityId { get; set; }

    public long DistrictId { get; set; }

    [Required]
    [MaxLength(30)]
    public string CityName { get; set; } = null!;

    public virtual District District { get; set; } = null!;

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();
}
