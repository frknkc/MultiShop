using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;
using MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;

namespace MultiShop.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly GetOrderDetailQueryHandler _getOrderDetailQueryHandler;
        private readonly GetOrderDetailByIdQueryHandler _getOrderDetailByIdQueryHandler;
        private readonly CreateOrderDetailQueryHandler _createOrderDetailQueryHandler;
        private readonly UpdateOrderDetailQueryHandler _updateOrderDetailQueryHandler;
        private readonly RemoveOrderDetailQueryHandler _RemoveOrderDetailQueryHandler;


        public OrderDetailsController(GetOrderDetailQueryHandler getOrderDetailQueryHandler, GetOrderDetailByIdQueryHandler getOrderDetailByIdQueryHandler, CreateOrderDetailQueryHandler createOrderDetailQueryHandler, UpdateOrderDetailQueryHandler updateOrderDetailQueryHandler, RemoveOrderDetailQueryHandler removeOrderDetailQueryHandler)
        {
            _getOrderDetailQueryHandler = getOrderDetailQueryHandler;
            _getOrderDetailByIdQueryHandler = getOrderDetailByIdQueryHandler;
            _createOrderDetailQueryHandler = createOrderDetailQueryHandler;
            _updateOrderDetailQueryHandler = updateOrderDetailQueryHandler;
            _RemoveOrderDetailQueryHandler = removeOrderDetailQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> OrderDetailList()
        {
            var result = await _getOrderDetailQueryHandler.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetailById(int id)
        {
            var result = await _getOrderDetailByIdQueryHandler.Handle(new GetOrderDetailQueryById(id) );
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommand command)
        {
            await _createOrderDetailQueryHandler.Handle(command);
            return Ok("Order Detail created successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail(UpdateOrderDetailCommand command)
        {
            await _updateOrderDetailQueryHandler.Handle(command);
            return Ok("Order Detail updated successfully");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveOrderDetail(int id)
        {
            await _RemoveOrderDetailQueryHandler.Handle(new RemoveOrderDetailCommand(id));
            return Ok("Order Detail removed successfully");
        }
    }
}
