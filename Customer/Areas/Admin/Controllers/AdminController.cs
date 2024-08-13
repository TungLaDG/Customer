using Microsoft.AspNetCore.Mvc;
using Model.Models;

namespace Customer.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        carmanagContext ctx = new carmanagContext();
        public IActionResult Index()
        {
            List<Notification> nots = ctx.Notifications.ToList();
            ViewData["Notifi"] = nots;
            int notifi_cont = ctx.Notifications.Where(x => x.Status == true).Count();
            ViewData["NotifiCount"] = notifi_cont;
            return View();
        }
        public IActionResult addcar()
        {
            return View();
        }
        public IActionResult viewcar()
        {
            List<Car> cars = ctx.Cars.ToList();
            return View(cars);
        }

        [HttpPost]
        public IActionResult addcar(Car car)
        {
            ctx.Cars.Add(car);
            ctx.SaveChanges();
            return RedirectToAction("viewcar");
        }

        public IActionResult DeleteCar(string id)
        {
            Car cars = ctx.Cars.Where(x => x.FrameId == id).SingleOrDefault();
            ctx.Cars.Remove(cars);
            ctx.SaveChanges();
            return RedirectToAction("viewcar");
        }
        public IActionResult EditCar(string id)
        {
            Car cars = ctx.Cars.Where(x => x.FrameId == id).SingleOrDefault();
            return View(cars);
        }
        public IActionResult UpdateCar(Car car)
        {
            Car cars = ctx.Cars.Where(x => x.FrameId == car.FrameId).SingleOrDefault();
            if (cars != null)
            {
                cars.CarName = car.CarName;
                cars.Cc = car.Cc;
                cars.Hp = car.Hp;
                cars.Color = car.Color;
                cars.Enginetype = car.Enginetype;
                cars.Size = car.Size;
                cars.Price = car.Price;
                cars.Gear = car.Gear;
                cars.Origin = car.Origin;
            }
            ctx.SaveChanges();
            return RedirectToAction("viewcar");
        }

        /* depot table */
        public IActionResult viewdepot()
        {
            List<Depot> depots = ctx.Depots.ToList();
            return View(depots);
        }
        public IActionResult addtodepot()
        {
            return View();
        }
        [HttpPost]
        public IActionResult adddepot(Depot d)
        {
            ctx.Depots.Add(d);
            ctx.SaveChanges();
            return RedirectToAction("viewdepot");
        }
        public IActionResult DeleteDepot(int id)
        {
            Depot depot = ctx.Depots.Where(y => y.CarId == id).SingleOrDefault();
            ctx.Depots.Remove(depot);
            ctx.SaveChanges();
            return RedirectToAction("viewdepot");
        }
        public IActionResult EditDepot(int id)
        {
            Depot depot = ctx.Depots.Where(x => x.CarId == id).SingleOrDefault();
            return View(depot);
        }
        public IActionResult UpdateDepot(Depot depot)
        {
            Depot depot1 = ctx.Depots.Where(x => x.CarName == depot.CarName).SingleOrDefault();
            if (depot1 != null)
            {
                depot1.Amount = depot.Amount;
                depot1.Sold = depot.Sold;
            }
            ctx.SaveChanges();
            return RedirectToAction("viewdepot");
        }
        // customer table
        public IActionResult viewcustomer()
        {
            List<Customerinf> customerinfs = ctx.Customerinfs.ToList();
            return View(customerinfs);
        }
        public IActionResult Addcustomer()
        {
            return View();
        }
        //public IActionResult addcustomer(Customerinf c)
        //{
        //    ctx.Customerinfs.Add(c);
        //    ctx.SaveChanges();
        //    return RedirectToAction("viewcustomer");
        //}
        public IActionResult DeleteCustomer(int id)
        {
            Customerinf customerinf = ctx.Customerinfs.Where(x => x.Phonenumber == id).SingleOrDefault();
            ctx.Customerinfs.Remove(customerinf);
            ctx.SaveChanges();
            return RedirectToAction("viewcustomer");
        }
        public IActionResult EditCustomer(int id)
        {
            Customerinf customerinf = ctx.Customerinfs.Where(x => x.Phonenumber == id).SingleOrDefault();
            return View(customerinf);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customerinf c)
        {
            Customerinf customerinf = ctx.Customerinfs.Where(x => x.Phonenumber == c.Phonenumber).SingleOrDefault();
            if (customerinf != null)
            {
                customerinf.Customername = c.Customername;
                customerinf.Addres = c.Addres;
                customerinf.Sex = c.Sex;
            }
            ctx.SaveChanges();
            return RedirectToAction("viewcustomer");
        }
        // table Payment
        public IActionResult viewpayment()
        {
            List<Payment> payments = ctx.Payments.ToList();
            return View(payments);
        }
        public IActionResult Addpayment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addpayment(Payment p)
        {
            ctx.Payments.Add(p);
            ctx.SaveChanges();
            return RedirectToAction("viewpayment");
        }
        public IActionResult DeletePayment(int id)
        {
            Payment payments = ctx.Payments.Where(x => x.PayId == id).SingleOrDefault();
            ctx.Payments.Remove(payments);
            ctx.SaveChanges();
            return RedirectToAction("viewpayment");
        }
        public IActionResult EditPayment(int id)
        {
            Payment payments = ctx.Payments.Where(x => x.PayId == id).SingleOrDefault();
            return View(payments);
        }
        public IActionResult UpdatePayment(Payment p)
        {
            Payment pts = ctx.Payments.Where(x => x.PayId == p.PayId).SingleOrDefault();
            if (pts != null)
            {
                pts.Paid = p.Paid;
                pts.Unpaid = p.Unpaid;
                pts.Note = p.Note;
            }
            ctx.SaveChanges();
            return RedirectToAction("viewpayment");
        }
        // Ordering table
        public IActionResult viewordering()
        {
            List<Ordering> orderings = ctx.Orderings.ToList();
            return View(orderings);
        }
        public IActionResult DeleteOrdering(int id)
        {
            Ordering ordering = ctx.Orderings.Where(x => x.OrderId == id).SingleOrDefault();
            ctx.Orderings.Remove(ordering);
            ctx.SaveChanges();
            return RedirectToAction("viewordering");
        }
        public IActionResult EditOrdering(int id)
        {
            Ordering ordering = ctx.Orderings.Where(x => x.OrderId == id).SingleOrDefault();
            return View(ordering);
        }
        public IActionResult UpdateOrdering(Ordering O)
        {
            Ordering or = ctx.Orderings.Where(x => x.OrderId == O.OrderId).SingleOrDefault();
            if (or != null)
            {
                or.Receivedate = O.Receivedate;
            }
            ctx.SaveChanges();
            return RedirectToAction();
        }

        // Category table

        public IActionResult viewcategory()
        {
            List<Category> categories = ctx.Categories.ToList();
            return View(categories);
        }

        public IActionResult addcategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addtocategory(Category c)
        {
            ctx.Categories.Add(c);
            ctx.SaveChanges();
            return RedirectToAction("viewcategory");
        }
        public IActionResult DeleteCategory(int id)
        {
            Category category = ctx.Categories.Where(y => y.Id == id).SingleOrDefault();
            ctx.Categories.Remove(category);
            ctx.SaveChanges();
            return RedirectToAction("viewcategory");
        }
        public IActionResult EditCategory(int id)
        {
            Category category = ctx.Categories.Where(x => x.Id == id).SingleOrDefault();
            return View(category);
        }
        public IActionResult UpdateCategory(Category cate)
        {
            Category category = ctx.Categories.Where(x => x.Id == cate.Id).SingleOrDefault();
            if (category != null)
            {
                category.Carbrand = cate.Carbrand;
            }
            ctx.SaveChanges();
            return RedirectToAction("viewcategory");
        }
    }
}
