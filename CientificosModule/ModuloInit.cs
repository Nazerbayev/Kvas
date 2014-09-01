﻿using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CientificosModule.Servicios;
using CientificosModule.Views;

namespace CientificosModule
{
    [Module(ModuleName="ModuloInit")]
    public class ModuloInit : IModule
    {
        private IUnityContainer container;
        private IRegionManager regionManager;

        public ModuloInit(IUnityContainer container, IRegionManager manager)
        {
            this.container = container;
            this.regionManager = manager;

        }

        public void Initialize()
        {
            //Registramos el DataService
            this.container.RegisterType<ICientificosDataService, CientificosDataService>();

            //Registramos las clases utilitarias
            this.container.RegisterType<ISerializador, Serializer>("binario");
            this.container.RegisterType<ISerializador, XmlSerializador>("xml");

            this.regionManager.RegisterViewWithRegion(RegionNames.LeftRegion, () => this.container.Resolve<CientificosListView>());

        }
    }
}