using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBank
{
    public class Cliente : Conta
    {
        private string nome;
        private int numero;
        private int senha;

        public string Nome { get => nome; private set => nome = value; }
        public int NumeroConta { get => numero; private set => numero = value; }
        public int Senha { get => senha; private set => senha = value; }

        public Cliente()
        {
            
                Nome = "Tomas Aquino";
                NumeroConta = 123;
                Senha = 456;
           

        }
    }
}
