using System.Web.Mvc;
using CandidateNames.Models;
using DAL;
using ITelentCloudsServices;
using Microsoft.Practices.Unity;
using TelentCloudsServices;
using Unity.Mvc3;

namespace CandidateNames
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<ICandidateRepo, CandidateRepo>();
            container.RegisterType<IFileService,FileService>();
            container.RegisterType<ICounterService, CounterService>();
            container.RegisterType<IValidationService, NamePatternValidationService>();
            container.RegisterType<ISearchForenameService, SearchForenameService>();
            container.RegisterType<IDataService<Company>, CompanyDataService>();
            container.RegisterType<IDataService<UserDetail>, UserDataService>();
            container.RegisterType<IDataService<BillingDetails>, BillingDataService>();
            
          

            return container;
        }
    }
}