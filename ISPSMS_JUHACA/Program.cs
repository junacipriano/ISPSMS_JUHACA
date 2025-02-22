using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using Infastructure.Repositories;
using Unity;
using Unity.Lifetime;
using Infastructure.Data.Repositories;

namespace ISPSMS_JUHACA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer UnityC = new UnityContainer();
            UnityC.RegisterType<IUnitOfWork,UnitOfWork>(new HierarchicalLifetimeManager());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.



            //     var ConnectedSubscribersRepository = UnityC.Resolve<IConnectedSubscribersRepository>();
            var unitOfWork = UnityC.Resolve<IUnitOfWork>();
            var Subs = new SubscribersForm(unitOfWork);
            // new AppUserFormPresenter(unitOfWork, appUserForm);
            Application.Run(Subs);

           // Application.Run(new SubscribersForm(ConnectedSubscribersRepository));
        }
    }
}