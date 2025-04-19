using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_polimorfismo
{
    public class Cachorro : Animal
    {
        // Método SOBRESCRITO (OVERRIDE)
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} diz: Au Au!");
        }
    }
}
