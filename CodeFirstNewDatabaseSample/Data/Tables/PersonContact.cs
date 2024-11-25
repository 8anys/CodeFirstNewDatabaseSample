using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class PersonContact
{
    [Key]
    public long PersonContactId { get; set; }

    public long ContactTypeId { get; set; }

    public long PersonId { get; set; }

    [Required]
    [MaxLength(100)]
    public string City { get; set; } = null!;

    public virtual ContactType ContactType { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
