using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication20.Models
{
    public class User
    {
       [Required(ErrorMessage ="you must enter your name")]
       [Display(Name ="user name")]     
        public string username { get; set; }

        [Required(ErrorMessage ="you must enter your email")]
        public string email { get; set; }

        [Required(ErrorMessage ="you must enter your password")]
        public string password { get; set; }

        public int phonenumber { get; set; }
        public int id { get; set; }
        public ICollection<Bookuser>Booklist { get; set; }

    }
}
