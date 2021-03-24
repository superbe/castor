using System;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.IO;

namespace Castor.Common
{
	public static class MEFManager
	{
		public static void Compose(ComposablePart o)
		{
			var container = new CompositionContainer(
			new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin")));

			var batch = new CompositionBatch();
			batch.AddPart(o);
			container.Compose(batch);
		}
	}
}
