using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductsOrderDto
    {
        public int IdProductsOrderDto { get; set; }

        public int? IdProductDto { get; set; }

        public int? IdKniyaDto { get; set; }

        public int? AmountDto { get; set; }
    }
}
