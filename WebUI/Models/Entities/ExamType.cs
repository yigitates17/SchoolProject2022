using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Models.Entities
{
    public class ExamType
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
