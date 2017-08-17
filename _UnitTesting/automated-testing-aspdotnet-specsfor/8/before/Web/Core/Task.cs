using System;

namespace Web.Core
{
	public class Task
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string AssignTo { get; set; }
	}
}