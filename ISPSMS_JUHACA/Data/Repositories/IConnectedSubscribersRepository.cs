using Domain.Models;
using ISPSMS_JUHACA.Data;

namespace ISPSMS_JUHACA.Data.Repositories
{
    public interface IConnectedSubscribersRepository : IRepository<ConnectedSubscribers>
    {
        void Update(ConnectedSubscribers obj);

        void Save();
       
    }
}