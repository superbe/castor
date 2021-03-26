using Castor.Data;
using Castor.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Castor.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : BaseController
	{
		public UsersController(DataContext context): base(context)
		{

		}

		// GET: api/<UsersController>
		[HttpGet]
		public IEnumerable<IUser> Get()
		{
			return _business_controller.GetUsers();
		}

		// GET api/<UsersController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<UsersController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<UsersController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<UsersController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
