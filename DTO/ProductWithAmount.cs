using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductWithAmount
    {
     //כמות של מהמוצר 
        public int ProductId { get; set; }  
        public int Amount { get; set; }
         public double FinalPrice { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        
        

    }
}
