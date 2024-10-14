using Core.Entities;
using Core.Helpers;

namespace Core;

public interface IFuelLogRepository
{
    Task<PagedList<FuelLog>> GetAllFuelLogsAsync();
    Task<FuelLog?> GetFuelLogByIdAsync(int id);
    void CreateFuelLog(FuelLog fuelLog);
    void UpdateFuelLog(FuelLog fuelLog);
    void DeleteFuelLog(FuelLog fuelLog);
}