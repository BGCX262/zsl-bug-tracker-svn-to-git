using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BugTracker.Model
{
    public class BugDiscussions
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid CommentID { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Required.")]
        public string Comment { get; set; }

        [DataType(DataType.DateTime)]
        public string CommentDate { get; set; }
    }
}
