﻿using HelloWorld.Web.App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Web.App.Controllers
{
	public class RateController : Controller
	{
		private readonly ILogger<RateController> _logger;


		public RateController(ILogger<RateController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
