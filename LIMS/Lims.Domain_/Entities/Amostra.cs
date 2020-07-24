using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Domain.Entities
{
    public class Amostra
    {
        public Guid Id { get; set; }
        public Atleta codAtleta { get; set; }
        public Amostra Sexo { get; set; }
        public string modalidade { get; set; }

        public DateTime DataColeta { get; set; }

        public string laudo { get; set; }
    }
}
