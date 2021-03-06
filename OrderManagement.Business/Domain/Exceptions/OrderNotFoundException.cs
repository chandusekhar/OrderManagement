using OrderManagement.Exceptions;

namespace OrderManagement.Business.Domain.Exceptions
{
    public class OrderNotFoundException : NotFoundException
    {
        public OrderNotFoundException() : base($"Order not found")
        {
        }
        public OrderNotFoundException(long orderId) : base($"Order not found with given id {orderId}")
        {
        }
    }
}