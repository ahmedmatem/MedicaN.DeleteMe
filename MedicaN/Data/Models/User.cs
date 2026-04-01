using System;
using System.Collections.Generic;

namespace MedicaN.Data.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual ICollection<Administrator> Administrators { get; set; } = new List<Administrator>();

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    public virtual Role Role { get; set; } = null!;
}
