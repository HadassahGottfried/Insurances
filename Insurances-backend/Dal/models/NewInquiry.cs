using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class NewInquiry
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public double SalaryAmount { get; set; }

    public int StatusCode { get; set; }

    public virtual Status StatusCodeNavigation { get; set; } = null!;
}
