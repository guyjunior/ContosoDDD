using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleBank
{
    class ATM
    {
        public static decimal Soma { get; private set; }

        static void Main(string[] args)
        {
            int conta;
            int pass;
            int valor;
            int menu;


            Report report = new Report();
            Cliente cliente = new Cliente();
            ContaCC contacc = new ContaCC();
            ContaCP contacp = new ContaCP();
            

            Login(); 

            void Login()
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("===============CONSOLE BANK================");
                Console.WriteLine("===========================================");
                Console.WriteLine("\nQUAL O NÚMERO DA SUA CONTA?");
                conta = int.Parse(Console.ReadLine());
                Console.WriteLine("\nQUAL A SUA SENHA?");
                pass = int.Parse(Console.ReadLine());

                if (cliente.NumeroConta == conta && cliente.Senha == pass)
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("\nINFORMAÇÕES INCORRETAS!\n");
                    Login();
                }
            }

            void Menu()
            {
                Console.WriteLine("\n=============================\n\n" +
                "\nOLÁ " + cliente.Nome + " SEJA MUITO BEM-VINDO!\n" +
                "\n\nO QUE VOCÊ DESEJA?" +
                "\n\n1 - VER O SALDO " +
                "\n2 - FAZER DEPÓSITO CC " +
                "\n3 - SACAR CC " +
                "\n4 - FAZER DEPÓSITO CP" +
                "\n5 - SACAR CP " +
                "\n6 - SAIR \n");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        Soma = contacc.Saldo + contacp.Saldo;
                        
                        Console.WriteLine("\n=============================\n" +
                            "\nSALDO CONTA POUPANÇA: " + contacp.Saldo +
                            "\nSALDO CONTA CORRENTE: " + contacc.Saldo +
                            "\nSALDO TOTAL: " + Soma +
                            "\n=============================\n");
                        break;
                    case 2:
                        Console.WriteLine("\n\nQUAL O VALOR DESEJA DEPOSITAR NA SUA CONTA CORRENTE? \n");
                        valor = int.Parse(Console.ReadLine());
                        contacc.Depositar(valor);
                        
                        Console.WriteLine("\n=============================\n");
                        break;
                    case 3:
                        Console.WriteLine("\n\nSALDO ATUAL: " + contacc.Saldo +
                            "\n\nQUAL O VALOR DESEJA SACAR DA SUA CONTA CORRENTE?  \n");
                        valor = int.Parse(Console.ReadLine());
                        contacc.Sacar(valor);
                        Console.WriteLine("\n=============================\n");
                        break;
                    case 4:
                        Console.WriteLine("\n\nQUAL O VALOR DESEJA DEPOSITAR NA SUA CONTA POUPANÇA? \n");
                        valor = int.Parse(Console.ReadLine());
                        contacp.Depositar(valor);
                        Console.WriteLine("\n=============================\n");
                        break;
                    case 5:
                        Console.WriteLine("\n\nSALDO ATUAL: " + contacp.Saldo +
                            "\n\nQUAL O VALOR DESEJA SACAR DA SUA CONTA POUPANÇA? \n");
                        valor = int.Parse(Console.ReadLine());
                        contacp.Sacar(valor);
                        Console.WriteLine("\n=============================================\n");
                        break;
                    default:
                        Console.WriteLine("\n\nO BANCO CONSOLE AGRADECE A SUA VISITA! ATÉ LOGO! \n");
                        Environment.Exit(0);
                        break;
                }

                Menu(); 
            }
        }
    }
}
