using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Models
{
    [Table("Car")]
    public class Cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name", TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column("Price", TypeName = "numeric(18,0)")]
        public float Price { get; set; }
        [Column("CategoryId")]
        public int CategoryId { get; set; }
        [Column("ImageUrl", TypeName = "varchar(255)")]
        public string ImageUrl { get; set; }
        [Column("Description", TypeName = "varchar(255")]
        public string Description { get; set; }
    }
}