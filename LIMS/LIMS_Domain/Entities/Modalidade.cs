using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Domain.Entities
{
    public class Modalidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string susbstancia_proibida { get; set; }

    }
}
