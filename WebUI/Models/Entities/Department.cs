using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Models.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        
    }
}
