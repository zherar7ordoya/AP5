using System;
using System.Windows.Forms;
using Autofac;
using BEL;

namespace UIL
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Container = Configure();
            Application.Run(new ProductoForm(Container.Resolve<IProductoRepository>()));
        }

        // --- INVERSIÓN DE DEPENDENCIAS --------------------------------------
        public static IContainer Container;

        /// <summary>
        /// Setting dependency injection
        /// </summary>
        /// <returns></returns>
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ProductoRepository>().As<IProductoRepository>();
            builder.RegisterType<ProductoForm>();

            return builder.Build();
        }

    }
}
