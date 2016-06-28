using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface
{
    class ModuleManagerV2
    {
        public ModuleManagerV2()
        {
            List<IKernelModule> modules = Getmodules();
            var interfaces = modules.OfType<IInterfaceModule>();
        }

        private List<IKernelModule> Getmodules()
        {
            throw new NotImplementedException();
        }
    }
}
