using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendueCode.ORM
{
    public class matériel
    {

       [Key]
        public int IdMateriel { get; set; }
        [Required]
        [StringLength(50)]
        public string Désignation { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public DateTime DateAchat { get; set; }
        public virtual ICollection<Interventions> Interventions { get; set; }
        public matériel()
        {
            Interventions = new List<Interventions>();
        }
    }
}
