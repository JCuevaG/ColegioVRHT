[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ColegioVRHT.WebClient.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ColegioVRHT.WebClient.App_Start.NinjectWebCommon), "Stop")]

namespace ColegioVRHT.WebClient.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using ColegioVRHT.BusinessLogic.Interface;
    using ColegioVRHT.BusinessLogic.Implementation;
    using ColegioVRHT.Repository;
    using ColegioVRHT.Repository.Interface;
    using ColegioVRHT.Repository.Implementation;

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
            kernel.Bind<ColegioVRHTContext>().ToSelf().InRequestScope();

            kernel.Bind(typeof(IBusinessLogicBase<>)).To(typeof(BusinessLogicBase<>)).InRequestScope();
            kernel.Bind<IPersonBusinessLogic>().To<PersonBusinessLogic>();
            kernel.Bind<IAlumnoBusinessLogic>().To<AlumnoBusinessLogic>();
            //kernel.Bind<IAlumnoRepository, IAlumnoBusinessLogic>().To<AlumnoBusinessLogic<,>>();
            kernel.Bind<ISexoBusinessLogic>().To<SexoBusinessLogic>();
            //kernel.Bind<ISedeBusinessLogic>().To<SedeBusinessLogic>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<,>)).InRequestScope();
            kernel.Bind<IPersonRepository>().To<PersonRepository>().InRequestScope();
            kernel.Bind<IAlumnoRepository>().To<AlumnoRepository>().InRequestScope();
            kernel.Bind<ISexoRepository>().To<SexoRepository>().InRequestScope();
            //kernel.Bind<ISedeRepository>().To<SedeRepository>().InRequestScope();

        }        
    }
}
