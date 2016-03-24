using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNanoHello.Service
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {

            Bind<INotifyService>().To<NotifyService>();
#if DEBUG
            Bind<IMessageService>().To<MockMessageService>();
#else
            Bind<IMessageService>().To<MessageService>();
#endif

        }
    }
}
