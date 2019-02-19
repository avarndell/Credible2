using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Credible.ViewModels
{
    public class Registrants
    {
        public int RegistrationId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public  DateTime RegistrationDate { get; set; }
    }
}