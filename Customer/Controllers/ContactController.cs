using Microsoft.AspNetCore.Mvc;
using Customer.Models;

namespace Customer.Controllers
{
    public class ContactController : Controller
    {
        carmanagContext ctx = new carmanagContext();

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            Notification notifi = new Notification();
            notifi.Name = contact.Name;
            notifi.Type = "yêu cầu";
            notifi.Status = true;
            ctx.Notifications.Add(notifi);
            ctx.Contacts.Add(contact);
            ctx.SaveChanges();
            return View();
        }
    }
}
