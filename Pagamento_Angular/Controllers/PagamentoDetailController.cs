using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pagamento_Angular.BusinessLogic;
using Pagamento_Angular.Database;
using Pagamento_Angular.Models;

namespace Pagamento_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoDetailController : ControllerBase
    {
        private readonly IPagamentoDetail _pagamentoDetail;

        public PagamentoDetailController(IPagamentoDetail pagamento)
        {
            _pagamentoDetail = pagamento;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PagamentoDetail>>> GetPagamentoDetails()
        {
            var pagamentos = await _pagamentoDetail.GetAllAsync();
            return Ok(pagamentos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PagamentoDetail>> GetPagamentoDetail(int id)
        {
            var pagamentoDetail = await _pagamentoDetail.GetByIdAsync(id);
            if (pagamentoDetail == null) return NotFound();

            return Ok(pagamentoDetail);
        }

        [HttpPost]
        public async Task<ActionResult<PagamentoDetail>> PostPagamentoDetail(PagamentoDetail pagamentoDetail)
        {
            var created = await _pagamentoDetail.AddAsync(pagamentoDetail);
            return Ok(await  _pagamentoDetail.GetAllAsync());//CreatedAtAction(nameof(GetPagamentoDetail), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPagamentoDetail(int id, PagamentoDetail pagamentoDetail)
        {
            var success = await _pagamentoDetail.UpdateAsync(id, pagamentoDetail);
            if (!success) return NotFound();

            //return NoContent();
            return Ok(await _pagamentoDetail.GetAllAsync());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePagamentoDetail(int id)
        {
            var success = await _pagamentoDetail.DeleteAsync(id);
            if (!success) return NotFound();

            //return NoContent();
            return Ok(await _pagamentoDetail.GetAllAsync());
        }
    }
}

