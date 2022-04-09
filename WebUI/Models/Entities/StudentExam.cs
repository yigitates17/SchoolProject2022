using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Models.Entities
{
    public class StudentExam
    {

        [Key]
        public int id { get; set; }
        public int studentID { get; set; }
        public int examID { get; set; }
        public double grade { get; set; }
    }
}
