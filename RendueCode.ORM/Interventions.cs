using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendueCode.ORM
{
    public class Interventions
    {
        [Key]
        public int IdInterventions { get; set; }
    
        [Required]
        public DateTime Ouverture_intervention { get; set; }
        [Required]
       
        public DateTime Fermeture_intervention { get; set; }
        //test1azea
        public virtual ICollection<Intervenant> Intervenant { get; set; }
        public virtual matériel matériel { get; set; }
        public virtual véhicule Véhicule { get; set; }

    }
}
