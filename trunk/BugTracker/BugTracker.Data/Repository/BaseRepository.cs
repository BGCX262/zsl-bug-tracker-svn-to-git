using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BugTracker.Data;
using BugTracker.Data.Repository;
using System.Configuration;

namespace BugTracker.Data.Repository
{
    public abstract class BaseRepository
    {
        public BaseRepository() { }
        protected BugTrackerEntities Context
        {
            get
            {
                return new BugTrackerEntities(ConfigurationManager.ConnectionStrings["BugTrackerEntities"].ConnectionString);
            }
        }
    }
}
