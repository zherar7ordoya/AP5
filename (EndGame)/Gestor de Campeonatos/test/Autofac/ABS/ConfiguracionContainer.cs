using Autofac;
using BEL;
using BLL;
using DAL;

namespace ABS
{
    public static class ConfiguracionContainer
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Modelo>().As<IModelo>();
            builder.RegisterType<Procesador>().As<IProcesador>();
            builder.RegisterType<Database>().As<IDatabase>();

            return builder.Build();
        }
    }
}
