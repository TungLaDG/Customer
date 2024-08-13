using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Models
{
    [Table("Cate")]
    public class Cate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Name", TypeName = "varchar(30)")]
        public string Name { get; set; }

    }
}