using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BugTracker.Model
{
    public class Bugs
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid BugID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Title of Bug")]
        public string Title { get; set; }
                
        public List<byte[]> ScreenShots { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [Required(ErrorMessage="Required.")]
        public string Description { get; set; }

        public int Status { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OpenDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ClosedDate { get; set; }

        public bool IsClosed { get; set; }
    }
}
