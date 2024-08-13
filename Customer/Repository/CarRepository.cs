using Customer.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Repository
{
    public class CarRepository : ICar
    {
        private carmanagContext _context;

        public CarRepository(carmanagContext ctx)
        {
            _context = ctx;
        }
        public List<Car> getAllCarByCategoryId(int id)
        {
            return _context.Cars.Where(x=>x.CategoryId == id).ToList();
        }


        public List<Car> getAllCar()
        {
            return _context.Cars.ToList();
        }
    }
}
