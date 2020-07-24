using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioASPNET.Models
{
    public class Laudo
    {
        public int Id { get; set; }

        public Resultado Restultado { get; set; }

        public ICollection<Analise> Analises { get; set; }
    }
}
