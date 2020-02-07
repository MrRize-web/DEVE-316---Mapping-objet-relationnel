using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendueCode.ORM
{
    public class Intervenant
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        public Intervenant()
        {
            Interventions = new List<Interventions>();
         
        }

        public virtual ICollection<Interventions> Interventions { get; set; }

    }
}
