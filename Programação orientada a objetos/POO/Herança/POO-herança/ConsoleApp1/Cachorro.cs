using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    public class Cachorro : Animal // ":" indica herança (Cachorro É UM Animal)
    {
        public void Latir() // Método específico de Cachorro
        {
            Console.WriteLine($"{Nome} diz Au Au!");
        }
    }
}
