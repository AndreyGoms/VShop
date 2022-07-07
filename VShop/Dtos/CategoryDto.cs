using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VShop.Models;

namespace VShop.Dtos
{
    public class CategoryDto
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="The name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }

    }
}
