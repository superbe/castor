using System;

namespace Castor.Interfaces
{
	public interface IUser
	{
		int ID { get; set; }
		string LastName { get; set; }
		string FirstMidName { get; set; }
	}
}