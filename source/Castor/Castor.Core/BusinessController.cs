using Castor.Data;
using Castor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Castor.Core
{
	public class BusinessController : IBusinessController
	{
		private readonly DataContext _context;
		public BusinessController(DataContext context)
		{
			_context = context;
		}

		public IUser[] GetUsers()
		{
			return _context.Users.ToArray();
		}
	}
}
