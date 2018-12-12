using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication20.Models;

namespace WebApplication20
{
    public class Authorbook
    {
        [Key]
        public int author_book_id { get; set; }

        public int authorid { get; set; }
        public Author author_author { get; set; }

        public int bookid { get; set; }
        public Book book_book { get; set;}
         
    }
}
