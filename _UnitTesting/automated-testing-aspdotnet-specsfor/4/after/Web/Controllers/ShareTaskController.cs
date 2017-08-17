﻿﻿using System;
using System.Web.Mvc;
using Web.Data;
using Web.Social;

namespace Web.Controllers
{
	public class ShareTaskController : Controller
	{
		private readonly ISocialService _socialService;
		private readonly ITaskRepository _tasks;

		public ShareTaskController(ISocialService socialService, ITaskRepository tasks)
		{
			_socialService = socialService;
			_tasks = tasks;
		}

		public ActionResult ShareTask(Guid id)
		{
			var task = _tasks.FindById(id);
			_socialService.ShareStatus("Check out my task! " + task.Title);

			return View();
		}
	}
}