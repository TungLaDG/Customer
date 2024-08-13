using Microsoft.AspNetCore.Mvc;
using Customer.Models;
using Customer.Repository;

namespace Customer.Controllers
{
    public class CustomerController : Controller
    {
        carmanagContext ctx = new carmanagContext();
        CarContext carctx = new CarContext();
        
        public IActionResult Index()
        {
            var categories = new CategoryRepo(ctx).getAllCategory();
            ViewData["Category"] = categories;
            var cars = new CarRepository(ctx).getAllCar();
            ViewData["Car"] = cars;
            return View();
        }
        public IActionResult Category(int id)
        {
            var categories = new CategoryRepo(ctx).getAllCategory();
            ViewData["Category"] = categories;
            var cars = new CarRepository(ctx).getAllCarByCategoryId(id);
            ViewData["Cars"] = cars;
            return View();
        }

        public IActionResult details(string id)
        {
            List<Car> cars = ctx.Cars.Where(x => x.FrameId == id).ToList();

            return View(cars);
        }
    }
}
