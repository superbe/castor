using Castor.Core;
using Castor.Data;
using Castor.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Castor.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BaseController : ControllerBase
	{
		protected readonly IBusinessController _business_controller;
		protected readonly DataContext _context;
		public BaseController(DataContext context)
		{
			_context = context;
			_business_controller = new BusinessController(_context);
		}
	}
}
