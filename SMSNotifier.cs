using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class SMSNotifier : NotifierDecorator
    {
        public SMSNotifier(Notifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Отправка SMS: {message}");
        }
    }
}
