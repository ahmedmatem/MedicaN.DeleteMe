using System;
using System.Collections.Generic;

namespace MedicaN.Data.Models;

public partial class Examination
{
    public int ExaminationId { get; set; }

    public DateOnly ExaminationDate { get; set; }

    public string? Condition { get; set; }

    public string? Treatment { get; set; }

    public int? DoctorId { get; set; }

    public int? PatientId { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual Patient? Patient { get; set; }
}
