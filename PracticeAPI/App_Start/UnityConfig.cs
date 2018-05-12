using AutoMapper;
using PracticeAPI.Controllers;
using PracticeAPI.Logic;
using PracticeAPI.Repository;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.WebApi;
using PracticeAPI.Mapper;
using System.Web;

namespace PracticeAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

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