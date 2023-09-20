using System.Runtime.Serialization;

namespace ParameterizedFactory
{
    [Serializable]
    internal class InvalidParserTypeException : Exception
    {
        public InvalidParserTypeException()
        {
        }

        public InvalidParserTypeException(string? message) : base(message)
        {
        }

        public InvalidParserTypeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidParserTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}