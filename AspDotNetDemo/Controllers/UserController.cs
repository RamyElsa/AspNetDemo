using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspDotNetDemoData;
using AspDotNetDemoCore;

namespace AspDotNetDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly IDataHelper<User> datahelper;
        private User user;
        public UserController(IDataHelper<User>datahelper) 
        {
            this.datahelper = datahelper;
        }


        // GET: UserController
        public ActionResult Index()
        {
            return View(datahelper.GetData());
        }


        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            user = datahelper.Find(id);
            return View(user);
        }


        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User collection)
        {
            try
            {
                datahelper.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                datahelper.Edit(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            user= datahelper.Find(id);
            return View(user);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                datahelper.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
