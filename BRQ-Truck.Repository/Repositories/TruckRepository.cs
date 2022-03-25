using BRQ_Truck.Domain;
using BRQ_Truck.Repository.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQ_Truck.Repository.Repositories
{
    public class TruckRepository : ITruckRepository
    {
        private readonly LocalDbTruck _dbContext;
        public TruckRepository(LocalDbTruck dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Truck> Get(int id)
        {
            try
            {
                return await _dbContext.Truck.Where(t => t.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Truck>> GetAll()
        {
            try
            {
                return await _dbContext.Truck.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Insert(Truck truck)
        {
            try
            {
                if (truck.CheckModel() == true &&
                    truck.CheckYearOfManufacture() &&
                    truck.CheckYearModel())
                {
                    await _dbContext.Truck.AddAsync(truck);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Update(Truck truck)
        {
            try
            {
                if (truck.CheckModel() == true &&
                    truck.CheckYearOfManufacture() &&
                    truck.CheckYearModel())
                {
                    var result = await _dbContext.Truck.FirstOrDefaultAsync(t => t.Id == truck.Id);
                    if (result != null)
                    {
                        _dbContext.Entry(result).State = EntityState.Detached;
                    }
                    _dbContext.Entry(truck).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                var truck = await _dbContext.Truck.Where(t => t.Id == id).FirstAsync();
                _dbContext.Truck.Remove(truck);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
