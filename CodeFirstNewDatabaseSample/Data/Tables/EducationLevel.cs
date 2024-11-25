using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class EducationLevel
{
    [Key]
    public long EducationLevelId { get; set; }

    [Required]
    [MaxLength(100)]
    public string EducationLevelFull { get; set; } = null!;

    [Required]
    [MaxLength(10)]
    public string EducationLevelShort { get; set; } = null!;

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
