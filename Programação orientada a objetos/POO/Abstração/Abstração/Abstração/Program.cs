using Abstração;

// Criando lista de notificadores (tratados como o tipo abstrato)

List<Notificador> notificadores = new List<Notificador>
{
    new EmailNotificador(),
    new SMSNotificador(),
    new PushNotificador()
};

foreach (var notificador in notificadores)
{
    notificador.PrepararEnvio(); // Método concreto da classe abstrata
    notificador.EnviarNotificação("Sua fatura vence amanhã!");// Método abstrato implementado
}

