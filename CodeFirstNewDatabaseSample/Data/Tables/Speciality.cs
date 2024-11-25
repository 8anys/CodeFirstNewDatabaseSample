using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Speciality
{
    [Key]
    public long SpecialityId { get; set; }

    [Required]
    [MaxLength(100)]
    public string SpecialityFullName { get; set; }
    [Required]
    [MaxLength(10)]
    public string SpecialityShortName { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
