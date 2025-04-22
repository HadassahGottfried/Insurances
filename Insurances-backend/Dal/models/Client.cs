using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Client
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime FormCompletionDate { get; set; }

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();
}
