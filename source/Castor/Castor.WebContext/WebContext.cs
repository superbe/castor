using Castor.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Castor.WebContext
{
	[Export(typeof(IWebContext))]
	public class WebContext : IWebContext
	{
		//public void ClearSession()
		//{
		//    HttpContext.Current.Session.Clear();
		//}

		//public bool ContainsInSession(string key)
		//{
		//    return HttpContext.Current.Session[key] != null;
		//}

		//public void RemoveFromSession(string key)
		//{
		//    HttpContext.Current.Session.Remove(key);
		//}

		//private string GetQueryStringValue(string key)
		//{
		//    return HttpContext.Current.Request.QueryString.Get(key);
		//}

		//private void SetInSession(string key, object value)
		//{
		//    if (HttpContext.Current == null || HttpContext.Current.Session == null)
		//    {
		//        return;
		//    }
		//    HttpContext.Current.Session[key] = value;
		//}

		//private object GetFromSession(string key)
		//{
		//    if (HttpContext.Current == null || HttpContext.Current.Session == null)
		//    {
		//        return null;
		//    }
		//    return HttpContext.Current.Session[key];
		//}

		//private void UpdateInSession(string key, object value)
		//{
		//    HttpContext.Current.Session[key] = value;
		//}
		public void ClearSession()
		{
			throw new System.NotImplementedException();
		}

		public bool ContainsInSession(string key)
		{
			throw new System.NotImplementedException();
		}

		public void RemoveFromSession(string key)
		{
			throw new System.NotImplementedException();
		}
	}
}
