using AutoMapper;
using Microsoft.Practices.Unity.Configuration;
using PracticeAPI.Controllers;
using PracticeAPI.Logic;
using PracticeAPI.Mapper;
using PracticeAPI.Repository;
using System;
using System.Web;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.WebApi;

namespace PracticeAPI
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            //container.LoadConfiguration();

            MapperConfiguration mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMissingTypeMaps = true;
                cfg.AddProfile<AutoMapperPracticeMapper>();
            });

            IMapper mapper = mapConfig.CreateMapper();
            container.RegisterInstance(mapper);

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPracticeLogic, PracticeLogic>();
            container.RegisterType<IPracticeRepo, PracticeRepo>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<HttpContextBase>(new InjectionFactory(c => new HttpContextWrapper(HttpContext.Current)));

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}