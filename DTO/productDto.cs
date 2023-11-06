using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;


namespace DTO
{
    public class productDto
    {
        public int IdProductDto { get; set; }

        public int? IdCategoryDto { get; set; }
        //public string categoryName { get; set; }
        public string? NameProductDto { get; set; }

        public int? AmountInMelayDto { get; set; }

        public string? ImgDto { get; set; }

        public double CostDto { get; set; }
    }
}
