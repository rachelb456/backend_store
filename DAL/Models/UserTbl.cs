using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class UserTbl
{
    public int IdUser { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<KniyaTbl> KniyaTbls { get; } = new List<KniyaTbl>();
}
