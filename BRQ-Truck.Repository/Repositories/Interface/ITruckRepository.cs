using BRQ_Truck.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BRQ_Truck.Repository.Repositories.Interface
{
    public interface ITruckRepository
    {
        Task<IList<Truck>> GetAll();
        Task<Truck> Get(int id);
        Task<bool> Insert(Truck truck);
        Task<bool> Update(Truck truck);
        Task Delete(int id);
    }
}
