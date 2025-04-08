using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        public string Description { get; set; }
        [Range(0, int.MaxValue,ErrorMessage ="Stock Must Be Positive")]
        public int  Stock { get; set; }
    }
}
