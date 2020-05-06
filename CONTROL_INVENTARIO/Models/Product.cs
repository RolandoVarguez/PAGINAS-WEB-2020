using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CONTROL_INVENTARIO.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public int Price { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        public Supplier Supplier { get; set; }
    }
}