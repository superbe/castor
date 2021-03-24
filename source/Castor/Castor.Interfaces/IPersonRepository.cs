using System.Collections.Generic;

namespace Castor.Interfaces
{
	public interface IPersonRepository
	{
		List<string> GetAllNames();
	}
}