using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Cake
    {
        public string Sabor;
        public string Recheio;
        public string Cobertura;
        public int Camadas;
        public string Tamanho;
        public Cake(string sabor, string recheio, string cobertura, int camadas, string tamanho)
        {
            Sabor = sabor;
            Recheio = recheio;
            Cobertura = cobertura;
            Camadas = camadas;
            Tamanho = tamanho;
            //Sabor = "Chocolate";
            //Recheio = "Morango";
            //Cobertura = "Chocolate";
            //Camadas = 2;
            //Tamanho = "Familia";
        }
    }
}
