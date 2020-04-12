using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationLibraryWithDecoratorPattern.Core
{
    public abstract class BaseNotifier
    {
        public abstract string Send(string message);
    }
}
