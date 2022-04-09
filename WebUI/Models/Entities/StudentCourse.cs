using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Models.Entities
{
    public class StudentCourse
    {

        [Key]
        public int id { get; set; }
        public int studentID { get; set; }
        public int courseID { get; set; }
        public int semesterID { get; set; }
    }
}
