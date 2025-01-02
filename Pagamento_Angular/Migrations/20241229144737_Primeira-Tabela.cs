using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pagamento_Angular.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PagamentoDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCartao = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NumeroCartao = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    DataExpiracao = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    CodigoSeguranca = table.Column<string>(type: "nvarchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PagamentoDetails");
        }
    }
}
