namespace Entidades01
{
    public class UnaException : Exception
    {
        public UnaException() :base() 
        {
        
        }
        public UnaException(string? message) : base(message)
        {
        }

        public UnaException(string? message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
