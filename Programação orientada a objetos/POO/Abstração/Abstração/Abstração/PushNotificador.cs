using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração
{
    public class PushNotificador : Notificador
    {
        public override void EnviarNotificação(string mensagem)
        {
            Console.WriteLine($"Enviando notificação push: {mensagem}");
        }
    }
}
