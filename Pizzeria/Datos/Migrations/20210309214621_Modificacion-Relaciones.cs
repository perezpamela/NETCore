using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class ModificacionRelaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Factura_FacturaId",
                table: "DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_Factura_PedidoId",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_FacturaId",
                table: "DetallePedido");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "DetallePedido");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_PedidoId",
                table: "Factura",
                column: "PedidoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Factura_PedidoId",
                table: "Factura");

            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "DetallePedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Factura_PedidoId",
                table: "Factura",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_FacturaId",
                table: "DetallePedido",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Factura_FacturaId",
                table: "DetallePedido",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
