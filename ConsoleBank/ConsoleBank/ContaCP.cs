using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBank
{
    public class ContaCP : Conta
    {
        private decimal taxa;

        public decimal Taxa { get => taxa; set => taxa = value; }

        public ContaCP()
        {
            this.Taxa = 0.2m; 
        }

        
        public override void Sacar(decimal valor) 
        {
            base.Sacar(valor + (this.taxa * valor));
            
        }
    }
}
