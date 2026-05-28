using System.ComponentModel.DataAnnotations;

namespace WebCoffee.BackendServer.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        [StringLength(250)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Tác giả không được để trống")]
        [StringLength(150)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Giá sách không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá sách phải lớn hơn 0")]
        public decimal Price { get; set; }
    }
}