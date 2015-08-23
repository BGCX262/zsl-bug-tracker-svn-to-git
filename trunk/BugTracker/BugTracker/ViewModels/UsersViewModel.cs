using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTracker.Model;

namespace BugTracker.ViewModels
{
    public class UsersViewModel
    {
        public Users Users { get; set; }
        public IEnumerable<SelectListItem> UserTypes { get; set; }
        public UsersViewModel() { }
        public UsersViewModel(Users User)
        {
            Users = User;
        }        
    }
}