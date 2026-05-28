using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebCoffee.BackendServer.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Lập trình C# cơ bản", Author = "Nguyễn Văn A", Price = 150000 },
                new Book { Id = 2, Title = "Cấu trúc dữ liệu và giải thuật", Author = "Trần Thị B", Price = 180000 },
                new Book { Id = 3, Title = "Thiết kế Web với Angular", Author = "Phạm Minh C", Price = 220000 }
            );
        }
    }
}