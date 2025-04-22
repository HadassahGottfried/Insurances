using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Status
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<NewInquiry> NewInquiries { get; set; } = new List<NewInquiry>();
}
