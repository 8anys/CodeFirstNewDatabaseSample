using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Person
{
    [Key]
    public long PersonId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Fname { get; set; } = null!;

    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(30)]
    public string Sname { get; set; } = null!;

    public DateTime WhenBorn { get; set; }

    public sbyte Sex { get; set; }

    public long EducationLevelId { get; set; }

    public long SpecialityId { get; set; }

    public virtual EducationLevel EducationLevel { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();

    public virtual Speciality Speciality { get; set; } = null!;
}
