using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleID { get; set; } 
        public string Product {  get; set; }
        public DateTime Date {  get; set; }
    }
}
