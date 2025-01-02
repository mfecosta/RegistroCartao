using Microsoft.EntityFrameworkCore;
using Pagamento_Angular.Database;
using Pagamento_Angular.Models;

namespace Pagamento_Angular.BusinessLogic
{
    public class PagamentoDetailBll: IPagamentoDetail
    {
        private readonly DatabaseContext _context;
        
        public PagamentoDetailBll(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PagamentoDetail>> GetAllAsync()
        {
            return await _context.PagamentoDetails.ToListAsync();
        }

        public async Task<PagamentoDetail> GetByIdAsync(int id)
        {
            return await _context.PagamentoDetails.FindAsync(id);
        }

        public async Task<PagamentoDetail> AddAsync(PagamentoDetail pagamentoDetail)
        {
            _context.PagamentoDetails.Add(pagamentoDetail);
            await _context.SaveChangesAsync();
            return pagamentoDetail;
        }

        public async Task<bool> UpdateAsync(int id, PagamentoDetail pagamentoDetail)
        {
            if (id != pagamentoDetail.Id) return false;

            _context.Entry(pagamentoDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exists(id)) return false;
                throw;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var pagamentoDetail = await _context.PagamentoDetails.FindAsync(id);
            if (pagamentoDetail == null) return false;

            _context.PagamentoDetails.Remove(pagamentoDetail);
            await _context.SaveChangesAsync();
            return true;
        }

        public bool Exists(int id)
        {
            return _context.PagamentoDetails.Any(e => e.Id == id);
        }
    }
}
