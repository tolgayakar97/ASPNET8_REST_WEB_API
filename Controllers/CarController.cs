using CarApi_Dotnet8.Data;
using CarApi_Dotnet8.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarApi_Dotnet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private DataContext _context;

        public CarController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //Manages Http Get requests.
        public async Task<ActionResult<List<Car>>> GetAllCars()
        {
            var carsList = await _context.Cars.ToListAsync();

            return carsList;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            try
            {
                var car = await _context.Cars.FindAsync(id);

                if (car is null)
                {
                    throw new KeyNotFoundException();
                }

                return Ok(car);

            }
            catch
            {
                //Exception handling operations
                throw;
            }
        }

        [HttpPost] //Handles HTTP POST requests.
        public async Task<ActionResult<Car>> AddCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync(); //Store data in database, save changes async shall be called.

            return Ok(await _context.Cars.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Car>> UpdateCar(Car updatedCar)
        {
            try
            {
                var oldCar = await _context.Cars.FindAsync(updatedCar.Id);

                if (oldCar is null)
                {
                    throw new KeyNotFoundException();
                }

                oldCar.Name = updatedCar.Name;
                oldCar.Model = updatedCar.Model;
                oldCar.HP = updatedCar.HP;

                await _context.SaveChangesAsync();

                return Ok(await _context.Cars.ToListAsync());
            }
            catch
            {
                throw;
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Car>> DeleteCar(int id)
        {
            try
            {
                var car = await _context.Cars.FindAsync(id);

                if (car is null)
                {
                    throw new KeyNotFoundException();
                }

                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();

                return Ok(car);

            }
            catch
            {
                //Exception handling operations
                throw;
            }
        }
    }
}
