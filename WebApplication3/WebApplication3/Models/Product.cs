using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required(ErrorMessage = "Title yaz")]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFromFile ImageFile { get; set; }
        [Column(TypeName="nText"), Required]
        public string Content { get; set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        [ForeignKey("Valuation")]
        public int ValuationId { get; set; }
        public Valuation Valuation { get; set; }
        [ForeignKey("Category"),Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
