using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models
{
    public class UploadFile
    {
        [Key]
        public int Id { get; set; }

        public virtual Book Book { get; set; }

        [Required]
        [ForeignKey(nameof(Models.Book))]
        public int BookId { get; set; }
    }
}