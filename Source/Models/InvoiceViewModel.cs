using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDFDemo.Models
{
    public class InvoiceViewModel
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }
        
        public DateTime DeliveryDate { get; set; }

        public decimal TotalAmount { get; set; }

        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public string ItemName { get; set; }

        public decimal Price { get; set; }
    }
}
