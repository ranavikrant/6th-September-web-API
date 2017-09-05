using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebApplication4.LocalResouces;

namespace WebApplication4.Models
{
    public class User
    {
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        public string Name { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Resource))]
        public string Email { get; set; }
        [Display(Name = "Phone", ResourceType = typeof(Resource))]
        public string Phone { get; set; }
    }
}