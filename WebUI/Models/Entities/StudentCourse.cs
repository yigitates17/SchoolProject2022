using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Models.Entities
{
    public class StudentCourse
    {
        [Key]
        public int studentID { get; set; }

        [Key]
        public int courseID { get; set; }

        [Key]
        public int semesterID { get; set; }
    }
}
