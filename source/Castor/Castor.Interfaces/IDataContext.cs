using Microsoft.EntityFrameworkCore;

namespace Castor.Interfaces
{
	public interface IDataContext
	{
		DbSet<IUser> Users { get; set; }
	}
}
