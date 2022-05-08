using Dukkantek.Domain.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dukkantek.API.DTOs.Product
{
    public class SaleDto 
    {
        [Key]
        [Display(Name = "Product Id:")]
        [Required(ErrorMessage = "The field {0} is required")]
        public int Id { get; set; }



    }
}
