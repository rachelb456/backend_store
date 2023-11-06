using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProductsOrderTbl
{
    public int IdProductsOrder { get; set; }

    public int? IdProduct { get; set; }

    public int? IdKniya { get; set; }

    public int? Amount { get; set; }

    public virtual KniyaTbl? IdKniyaNavigation { get; set; }

    public virtual ProductTbl? IdProductNavigation { get; set; }
}
