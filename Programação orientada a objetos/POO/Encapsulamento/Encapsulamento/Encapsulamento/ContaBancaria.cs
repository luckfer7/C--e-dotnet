using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private decimal _saldo; // Campo privado (só acessível dentro da classe)

        // Propriedade pública com controle
        public decimal Saldo
        {
            get { return _saldo; }
            private set
            {
                if (value >= 0) // Validação
                    _saldo = value;
            }
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                Saldo += valor; // Usa a propriedade (não o campo diretamente)
        }
    }
}
