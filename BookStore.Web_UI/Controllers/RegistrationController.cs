using System.Linq;
using System.Web.Mvc;
using BookStore.Domain.Entities;
using BookStore.Domain.Abstract;
using BookStore.Domain.Concrete;
using BookStore.WebUI.Models;

namespace BookStore.WebUI.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {

            return View();

        }

        public ActionResult Registration()
        {

            return View();

        }

        [HttpPost]

        public JsonResult RegisterUser(User model)
        {

            EFDbContext db = new EFDbContext();


            User user = new User();

            user.UserName = model.UserName;

            user.EmailId = model.EmailId;

            user.Password = model.Password;

            user.RoleId = 3;

            db.Users.Add(user);

            db.SaveChanges();


            return Json("Success", JsonRequestBehavior.AllowGet);

        }

    }
}