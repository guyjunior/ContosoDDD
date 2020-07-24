using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Domain.Entities
{
    public class Atleta
    {
        public Guid Id { get; set; }
        public int codAtleta { get; set; }
        
        public string Sexo { get; set; }
        public string modalidade { get; set; }
    }
}
