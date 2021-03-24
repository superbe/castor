using System;

namespace Castor.Interfaces
{
	public interface IConfiguration
	{
		object GetConfigurationSetting(Type expectedType, string key);
	}
}