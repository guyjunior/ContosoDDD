using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBank
{
    public class Report
    {
        public decimal ContaSaldo { get; private set; }

        public void Somar(Conta conta)
        {
            this.ContaSaldo += conta.Saldo;
        }
    }
}
