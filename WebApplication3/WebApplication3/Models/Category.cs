using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required(ErrorMessage ="bos saxlamaq olmaz!")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
