namespace P05_SwitchStatement.CommonLogic
{
	using System;
	using System.Runtime.Serialization;

	[Serializable]
	public class InvalidBirdTypeException : Exception
	{
		public InvalidBirdTypeException()
		{
		}

		public InvalidBirdTypeException(string message)
			: base(message)
		{
		}

		public InvalidBirdTypeException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected InvalidBirdTypeException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}