using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication20.Models;

namespace WebApplication20.Models
{
    public class Author
    {
        public int id { get; set; }
        public int phone { get; set; }

        [Required(ErrorMessage = "you must enter your name")]
        public string name { get; set; }
        public ICollection<Authorbook> Booklist { get; set; }
    }
}
