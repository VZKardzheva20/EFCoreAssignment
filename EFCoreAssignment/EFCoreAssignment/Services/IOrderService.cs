using EFCoreAssignment.DTOs;
using EFCoreAssignment.Models;

namespace EFCoreAssignment.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        void AddOrder(OrderDto order);
        void UpdateOrder(int id, OrderDto order);
        void DeleteOrder(int id);
    }
}
