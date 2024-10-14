using Core;
using Core.Entities;
using Core.Helpers;

namespace Infrastructure.Data;

public class FuelLogRepository(DataContext context) : IFuelLogRepository
{
    public async Task<PagedList<FuelLog>> GetAllFuelLogsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<FuelLog?> GetFuelLogByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void CreateFuelLog(FuelLog fuelLog)
    {
        context.FuelLogs.Add(fuelLog);
        context.SaveChanges();
    }

    public void UpdateFuelLog(FuelLog fuelLog)
    {
        throw new NotImplementedException();
    }

    public void DeleteFuelLog(FuelLog fuelLog)
    {
        throw new NotImplementedException();
    }
}