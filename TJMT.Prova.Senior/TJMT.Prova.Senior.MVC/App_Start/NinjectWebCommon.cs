[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TJMT.Prova.Senior.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(TJMT.Prova.Senior.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace TJMT.Prova.Senior.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using TJMT.Prova.Senior.Application.Interface;
    using TJMT.Prova.Senior.Application;
    using TJMT.Prova.Senior.Domain.Interfaces.Services;
    using TJMT.Prova.Senior.Domain.Services;
    using TJMT.Prova.Senior.Domain.Interfaces.Repositories;
    using TJMT.Prova.Senior.Infra.Data.Repositories;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<ILivroAppService>().To<LivroAppService>();
            kernel.Bind<IGeneroAppService>().To<GeneroAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ILivroService>().To<LivroService>();
            kernel.Bind<IGeneroService>().To<GeneroService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ILivroRepository>().To<LivroRepository>();
            kernel.Bind<IGeneroRepository>().To<GeneroRepository>();

        }        
    }
}
