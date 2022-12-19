using Microsoft.AspNetCore.Mvc;
using TruckManager.src.Context;
using TruckManager.src.Models;

namespace TruckManager.src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TruckController : ControllerBase
    {
        private readonly TruckContext _context; 

        public TruckController(TruckContext context)
        {
            _context = context;
        }

        [HttpGet("AllTrucks")]
        public IActionResult AllTrucks()
        {
            try
            {
                var trucks = _context.Trucks.ToList();

                if (trucks == null)
                {
                    return NoContent();
                }

                return Ok(trucks);
            }
            catch (System.Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> FindTruck(int id)
        {
            try
            {
                var truck = await _context.Trucks.FindAsync(id);

                if(truck == null)
                {
                    return NotFound(new 
                    {
                        msg = "This truck doesnt exist"
                    });
                }

                return Ok(truck);
            }
            catch (System.Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpPost("AddTruck")]
        public async Task<IActionResult> AddTruck(Truck truck)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(truck.Model))
                {
                    return BadRequest(new 
                    {
                        msg = "Fill in all fields"
                    });
                }

                if(truck.Model != "FH" && truck.Model != "FM")
                {
                    return BadRequest(new
                    {
                        msg = "Truck model is invalid. Use 'FH' or 'FM'"
                    });
                }

                if(truck.YearManufacture != DateTime.Now.Year)
                {
                    return BadRequest(new
                    {
                        msg = "Year of Manafucture is incorrect!"
                    });
                }

                if(truck.ModelYear < DateTime.Now.Year)
                {
                    return BadRequest(new 
                    {
                        msg = "Year model truck is incorrect!"
                    });
                }

                truck.CreatedAt = DateTime.Now;
                truck.UpdatedAt = null;

                await _context.Trucks.AddAsync(truck);
                await _context.SaveChangesAsync();

                return Ok(truck);
            }
            catch (System.Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpPatch("UpdateTruck")]
        public async Task<IActionResult> UpdateInfoTruck(Truck truck)
        {
            try
            {
                if(truck == null)
                {
                    return BadRequest(new {
                        msg = "Truck info is null"
                    });
                }

                var findTruck = await _context.Trucks.FindAsync(truck.Id);

                if(findTruck == null)
                {
                    return NotFound(new {
                        msg = "Truck doesnt exist!"
                    });
                }

                if(string.IsNullOrWhiteSpace(truck.Model))
                {
                    return BadRequest(new
                    {
                        msg = "Truck model is null!"
                    });
                }

                if(truck.Model != "FH" && truck.Model != "FM")
                {
                    return BadRequest(new
                    {
                        msg = "Truck model is invalid. Use 'FH' or 'FM'"
                    });
                }

                if(truck.YearManufacture != DateTime.Now.Year)
                {
                    return BadRequest(new
                    {
                        msg = "Year of Manafucture is incorrect!"
                    });
                }

                if(truck.ModelYear < DateTime.Now.Year)
                {
                    return BadRequest(new 
                    {
                        msg = "Year model truck is incorrect!"
                    });
                }

                findTruck.Model = truck.Model;
                findTruck.ModelYear = truck.ModelYear;
                findTruck.YearManufacture = truck.YearManufacture;
                findTruck.UpdatedAt = DateTime.Now;

                _context.Trucks.Update(findTruck);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (System.Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpDelete("DeleteTruck/{id}")]
        public async Task<IActionResult> DeleteTruck(int id){
            try
            {
                var findTruck = await _context.Trucks.FindAsync(id);

                if(findTruck == null)
                {
                    return BadRequest(new {
                        msg = "This truck doesnt exist!"
                    });
                }

                _context.Trucks.Remove(findTruck);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (System.Exception error)
            {
                return BadRequest(error);
            }
        }
    }
}