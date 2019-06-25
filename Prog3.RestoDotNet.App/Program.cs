using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Business.Services;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Data.Dals;
using Unity;

namespace wf_restaurante
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
            Application.Run(container.Resolve<Form1>());
        }

        private static void RegisterContainers()
        {
            // Create the container as usual.
            if (container == null)
                container = new UnityContainer();


            // Register your types, for instance:
            container.RegisterSingleton<DbContext, RestoDbContext>();
            container.RegisterType<IApplicationUow, ApplicationUow>();
            container.RegisterType<ITableSvc, TableSvc>();

        }
    }
}
