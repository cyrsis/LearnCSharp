using System;

namespace Web.Models
{
	public class TaskDetailsViewModel
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}