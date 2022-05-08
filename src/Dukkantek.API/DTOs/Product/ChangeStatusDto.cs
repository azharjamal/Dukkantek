using Dukkantek.Domain.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dukkantek.API.DTOs.Product
{
    public class ChangeStatusDto 
    {
        [Key]
        [Required(ErrorMessage = "The field {0} is required")]
        public int Id { get; set; }

        [Range(0, 2)]
        public Status Status { get; set; }



    }
}
