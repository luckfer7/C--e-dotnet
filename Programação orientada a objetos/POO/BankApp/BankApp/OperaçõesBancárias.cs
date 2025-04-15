
namespace BankApp
{
    class OperaçõesBancárias
    {
        decimal saldo = 1000;

        public void ChecarSaldo()
        {
            Console.WriteLine($"Seu saldo atual: {saldo}");
        }

        public void Depositar()
        {
            Console.WriteLine($"Informe o valor a ser depositado R$: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valorDepositado) && valorDepositado > 0)
            {
                saldo = saldo + valorDepositado;
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
        public void Sacar()
        {
            Console.WriteLine($"Informe o valor a ser sacado. Seu saldo atual é: {saldo}");
            if (decimal.TryParse(Console.ReadLine(), out decimal valorASacar) && valorASacar > 0)
            {
                if (valorASacar <= saldo)
                {
                    saldo = saldo - valorASacar;
                    Console.WriteLine($"Valor sacado: {valorASacar}");
                    Console.WriteLine($"Seu saldo atual é de: {saldo}");
                }
                else
                {
                    Console.WriteLine("Alguma coisa deu errado!");
                }
            }

            else
            {
                Console.WriteLine("Valor invalido");
            }

        }
        
    }
}
