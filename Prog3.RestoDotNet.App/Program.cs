using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Mapper;
using Prog3.RestoDotNet.Business.Services;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Data.Dals;
using Unity;
using Unity.Lifetime;

namespace Prog3.RestoDotNet.App
{
    static class Program
    {
        private static UnityContainer container;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegisterContainers();
            Application.Run(container.Resolve<FormMain>());
        }

        private static void RegisterContainers()
        {
            // Create the container as usual.
            container = new UnityContainer();

            // Register your types, for instance:
            //container.RegisterSingleton<IMapperCore, GenericMapperCore>();
            container.RegisterType<DbContext, RestoDbContext>();
            container.RegisterType<IApplicationUow, ApplicationUow>();
            container.RegisterType<ITableSvc, TableSvc>();
            container.RegisterType<IOrderSvc, OrderSvc>();
            container.RegisterType<IWaiterSvc, WaiterSvc>();
        }
    }
}
