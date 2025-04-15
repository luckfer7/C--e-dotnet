using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Car
    {
        //ATRIBUTOS (OU CARACTERISTICAS)
        public string Name; 
        public string color;
        public int Year;
        public string Model;
        public string Brand;

        public void ComprarCarro()
        {
            Console.WriteLine("Comprando carro...");
        }
    }
}
