using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
	public class AddTaskForm
	{
		[Required]
		public string Title { get; set; }

		public string Description { get; set; }

		[Display(Name = "Assign To"), EmailAddress]
		public string AssignTo { get; set; }
	}
}