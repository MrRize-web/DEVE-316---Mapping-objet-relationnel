using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendueCode.ORM
{
   
        public class ContexteBDD : DbContext
        {
            public ContexteBDD()
                : base("B2_EPSI")
            {

            }
            public virtual DbSet<véhicule> Véhicule { get; set; }
            public virtual DbSet<matériel> Matériel { get; set; }
            public virtual DbSet<Intervenant> Intervenant { get; set; }
            public virtual DbSet<Interventions> Interventions { get; set; }
        }
  }
