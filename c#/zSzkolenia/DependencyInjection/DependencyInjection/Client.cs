using System.ComponentModel;
using DependencyInjection.interfaces;
using Autofac;
using Autofac.Core;
using DependencyInjection.dbNames.Comand;

namespace DependencyInjection.dbNames
{
    public class Client 
    {
        public T Resolve<T>()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Postgres>().As<IdbName>().WithParameters(new Parameter[]{new NamedParameter("insert","toJestInsert"), new NamedParameter("update", "toJestUpdate") });
            var container = builder.Build();



            /*builder.RegisterType<UpdateClas>().As<IUpdate>().WithParameters(new Parameter[] { new NamedParameter("text", "toJestUpdateBasssss")});
            var update = builder.Build();
            builder.RegisterType<InsertClas>().As<IInsert>().WithParameters(new Parameter[] { new NamedParameter("text", "toJestInsertBasssss") });
            var insert = builder.Build();*/

            using (var scope = container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<T>();
                return writer;
            }/*
            using (var scope = container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<T>();
            }
            using (var scope = container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<T>();
            }*/
        }

        public string MainToUse()
        {
            var db = Resolve<IdbName>();
            /*var upd = Resolve<IUpdate>();
            var inse = Resolve<IInsert>();*/
            return db.pgMethod("_lotto");
        }
    }
}