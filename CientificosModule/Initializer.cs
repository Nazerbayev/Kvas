using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CientificosModule
{
    [Module(ModuleName="ModuloCientificos")]
    public class Initializer : IModule
    {
        private IUnityContainer _unity;
        private IRegionManager _rm;
        public void Initialize(IUnityContainer container, IRegionManager manager)
        {
            _unity = container;
            _rm = manager;
        }
    }
}
