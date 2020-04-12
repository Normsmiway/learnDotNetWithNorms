using NotificationLibraryWithDecoratorPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationLibraryWithDecoratorPattern.Types
{
    public class BaseNotifierWrapper : BaseNotifier
    {

        protected BaseNotifier _notifier;

        public BaseNotifierWrapper(BaseNotifier notifier)
        {
            _notifier = notifier;
        }
        public override string Send(string message)
        {
            return _notifier.Send(message);
        }
    }
}
