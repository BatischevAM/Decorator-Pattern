using Decorator_Pattern;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> admins = new List<string> { "BatischevAM@mer.ci.nsu.ru", "batischevam@mer.ci.nsu.ru" };

        Notifier notifier = new EmailNotifier(admins);

        notifier = new SMSNotifier(notifier);

        notifier = new FacebookNotifier(notifier);

        notifier.Send("Сообщение отправленно");
    }
}