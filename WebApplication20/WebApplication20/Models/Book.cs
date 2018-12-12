using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication20.Models
{
    public class Book
    {
        [Required(ErrorMessage ="you must enter your relase date")]
        [Display(Name ="relase date")]
        [DataType("Datatype.Date")]
        [DisplayFormat(DataFormatString ="{ddd:yyy-mm}",ApplyFormatInEditMode =true)]
        public DateTime relasedate { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName= "decimal(9,4)")]
        public decimal price { get; set; }
        public string type { get; set; }
        public int id { get; set; }
        public int publisher_onepublisher_one { get; set; }
        public ICollection<Bookuser> userlist { get; set; }
        public ICollection<Author>authorlist { get; set; }

    }
}
