using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_polimorfismo
{
    public class Gato : Animal
    {
        // Método SOBRESCRITO (OVERRIDE)
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} diz: Miau!");
        }
    }
}
