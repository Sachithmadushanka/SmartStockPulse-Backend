using Microsoft.AspNetCore.Mvc;
using SmartStockPulse.Application.Services;
using SmartStockPulse.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartStockPulse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly IStockService _service;
        public StockController(IStockService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stock>>> GetStocks()
        {
            var stocks = await _service.GetAllStocksAsync();
            return Ok(stocks);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStock(int id)
        {
            var stock = await _service.GetStockByIdAsync(id);
            if (stock == null)
                return NotFound();
            return Ok(stock);
        }
        [HttpPost]
        public async Task<ActionResult<Stock>> AddStock(Stock stock)
        {
            await _service.AddStockAsync(stock);
            return CreatedAtAction(nameof(GetStock), new { id = stock.Id }, stock);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStock(int id, Stock stock)
        {
            var updated = await _service.UpdateStockAsync(id, stock);
            if (!updated) return NotFound();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id)
        {
            var deleted = await _service.DeleteStockAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
    

}