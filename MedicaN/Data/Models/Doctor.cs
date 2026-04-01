using System;
using System.Collections.Generic;

namespace MedicaN.Data.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Speciality { get; set; } = null!;

    public string? Phone { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Examination> Examinations { get; set; } = new List<Examination>();

    public virtual User User { get; set; } = null!;
}
