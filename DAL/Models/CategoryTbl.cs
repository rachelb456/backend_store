using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CategoryTbl
{
    public int IdCategory { get; set; }

    public string? NameCategory { get; set; }

    public virtual ICollection<ProductTbl> ProductTbls { get; } = new List<ProductTbl>();
}
