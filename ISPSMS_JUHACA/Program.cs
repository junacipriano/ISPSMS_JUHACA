using Infastructure.Data.Repositories.IRepositories;
using ISPSMS_JUHACA.Data;
using ISPSMS_JUHACA.Data.Repositories;
using Unity;
using Unity.Lifetime;

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
            UnityC.RegisterType<IConnectedSubscribersRepository, ConnectedSubscribersRepository>(new HierarchicalLifetimeManager());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var ConnectedSubscribersRepository = UnityC.Resolve<IConnectedSubscribersRepository>();

            Application.Run(new SubscribersForm(ConnectedSubscribersRepository));
        }
    }
}