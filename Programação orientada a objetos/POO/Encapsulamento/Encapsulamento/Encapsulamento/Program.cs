using Encapsulamento;

ContaBancaria conta = new ContaBancaria();
conta.Depositar(100);// Válido
//conta.Saldo(-100); // Erro! O setter é privado
Console.WriteLine($"Saldo: {conta.Saldo}"); // Só leitura via get
