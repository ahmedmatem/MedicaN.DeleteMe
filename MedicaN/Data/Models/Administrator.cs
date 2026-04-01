using System;
using System.Collections.Generic;

namespace MedicaN.Data.Models;

public partial class Administrator
{
    public int AdminId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
