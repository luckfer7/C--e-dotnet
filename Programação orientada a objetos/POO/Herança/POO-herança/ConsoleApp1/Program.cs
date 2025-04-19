using Herança;

Cachorro meuCachorro = new Cachorro();
meuCachorro.Nome = "Neguinho"; // Propriedade herdada de Animal
meuCachorro.Comer(); // Método herdado (saída: "Rex está comendo.")
meuCachorro.Latir(); // Método específico (saída: "Rex diz: Au Au!")