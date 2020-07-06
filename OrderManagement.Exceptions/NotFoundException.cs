namespace OrderManagement.Exceptions
{
    public abstract class NotFoundException : BaseException
    {
        protected NotFoundException(string message) : base(message)
        {
        }
    }
}