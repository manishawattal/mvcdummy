using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1
{
    public class Eligibile
    {
        [Required(ErrorMessage="please enter the name")]
        public string name { get; set; }
        [Required(ErrorMessage = "please enter the name")]
        public int age { get; set; }
        [Required(ErrorMessage="please specify your Age")]
        public bool iseligibile { get; set; }
    }
}