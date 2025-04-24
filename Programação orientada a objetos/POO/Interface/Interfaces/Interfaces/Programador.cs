using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Programador : IFuncionario
    {
        public void Trabalhar()
        {
            Console.WriteLine("Escrevendo código em C#");
        }
    }
}
