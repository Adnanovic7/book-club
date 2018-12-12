using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication20.Controllers;

namespace WebApplication20.Models
{
    public class Publisher
    {
        [Required(ErrorMessage = "you must enter your name")]
        public string name { get; set; }

        [Key]
        public int pid { get; set; }
        public List<Book> booklist { get; set; }
    }
}
