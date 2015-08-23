using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;

namespace CommonLibrary
{   
    public class UserAuthentication
    {
        public bool validate(string username,string password)
        {
            // Production url
            // DirectoryEntry entry = new DirectoryEntry("LDAP://mail.zsl.local",username,password);
            DirectoryEntry entry = new DirectoryEntry("LDAP://dc02.zsl.local", username, password);
            DirectorySearcher searcher = new DirectorySearcher(entry);
            searcher.Filter = "(SAMAccountName=" + username + ")";
            searcher.PropertiesToLoad.Add("mail");
            searcher.PropertiesToLoad.Add("displayname");            
            searcher.PropertiesToLoad.Add("title");            
            searcher.PropertiesToLoad.Add("company");
            searcher.PropertiesToLoad.Add("department");
            ResultPropertyCollection coll = searcher.FindOne().Properties;
            return coll != null ? true : false;
        }
    }
}