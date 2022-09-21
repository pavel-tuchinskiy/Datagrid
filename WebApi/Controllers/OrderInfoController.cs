using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderInfoController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderInfoController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<ReturnHttpResult> Get([FromQuery] OrderRequestParameters orderParams)
        {
            var parametersDTO = new RequestParametersDTO()
            {
                DataRange = orderParams.DataRange,
                Filter = FilterParser<OrderInfoFilter>.ParseFilter(orderParams.OrderInfoFilter),
                GlobalSearchTerm = orderParams.GlobalSearchTerm,
                OrderBy = orderParams.OrderBy,
                PageNumber = orderParams.PageNumber,
                PageSize = orderParams.PageSize
            };

            var orderInfo = await _orderRepository.GetAll(parametersDTO);

            return new ReturnHttpResult(200, orderInfo);
        }

        [HttpPost]
        public async Task<ReturnHttpResult> Post(OrderInfoPostDTO orderInfo)
        {
            await _orderRepository.Add(orderInfo);

            return new ReturnHttpResult(201);
        }

        [HttpPut("{id}")]
        public async Task<ReturnHttpResult> Put(Guid id, [FromBody]OrderInfoUpdateDTO orderInfo)
        {
            await _orderRepository.Update(id, orderInfo);
            return new ReturnHttpResult(200);
        }

        [HttpDelete("{id}")]
        public async Task<ReturnHttpResult> Delete(Guid id)
        {
            await _orderRepository.Remove(id);

            return new ReturnHttpResult(200);
        }
    }
}
