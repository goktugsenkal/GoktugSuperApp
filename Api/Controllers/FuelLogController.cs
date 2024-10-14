using Core;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/fuel-log")]
public class FuelLogController(IFuelLogRepository fuelLogRepository) 
    : ControllerBase
{
    [HttpPost]
    public ActionResult<FuelLog>
        CreateFuelLog(FuelLog fuelLog)
    {
        fuelLogRepository.CreateFuelLog(fuelLog);
        return Ok();
    }
}