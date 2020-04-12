using NotificationLibraryWithDecoratorPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationLibraryWithDecoratorPattern.Types
{
    public class SocialAppNotification : BaseNotifierWrapper
    {
        public SocialAppNotification(BaseNotifier notifier) : base(notifier)
        {

        }

        public override string Send(string message)
        {
            //sending 
            var notication= base.Send(message);

            return nameof(SocialAppNotification);
        }

    }
}
