using NotificationLibraryWithDecoratorPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationLibraryWithDecoratorPattern.Notifiers
{
    public class SlackNotifier : BaseNotifier
    {
        public override string Send(string message)
        {
            throw new NotImplementedException();
        }
    }
}
