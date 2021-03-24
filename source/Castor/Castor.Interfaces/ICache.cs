﻿using System;
using System.Collections.Generic;

namespace Castor.Interfaces
{
	public interface ICache
	{
		object Get(string cache_key);
		List<string> GetCacheKeys();
		void Set(string cache_key, object cache_object);
		void Set(string cache_key, object cache_object, DateTime expiration);
		void Set(string cache_key, object cache_object, TimeSpan expiration);
		void Delete(string cache_key);
		bool Exists(string cache_key);
		void Flush();
	}
}
