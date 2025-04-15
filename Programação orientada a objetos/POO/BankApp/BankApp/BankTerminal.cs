using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class BankTerminal
    {
        OperaçõesBancárias banco = new OperaçõesBancárias();
        public void IniciarPrograma()
        {
            var EmExecução = true;
            while(EmExecução)
            {
                Menu();

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        banco.ChecarSaldo();
                    break;

                    case "2":
                        banco.Depositar();
                    break;

                    case "3":
                        banco.Sacar();
                    break;

                    case "4":
                        Console.WriteLine("Obrigado! Volte sempre!");
                        Environment.Exit(0);
                    break;
                }
            }
        }
        public void Menu()
        {
            Console.WriteLine("===== BANK =====");
            Console.WriteLine("Escolha a opção correspondente: ");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Sacar");
            Console.WriteLine("4. Sair");
        }
    }
}
