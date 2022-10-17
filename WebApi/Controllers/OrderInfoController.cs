using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderInfoController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderInfoController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("GetAll")]
        public async Task<ReturnHttpResult> GetAll([FromBody] FilterParameters filterParameters, [FromQuery] RequestParameters orderParams)
        {
            var parametersDTO = new OrderInfoRequestParametersDTO
            {
                DataRanges = filterParameters.DataRanges,
                Filters = filterParameters.Filters,
                GlobalSearchTerm = orderParams.GlobalSearchTerm,
                OrderBy = orderParams.OrderBy,
                PageNumber = orderParams.PageNumber,
                PageSize = orderParams.PageSize
            };

            var orderInfo = await _orderService.GetAll(parametersDTO);

            return new ReturnHttpResult(200, orderInfo);
        }

        [HttpPost]
        public async Task<ReturnHttpResult> Post(OrderInfoPostDTO orderInfo)
        {
            await _orderService.Add(orderInfo);

            return new ReturnHttpResult(201);
        }

        [HttpPut("{id}")]
        public async Task<ReturnHttpResult> Put(Guid id, [FromBody]OrderInfoUpdateDTO orderInfo)
        {
            await _orderService.Update(id, orderInfo);
            return new ReturnHttpResult(200);
        }

        [HttpDelete("{id}")]
        public async Task<ReturnHttpResult> Delete(Guid id)
        {
            await _orderService.Remove(id);

            return new ReturnHttpResult(200);
        }
    }
}
