using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Policy
{
    public int Id { get; set; }

    public string ClientId { get; set; } = null!;

    public int CompanyCode { get; set; }

    public DateTime StartDate { get; set; }

    public virtual Client Client { get; set; } = null!;
}
