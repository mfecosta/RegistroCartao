using Pagamento_Angular.Models;

namespace Pagamento_Angular.BusinessLogic
{
    public interface IPagamentoDetail
    {
        Task<IEnumerable<PagamentoDetail>> GetAllAsync();
        Task<PagamentoDetail> GetByIdAsync(int id);
        Task<PagamentoDetail> AddAsync(PagamentoDetail pagamentoDetail);
        Task<bool> UpdateAsync(int id, PagamentoDetail pagamentoDetail);
        Task<bool> DeleteAsync(int id);
        bool Exists(int id);
    }
}
