using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;
using Unity.AspNet.WebApi;
using WebApplication1.Repository;



namespace WebApplication1.UnityDependecyInjection
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // Registre os tipos e as interfaces correspondentes aqui
            container.RegisterType<EmpresaRepository>();
            container.RegisterType<CargoRepository>();
            container.RegisterType<ColaboradorRepository>();
            container.RegisterType<HistoricoCargoRepository>();

            // Configure o Unity para usar o container como o resolver de dependências padrão para o Web API
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}