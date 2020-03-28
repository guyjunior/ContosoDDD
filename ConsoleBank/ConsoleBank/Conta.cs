using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBank
{
    public abstract class Conta
    {
        private decimal saldo;
        public decimal Saldo { get => saldo; private set => saldo = value; }

        public virtual void Sacar(decimal valor)
        {
            
            if (valor > 0 && Saldo > valor)
            {
                Saldo -= valor;
                Console.WriteLine("\n=============================");
                Console.WriteLine("\nVOCÊ SACOU " + valor);
            }
            else
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("\nVOCÊ NÃO TEM ESSE VALOR PARA SACAR");
            }
        }

        public void Depositar(decimal valor)
        {
            
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine("\n=============================");
                Console.WriteLine("\nVOCê DEPOSITOU " + valor);
            }
            else
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("\nVOCÊ NÃO PODE DEPOSITAR VALORES NEGATIVOS");
            }
        }
    }
}
