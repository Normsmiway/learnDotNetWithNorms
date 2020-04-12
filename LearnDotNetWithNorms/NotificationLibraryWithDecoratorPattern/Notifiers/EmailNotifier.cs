using NotificationLibraryWithDecoratorPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationLibraryWithDecoratorPattern.Notifiers
{
    public class EmailNotifier : BaseNotifier
    {
        public override string Send(string message)
        {
            throw new NotImplementedException();
        }
    }
}
