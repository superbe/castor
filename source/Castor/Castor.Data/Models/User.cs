using Castor.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace Castor.Data.Models
{
	[Export(typeof(IUser))]
	public class User : IUser
	{
		public int ID { get; set; }
		public string LastName { get; set; }
		public string FirstMidName { get; set; }
	}
}
