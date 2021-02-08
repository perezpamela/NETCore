using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    demoraAprox = table.Column<int>(type: "int", nullable: false),
                    montoTotal = table.Column<float>(type: "real", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    variedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precioPorcion = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pedidoid = table.Column<int>(type: "int", nullable: true),
                    formaDePago = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.id);
                    table.ForeignKey(
                        name: "FK_Factura_Pedido_pedidoid",
                        column: x => x.pedidoid,
                        principalTable: "Pedido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pedidoid = table.Column<int>(type: "int", nullable: true),
                    pizzaid = table.Column<int>(type: "int", nullable: true),
                    estadoDetalle = table.Column<int>(type: "int", nullable: false),
                    subTotal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Pedido_pedidoid",
                        column: x => x.pedidoid,
                        principalTable: "Pedido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Pizza_pizzaid",
                        column: x => x.pizzaid,
                        principalTable: "Pizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IngredientePizza",
                columns: table => new
                {
                    ingredientesid = table.Column<int>(type: "int", nullable: false),
                    pizzasid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientePizza", x => new { x.ingredientesid, x.pizzasid });
                    table.ForeignKey(
                        name: "FK_IngredientePizza_Ingrediente_ingredientesid",
                        column: x => x.ingredientesid,
                        principalTable: "Ingrediente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientePizza_Pizza_pizzasid",
                        column: x => x.pizzasid,
                        principalTable: "Pizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_pedidoid",
                table: "DetallePedido",
                column: "pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_pizzaid",
                table: "DetallePedido",
                column: "pizzaid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_pedidoid",
                table: "Factura",
                column: "pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientePizza_pizzasid",
                table: "IngredientePizza",
                column: "pizzasid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePedido");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "IngredientePizza");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Ingrediente");

            migrationBuilder.DropTable(
                name: "Pizza");
        }
    }
}
