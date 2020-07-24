using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioASPNET.Models
{
    public class Analise
    {
        public enum Resultado
        {
            Positivo,
            Negativo,
            Suspeito,
            Reanalisar
        }

        public int SampleId { get; set; }

        public Sample Sample { get; set; }
        
        public int LaudoId { get; set; }

        public Laudo Laudo { get; set; }
    }
}
