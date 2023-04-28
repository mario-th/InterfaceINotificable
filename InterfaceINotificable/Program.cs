class Program
{
    public interface INotificable
    {
        void Notifica();
    }

    class NotificacionEmail : INotificable
    {
        public void Notifica()
        {
            Console.WriteLine("Tienes un nuevo correo");
            Console.WriteLine("mariotobar543@gmail.com");
        }
    }

    class NotificacionWhatsApp : INotificable
    {
        public void Notifica()
        {
            Console.WriteLine("Tienes una mensaje en WhatsApp");
            Console.WriteLine("33841435");
        }
    }

    class NotificacionSMS : INotificable
    {
        public void Notifica()
        {
            Console.WriteLine("Tienes un SMS");
            Console.WriteLine("33821435");
        }
    }

    static void Main(string[] args)
    {
        NotificacionEmail notificacion = new NotificacionEmail();
        notificacion.Notifica();

        NotificacionWhatsApp whatsApp = new NotificacionWhatsApp();
        whatsApp.Notifica();

        NotificacionSMS sms = new NotificacionSMS();
        sms.Notifica();
    }
}
