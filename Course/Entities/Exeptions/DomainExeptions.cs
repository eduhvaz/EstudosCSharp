using System;
namespace Course.Entities.Exception
{
	public class DomainException : ApplicationException
	{
		 
		public DomainException(string message) : base(message)
		{
		}
	}
}

