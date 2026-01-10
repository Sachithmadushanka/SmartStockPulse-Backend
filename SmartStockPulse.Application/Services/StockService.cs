using SmartStockPulse.Domain.Entities;
using SmartStockPulse.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartStockPulse.Application.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _repository;
        public StockService(IStockRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Stock>> GetAllStocksAsync() => _repository.GetAllStocksAsync();
        public Task<Stock?> GetStockByIdAsync(int id) => _repository.GetStockByIdAsync(id);
        public Task AddStockAsync(Stock stock) => _repository.AddStockAsync(stock);
        public Task<bool> UpdateStockAsync(int id, Stock stock) => _repository.UpdateStockAsync(id, stock);

        public Task<bool> DeleteStockAsync(int id) => _repository.DeleteStockAsync(id);
    }
}
