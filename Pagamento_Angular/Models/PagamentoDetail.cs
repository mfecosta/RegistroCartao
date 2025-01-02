using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pagamento_Angular.Models
{
    public class PagamentoDetail
    {   
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NomeCartao { get; set; } = "";
        [Column(TypeName = "nvarchar(16)")]
        public string NumeroCartao { get; set; } = "";
        [Column(TypeName = "nvarchar(6)")]
        public string DataExpiracao { get; set; } = "";
        [Column(TypeName = "nvarchar(3)")]
        public string CodigoSeguranca { get; set; } = "";
    }
}
