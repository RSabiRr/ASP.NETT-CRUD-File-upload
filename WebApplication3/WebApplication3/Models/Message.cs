using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
        [Column(TypeName="nText")]
        public string Messagee { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [Column(TypeName="nText")]
        public string About { get; set; }
         
        public DateTime CreateDate { get; set; }
    }
}
