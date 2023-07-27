namespace DP.DesignPatterns.Structural.Decorator
{
    public class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();

                INotification notification = new SystemNotification();


                if (text.Length <= 16)
                    notification = new SmsNotification(notification);

                if (Random())
                    notification = new EmailNotification(notification);


                notification.Send(text);
            }

        }
        private static bool Random()
        {
            return DateTime.UtcNow.Second % 2 == 0;
        }
    }
}
