using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BugTracker.Model
{
    public class Project
    {
        [Key]
        [ScaffoldColumn(false)]
        public Guid ProjectID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name="Project Name")]
        [Required(ErrorMessage="Required.")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Project Logo")]
        public byte[] Logo { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Project Type")]
        [Required(ErrorMessage="Required.")]
        public string ApplicationType { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string Desciption { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
    }
}
