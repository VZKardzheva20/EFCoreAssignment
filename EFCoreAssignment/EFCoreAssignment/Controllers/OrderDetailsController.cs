using Microsoft.AspNetCore.Mvc;

namespace EFCoreAssignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public IActionResult GetOrderDetails()
        {
            return Ok(_orderDetailService.GetAllOrderDetails());
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderDetail(int id)
        {
            return Ok(_orderDetailService.GetOrderDetailById(id));
        }

        [HttpPost]
        public IActionResult AddOrderDetail([FromBody] OrderDetailDto orderDetail)
        {
            _orderDetailService.AddOrderDetail(orderDetail);
            return Created("", orderDetail);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrderDetail(int id, [FromBody] OrderDetailDto orderDetail)
        {
            _orderDetailService.UpdateOrderDetail(id, orderDetail);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderDetail(int id)
        {
            _orderDetailService.DeleteOrderDetail(id);
            return NoContent();
        }
    }

}
