using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendueCode.ORM
{
    public class véhicule
    {
             [Key]
        public int IdVehicule { get; set; }
        [Required]
        [StringLength(20)]
        public string Marque { get; set; }
        [Required]
        [StringLength(15)]
        public string Immatriculation { get; set; }
        [Required]
        public float Volume { get; set; }
        public virtual ICollection<Interventions> Interventions { get; set; }
        public véhicule()
        {
            Interventions = new List<Interventions>();
        }
    }
}
