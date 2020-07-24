using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioASPNET.Models
{
    public class Sample
    {

        public int Id { get; set; }
        public string CodInterno { get; set; }
        public DateTime DataDeCadastro { get; set; }

        public ICollection<Analise> Analises { get; set; }


    }
}
