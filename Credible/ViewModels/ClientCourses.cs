using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Credible.ViewModels
{
    public class ClientCourses
    {
    [Key]
        public int CoursePortalID { get; set; }
        public string CourseName { get; set; }
    }
}