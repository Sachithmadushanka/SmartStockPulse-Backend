using SmartStockPulse.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartStockPulse.Application.Services
{
    public interface IStockService
    {
        Task<IEnumerable<Stock>> GetAllStocksAsync();
        Task<Stock?> GetStockByIdAsync(int id);
        Task AddStockAsync(Stock stock);
        Task<bool> UpdateStockAsync(int id, Stock stock);
        Task<bool> DeleteStockAsync(int id);
    }
}
