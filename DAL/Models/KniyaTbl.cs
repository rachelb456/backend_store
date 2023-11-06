using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KniyaTbl
{
    public int IdKniya { get; set; }

    public double? SumKniya { get; set; }

    public int? IdUser { get; set; }

    public DateTime? DateKniya { get; set; }

    public virtual UserTbl? IdUserNavigation { get; set; }

    public virtual ICollection<ProductsOrderTbl> ProductsOrderTbls { get; } = new List<ProductsOrderTbl>();
}
