using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.AirlinesModels;

public partial class Store
{
    [Key]
    public long StoreId { get; set; }

    [Required]
    [MaxLength(100)]
    public string StoreFullName { get; set; } = null!;

    public long EmployeeId { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
