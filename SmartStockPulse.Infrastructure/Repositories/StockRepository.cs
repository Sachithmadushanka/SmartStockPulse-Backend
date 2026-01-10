using SmartStockPulse.Domain.Entities;
using SmartStockPulse.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SmartStockPulse.Infrastructure.Repositories
{
    public class StockRepository : IStockRepository
    {
        private static readonly List<Stock> _stocks = new()
        {
            new Stock { Id = 1, Symbol = "AAPL", CompanyName = "Apple", CurrentPrice = 175.5M, LastUpdated = System.DateTime.Now },
            new Stock { Id = 2, Symbol = "GOOGL", CompanyName = "Alphabet", CurrentPrice = 135.7M, LastUpdated = System.DateTime.Now }
        };

        public Task<IEnumerable<Stock>> GetAllStocksAsync() => Task.FromResult(_stocks.AsEnumerable());

        public Task<Stock?> GetStockByIdAsync(int id) => Task.FromResult(_stocks.FirstOrDefault(s => s.Id == id));

        public Task AddStockAsync(Stock stock)
        {
            stock.Id = _stocks.Any() ? _stocks.Max(s => s.Id) + 1 : 1;
            stock.LastUpdated = System.DateTime.Now;
            _stocks.Add(stock);
            return Task.CompletedTask;
        }

        public Task<bool> UpdateStockAsync(int id, Stock stock)
        {
            var existing = _stocks.FirstOrDefault(s => s.Id == id);
            if (existing == null) return Task.FromResult(false);

            existing.Symbol = stock.Symbol;
            existing.CompanyName = stock.CompanyName;
            existing.CurrentPrice = stock.CurrentPrice;
            existing.LastUpdated = System.DateTime.Now;
            return Task.FromResult(true);
        }

        public Task<bool> DeleteStockAsync(int id)
        {
            var stock = _stocks.FirstOrDefault(s => s.Id == id);
            if (stock == null) return Task.FromResult(false);

            _stocks.Remove(stock);
            return Task.FromResult(true);
        }
    }
}
