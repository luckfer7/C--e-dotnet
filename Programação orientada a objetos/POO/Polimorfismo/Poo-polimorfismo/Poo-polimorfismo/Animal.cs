using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_polimorfismo
{
    public class Animal
    {
        public string Nome { get; set; }

        // Método VIRTUAL (pode ser sobrescrito pelas classes filhas)
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som genérico de animal");
        }
    }
}
