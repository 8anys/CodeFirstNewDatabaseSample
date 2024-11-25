using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class ContactType
{
    [Key]
    public long ContactTypeId { get; set; }

    [Required]
    [MaxLength(30)]
    public string? ContactType1 { get; set; }

    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();
}
