using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTracker.ViewModels;
using BugTracker.Model;
using BugTracker.Domain.Handlers;

namespace BugTracker.Controllers
{
    public class UsersController : Controller
    {
        private UsersViewModel _ViewModel = new UsersViewModel();
        private UsersHandler _handler = new UsersHandler();

        public ActionResult Index()
        {
            var users = _handler.GetAllUsers().Select(m => new UsersViewModel(new Users()
            {
                Username=m.Username
            }));
            return View(users);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Create()
        {
            Initialize(ref _ViewModel);
            return View(_ViewModel);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection form, UsersViewModel _Model)
        {
            Initialize(ref _Model);
            //_Model.UserTypes.Where(m => m.Value.Equals(_Model.Users.UserTypeID)).SingleOrDefault(n => n.Selected = true);
            return View(_Model);
        }

        private void Initialize(ref UsersViewModel init)
        {
            //Bind UserTypes Dropdownlist
            init.UserTypes = _handler.GetUserTypes().Select(m => new SelectListItem()
            {
                Text = m.Value,
                Value = m.Key
            });
        }

        
        public JsonResult IsUsername_Available(string Username, string Email)
        {
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        
        public JsonResult IsEmail_Available(string Email, string Username)
        {
            return Json(false, JsonRequestBehavior.AllowGet);
        }

    }
}
