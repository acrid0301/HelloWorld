using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNanoHello.Service
{
    public interface INinjectModuleBootstrapper
    {
        IList<INinjectModule> GetModules();
    }
}
