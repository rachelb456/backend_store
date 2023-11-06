using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProductTbl
{
    public int IdProduct { get; set; }

    public int? IdCategory { get; set; }

    public string? NameProduct { get; set; }

    public int? AmountInMelay { get; set; }

    public string? Img { get; set; }

    public double? Cost { get; set; }

    public virtual CategoryTbl? IdCategoryNavigation { get; set; }

    public virtual ICollection<ProductsOrderTbl> ProductsOrderTbls { get; } = new List<ProductsOrderTbl>();
}
