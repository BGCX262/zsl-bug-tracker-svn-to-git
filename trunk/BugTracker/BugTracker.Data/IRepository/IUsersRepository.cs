using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BugTracker.Data;

namespace BugTracker.Data.IRepository
{
    public interface IUsersRepository 
    {
        IEnumerable<tbl_Users> GetAllUsers();
        IEnumerable<tbl_UserType> GetUserTypes();
        void Create();
    }
}
