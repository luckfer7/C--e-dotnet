using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    public class Animal
    {
        public string Nome { get; set; } // Propriedade comum a todos os animais

        public void Comer() // Método comum
        {
            Console.WriteLine($"{Nome} está  comendo");
        }
    }
}
