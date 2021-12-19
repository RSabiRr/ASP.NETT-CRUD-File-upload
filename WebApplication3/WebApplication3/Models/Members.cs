using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string  Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [Column(TypeName="nText")]
        public string About { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [ForeignKey("Sosial")]
        public int SosialId { get; set; }
        public Sosial Sosial { get; set; }
        [ ForeignKey("Positsion")]
        public int PositsionId { get; set; }
        public Positsion Positsion { get; set; }
    }
}
