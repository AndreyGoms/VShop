using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VShop.Models;

namespace VShop.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage ="The price is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The description is required")]
        [MinLength(5)]
        [MaxLength(200)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "The stock is required")]
        [Range(1, 9999)]
        public long Stock { get; set; }

        public string? ImageURL { get; set; }

        public Category Category { get; set; }

        public int CategoryID { get; set; }
    }
}
