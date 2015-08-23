using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BugTracker.Data;
using CommonLibrary;
using BugTracker.Data.IRepository;

namespace BugTracker.Data.Repository
{
    public class UsersRepository : BaseRepository, IUsersRepository
    {
        public UsersRepository() : base() { }

        public void Create()
        {

        }

        public IEnumerable<tbl_Users> GetAllUsers()
        {
            try
            {
                return this.Context.tbl_Users.ToList();
            }
            catch (Exception ex)
            {
                Logs.WriteError(ex);
                return null;
            }
        }


        public IEnumerable<tbl_UserType> GetUserTypes()
        {
            try
            {
                return this.Context.tbl_UserType.ToList();
            }
            catch (Exception ex)
            {
                Logs.WriteError(ex);
                return null;
            }
        }
    }
}
