﻿using System;
namespace Web.Site.Controllers.Models
{
	public class SignalInputModel
	{

public string Occupation { get; set; }
		public string Description { get; set; }
	
		public string CustomerName { get; set; }

		public string AccessCode { get; set; }
		public string Area { get; set; }

		public string Zone { get; set; }
			
		public SignalInputModel()
		{
		}
	}
}
