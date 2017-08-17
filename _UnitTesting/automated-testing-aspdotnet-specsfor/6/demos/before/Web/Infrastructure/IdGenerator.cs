using System;

namespace Web.Infrastructure
{
	public interface IIdGenerator
	{
		Guid GetNewId();
	}

	public class IdGenerator : IIdGenerator
	{
		public Guid GetNewId()
		{
			return Guid.NewGuid();
		}
	}
}