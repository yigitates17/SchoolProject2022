using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Models.Entities
{
    public class Course
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("lecturerID")]
        public int lecturerID { get; set; }

        [Required]
        public string name { get; set; }

        [ForeignKey("semesterID")]
        public int semesterID { get; set; }

        [ForeignKey("departmentID")]
        public int departmentID { get; set; }

    }
}
