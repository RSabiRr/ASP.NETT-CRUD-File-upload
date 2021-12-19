using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Settings
    {   
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Mapp { get; set; }
        [Column(TypeName = "nText")]
        public string ContAbout { get; set; }
        [MaxLength(150)]
        public string ContTitle { get; set; }
        [Column(TypeName ="nText")]
        public string About { get; set; }
        [MaxLength(250)]
        public string AboutImage { get; set; }
        [MaxLength(150)]
        public string AbouTitle { get; set; }

    }
}
