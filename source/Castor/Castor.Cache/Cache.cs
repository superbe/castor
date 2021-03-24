using Castor.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Castor.Cache
{
	[Export(typeof(ICache))]
    public class Cache : ICache
    {
        private static IMemoryCache cache;
        private static TimeSpan timeSpan;
        //private static TimeSpan timeSpan = new TimeSpan(
        //    Settings.Default.DefaultCacheDuration_Days,
        //    Settings.Default.DefaultCacheDuration_Hours,
        //    Settings.Default.DefaultCacheDuration_Minutes, 0);

        private static MemoryCacheEntryOptions cacheExpiryOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpiration = DateTime.Now.AddMinutes(5),
            Priority = CacheItemPriority.High,
            SlidingExpiration = TimeSpan.FromMinutes(2)
        };

        static Cache()
        {
            //cache = HttpContext.Current.Cache;
            cache = new MemoryCache(new MemoryCacheOptions());
        }

        public object Get(string cache_key)
        {
            return cache.Get(cache_key);
        }

        public List<string> GetCacheKeys()
        {
            List<string> keys = new List<string>();
            //IDictionaryEnumerator ca = cache.GetEnumerator();
            //while (ca.MoveNext())
            //{
            //    keys.Add(ca.Key.ToString());
            //}
            return keys;
        }

        public void Set(string cache_key, object cache_object)
        {
            Set(cache_key, cache_object, timeSpan);
        }

        public void Set(string cache_key, object cache_object, DateTime expiration)
        {
            Set(cache_key, cache_object, expiration, CacheItemPriority.Normal);
        }

        public void Set(string cache_key, object cache_object, TimeSpan expiration)
        {
            Set(cache_key, cache_object, expiration, CacheItemPriority.Normal);
        }

        public void Set(string cache_key, object cache_object, DateTime expiration, CacheItemPriority priority)
        {
            cache.Set(cache_key, cache_object, cacheExpiryOptions);
        }

        public void Set(string cache_key, object cache_object, TimeSpan expiration, CacheItemPriority priority)
        {
            cache.Set(cache_key, cache_object, cacheExpiryOptions);
        }

        public void Delete(string cache_key)
        {
            if (Exists(cache_key))
                cache.Remove(cache_key);
        }

        public bool Exists(string cache_key)
        {
            if (cache.Get(cache_key) != null)
                return true;
            else
                return false;
        }

        public void Flush()
        {
            foreach (string s in GetCacheKeys())
            {
                Delete(s);
            }
        }
    }
}
