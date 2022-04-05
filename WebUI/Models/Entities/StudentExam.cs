using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Models.Entities
{
    public class StudentExam
    {
        [Key]
        public int studentID { get; set; }

        [Key]
        public int examID { get; set; }
        public double grade { get; set; }
    }
}
