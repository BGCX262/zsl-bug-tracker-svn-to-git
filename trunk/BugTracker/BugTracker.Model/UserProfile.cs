using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BugTracker.Model
{
    public class UserProfile
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid UserID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name="Firstname")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }

        [Display(Name = "Display Name")]
        [DataType(DataType.Text)]
        public string DiplayName { get; set; }

        [Display(Name="Contact No.")]
        [DataType(DataType.PhoneNumber,ErrorMessage="Invalid Phone number.")]                
        public string Phone { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }
    }
}
