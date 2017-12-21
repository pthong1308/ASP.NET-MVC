using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace BookShop.Models
{
    public class Book
    {
        public Book()
        {
            UploadFiles = new List<UploadFile>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Author { get; set; }

        [StringLength(100)]
        [Required]
        public string Title { get; set; }

        [Required]
        [Range(0d, double.MaxValue)]
        public decimal Price { get; set; }

        public List<OrderLine> OrderLines { get; set; }

        public virtual List<UploadFile> UploadFiles { get; set; }
    }
}