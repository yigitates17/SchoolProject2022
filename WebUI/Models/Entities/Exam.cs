using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Models.Entities
{
    public class Exam
    {
		[Key]
		public int id { get; set; }

		[ForeignKey("courseID")]
		public int courseID { get; set; }

		[Required]
		public DateTime examDate { get; set; }

		[Required]
		public int Duration { get; set; }

		[ForeignKey("examTypeID")]
		public int examTypeID { get; set; }

		[ForeignKey("semesterID")]
		public int semesterID { get; set; }

	}
}
