using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class Actualizacion_Modelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaEntrega",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "montoTotal",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "fechaPedido",
                table: "Pedido",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "demoraAprox",
                table: "Pedido",
                newName: "demora");

            migrationBuilder.RenameColumn(
                name: "estadoDetalle",
                table: "DetallePedido",
                newName: "tipo");

            migrationBuilder.AddColumn<int>(
                name: "cantidadad",
                table: "DetallePedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "size",
                table: "DetallePedido",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidadad",
                table: "DetallePedido");

            migrationBuilder.DropColumn(
                name: "size",
                table: "DetallePedido");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Pedido",
                newName: "fechaPedido");

            migrationBuilder.RenameColumn(
                name: "demora",
                table: "Pedido",
                newName: "demoraAprox");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "DetallePedido",
                newName: "estadoDetalle");

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaEntrega",
                table: "Pedido",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "montoTotal",
                table: "Pedido",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
