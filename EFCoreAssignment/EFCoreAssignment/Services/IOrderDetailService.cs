using EFCoreAssignment.DTOs;
using EFCoreAssignment.Models;

namespace EFCoreAssignment.Services
{
    public interface IOrderDetailService
    {
        IEnumerable<OrderDetail> GetAllOrderDetails();
        OrderDetail GetOrderDetailById(int id);
        void AddOrderDetail(OrderDetailDto orderDetail);
        void UpdateOrderDetail(int id, OrderDetailDto orderDetail);
        void DeleteOrderDetail(int id);
    }
}
