using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class modificacionesnuevas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_PedidoId",
                table: "DetallePedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_PedidoId",
                table: "DetallePedido",
                column: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_PedidoId",
                table: "DetallePedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_PedidoId",
                table: "DetallePedido",
                column: "PedidoId",
                unique: true);
        }
    }
}
