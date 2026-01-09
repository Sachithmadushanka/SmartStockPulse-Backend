using SmartStockPulse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartStockPulse.Domain.Repositories;

namespace SmartStockPulse.Infrastructure.Repositories
{
    public class StockRepository : IStockRepository
    {
        private static readonly List<Stock> _stocks = new();

        public Task<IEnumerable<Stock>> GetAllAsync()
        {
            return Task.FromResult(_stocks.AsEnumerable());
        }

        public Task<Stock?> GetByIdAsync(int id)
        {
            var stock = _stocks.FirstOrDefault(s => s.Id == id);
            return Task.FromResult(stock);
        }

        public Task AddAsync(Stock stock)
        {
            stock.Id = _stocks.Count + 1;
            stock.LastUpdated = DateTime.UtcNow;
            _stocks.Add(stock);
            return Task.CompletedTask;
        }

        public Task<bool> UpdateAsync(int id, Stock stock)
        {
            var existing = _stocks.FirstOrDefault(s => s.Id == id);
            if (existing == null)
                return Task.FromResult(false);

            existing.Symbol = stock.Symbol;
            existing.CompanyName = stock.CompanyName;
            existing.CurrentPrice = stock.CurrentPrice;
            existing.LastUpdated = DateTime.UtcNow;

            return Task.FromResult(true);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var stock = _stocks.FirstOrDefault(s => s.Id == id);
            if (stock == null)
                return Task.FromResult(false);

            _stocks.Remove(stock);
            return Task.FromResult(true);
        }
    }
}
