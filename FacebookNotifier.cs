using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class FacebookNotifier : NotifierDecorator
    {
        public FacebookNotifier(Notifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Отправка на Facebook: {message}");
        }
    }
}
