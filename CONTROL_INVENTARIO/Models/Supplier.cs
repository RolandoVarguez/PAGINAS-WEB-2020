using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CONTROL_INVENTARIO.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Display(Name = "Codigo")]
        public int SupplierCode { get; set; }
        [Display(Name = "Nombre Proveedor")]
        public string SupplierName { get; set; }
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Display(Name = "Telefono")]
        public string Phone { get; set; }
        [Display(Name = "Direccion")]
        public string Address { get; set; }
    }
}