using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CommonLibrary;
using BugTracker.Model;
using BugTracker.Data;
using BugTracker.Data.Repository;


namespace BugTracker.Domain.Handlers
{
    public class UsersHandler
    {
        private UsersRepository _repository = new UsersRepository();

        public IEnumerable<BugTracker.Model.Users> GetAllUsers()
        {
            try
            {
                DateTime NOW = DateTime.UtcNow;
                var users = _repository.GetAllUsers().Select(m => new BugTracker.Model.Users()
                {
                    CreationDate= NOW,
                    Email = m.Email,
                    IsActive = m.IsActive,
                    IsZsl = m.IsZsl,
                    ModifiedDate = NOW,
                    Password = m.Password,
                    UserID= Guid.NewGuid(),
                    Username = m.Username,
                    UserTypeID = m.UserTypeID.GetValueOrDefault()
                });
                return users;
            }
            catch (Exception ex)
            {
                Logs.WriteError(ex);
                return null;
            }
        }

        public Dictionary<string,string> GetUserTypes()
        {
            try
            {
                Dictionary<string, string> types = new Dictionary<string, string>();
                foreach(var item in _repository.GetUserTypes())
                {
                    types.Add(item.UserTypeID.ToString(), item.TypeName);
                }
                return types;
            }
            catch (Exception ex)
            {
                Logs.WriteError(ex);
                return null;
            }
        }
    }
}
