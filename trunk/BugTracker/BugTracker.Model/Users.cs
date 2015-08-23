using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace BugTracker.Model
{
    public class Users
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid UserID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Username required.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Min: 5, Max: 30 characters")]
        [Remote("IsUsername_Available", "Users", AdditionalFields = "Email", HttpMethod="Post", ErrorMessage = "Username already exists.")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Min: 5, Max: 30 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email.")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email.")]
        [Remote("IsEmail_Available", "Users", AdditionalFields = "Username", HttpMethod = "Post", ErrorMessage = "Username already exists.")]
        public string Email { get; set; }

        public Guid UserTypeID { get; set; }
        public bool IsZsl { get; set; }
        public bool IsActive { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }
    }
}