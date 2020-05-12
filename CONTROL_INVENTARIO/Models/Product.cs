using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CONTROL_INVENTARIO.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Codigo")]
        public int ProductCode { get; set; }
        [Display(Name="Nombre")]
        public string ProductName { get; set; }
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Display(Name = "Cantidad")]
        public string Quantity { get; set; }
        [Display(Name = "Precio")]
        public int Price { get; set; }
        
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        

        public Supplier Supplier { get; set; }
    }
}