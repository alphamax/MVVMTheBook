using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface
{
    public class ModuleManager
    {
        public ModuleManager()
        {
            List<Module> modules = Getmodules();
            foreach (var item in modules)
            {
                item.LancerBouclePrincipale();
            }
        }

        private List<Module> Getmodules()
        {
            throw new NotImplementedException();
        }
    }
}
