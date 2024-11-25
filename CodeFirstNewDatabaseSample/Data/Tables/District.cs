using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class District
{
    [Key]
    public long DistrictId { get; set; }

    [Required]
    [MaxLength(30)]
    public string DistrictName { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
