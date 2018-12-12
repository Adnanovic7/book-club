using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookclub.data
{
    public class mycontext : DbContext
    {
        //configuration constructor
        public mycontext(DbContextOptions<mycontext> options)
        : base(options)
        {
        }

        public DbSet<WebApplication20.Models.User> Users { get; set; }
        public DbSet<WebApplication20.Models.Book> books { get; set; }
        public DbSet<WebApplication20.Models.Author> Authors { get; set; }
        public DbSet<WebApplication20.Models.Publisher> Publishers { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<WebApplication20.Models.Bookuser>()
                .HasKey(en => new { en.bookid,en.userid  });

            modelBuilder.Entity<WebApplication20.Models.Bookuser>()
                .HasOne(en => en.user_user)
                .WithMany(b => b.Booklist)
                .HasForeignKey(en => en.userid);

            modelBuilder.Entity<WebApplication20.Models.Bookuser>()
                .HasOne(co => co.book_book)
                .WithMany(c => c.userlist)
                .HasForeignKey(en => en.bookid);



         



            
        }



    }
}
