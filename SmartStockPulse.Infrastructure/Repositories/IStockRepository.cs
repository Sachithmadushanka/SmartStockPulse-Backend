using SmartStockPulse.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartStockPulse.Infrastructure.Repositories
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetAllStocksAsync();
        Task<Stock?> GetStockByIdAsync(int id);
        Task AddStockAsync (Stock stock);
        Task<bool> UpdateStockAsync(int id, Stock stock);
        Task<bool> DeleteStockAsync(int id);
    }
}