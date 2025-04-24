using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    public abstract class Notificador
    {
        //Método abstrato (todas as subclasses DEVEM implementar)
        public abstract void EnviarNotificação(string mensagem);

        //Método concreto (compartilhado por todas as subclasses)
        public void PrepararEnvio()
        {
            Console.WriteLine("Preparando sistema de envio...");
        }
        
    }
}
