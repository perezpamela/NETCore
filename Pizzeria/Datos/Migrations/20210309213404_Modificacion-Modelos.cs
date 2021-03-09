using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class ModificacionModelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Pedido_pedidoid",
                table: "DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Pizza_pizzaid",
                table: "DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Pedido_pedidoid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientePizza_Ingrediente_ingredientesid",
                table: "IngredientePizza");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientePizza_Pizza_pizzasid",
                table: "IngredientePizza");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_pedidoid",
                table: "DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_pizzaid",
                table: "DetallePedido");

            migrationBuilder.RenameColumn(
                name: "variedad",
                table: "Pizza",
                newName: "Variedad");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Pizza",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "precioPorcion",
                table: "Pizza",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Pedido",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Pedido",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "demora",
                table: "Pedido",
                newName: "Demora");

            migrationBuilder.RenameColumn(
                name: "clienteNombre",
                table: "Pedido",
                newName: "ClienteNombre");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Pedido",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "pizzasid",
                table: "IngredientePizza",
                newName: "PizzasId");

            migrationBuilder.RenameColumn(
                name: "ingredientesid",
                table: "IngredientePizza",
                newName: "IngredientesId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientePizza_pizzasid",
                table: "IngredientePizza",
                newName: "IX_IngredientePizza_PizzasId");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Ingrediente",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Ingrediente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "pedidoid",
                table: "Factura",
                newName: "PedidoId");

            migrationBuilder.RenameColumn(
                name: "formaDePago",
                table: "Factura",
                newName: "FormaDePago");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Factura",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_pedidoid",
                table: "Factura",
                newName: "IX_Factura_PedidoId");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "DetallePedido",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "subTotal",
                table: "DetallePedido",
                newName: "SubTotal");

            migrationBuilder.RenameColumn(
                name: "size",
                table: "DetallePedido",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "pizzaid",
                table: "DetallePedido",
                newName: "PizzaId");

            migrationBuilder.RenameColumn(
                name: "pedidoid",
                table: "DetallePedido",
                newName: "PedidoId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DetallePedido",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "cantidadad",
                table: "DetallePedido",
                newName: "Cantidad");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FormaDePago",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PizzaId",
                table: "DetallePedido",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "DetallePedido",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "DetallePedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_FacturaId",
                table: "DetallePedido",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_PedidoId",
                table: "DetallePedido",
                column: "PedidoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_PizzaId",
                table: "DetallePedido",
                column: "PizzaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Factura_FacturaId",
                table: "DetallePedido",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Pedido_PedidoId",
                table: "DetallePedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Pizza_PizzaId",
                table: "DetallePedido",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Pedido_PedidoId",
                table: "Factura",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientePizza_Ingrediente_IngredientesId",
                table: "IngredientePizza",
                column: "IngredientesId",
                principalTable: "Ingrediente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientePizza_Pizza_PizzasId",
                table: "IngredientePizza",
                column: "PizzasId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Factura_FacturaId",
                table: "DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Pedido_PedidoId",
                table: "DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Pizza_PizzaId",
                table: "DetallePedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Pedido_PedidoId",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientePizza_Ingrediente_IngredientesId",
                table: "IngredientePizza");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientePizza_Pizza_PizzasId",
                table: "IngredientePizza");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_FacturaId",
                table: "DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_PedidoId",
                table: "DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_PizzaId",
                table: "DetallePedido");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "DetallePedido");

            migrationBuilder.RenameColumn(
                name: "Variedad",
                table: "Pizza",
                newName: "variedad");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pizza",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Pizza",
                newName: "precioPorcion");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Pedido",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Pedido",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Demora",
                table: "Pedido",
                newName: "demora");

            migrationBuilder.RenameColumn(
                name: "ClienteNombre",
                table: "Pedido",
                newName: "clienteNombre");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pedido",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PizzasId",
                table: "IngredientePizza",
                newName: "pizzasid");

            migrationBuilder.RenameColumn(
                name: "IngredientesId",
                table: "IngredientePizza",
                newName: "ingredientesid");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientePizza_PizzasId",
                table: "IngredientePizza",
                newName: "IX_IngredientePizza_pizzasid");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Ingrediente",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ingrediente",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "Factura",
                newName: "pedidoid");

            migrationBuilder.RenameColumn(
                name: "FormaDePago",
                table: "Factura",
                newName: "formaDePago");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Factura",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_PedidoId",
                table: "Factura",
                newName: "IX_Factura_pedidoid");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "DetallePedido",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "SubTotal",
                table: "DetallePedido",
                newName: "subTotal");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "DetallePedido",
                newName: "size");

            migrationBuilder.RenameColumn(
                name: "PizzaId",
                table: "DetallePedido",
                newName: "pizzaid");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "DetallePedido",
                newName: "pedidoid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DetallePedido",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "DetallePedido",
                newName: "cantidadad");

            migrationBuilder.AlterColumn<int>(
                name: "pedidoid",
                table: "Factura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "formaDePago",
                table: "Factura",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pizzaid",
                table: "DetallePedido",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pedidoid",
                table: "DetallePedido",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_pedidoid",
                table: "DetallePedido",
                column: "pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_pizzaid",
                table: "DetallePedido",
                column: "pizzaid");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Pedido_pedidoid",
                table: "DetallePedido",
                column: "pedidoid",
                principalTable: "Pedido",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Pizza_pizzaid",
                table: "DetallePedido",
                column: "pizzaid",
                principalTable: "Pizza",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Pedido_pedidoid",
                table: "Factura",
                column: "pedidoid",
                principalTable: "Pedido",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientePizza_Ingrediente_ingredientesid",
                table: "IngredientePizza",
                column: "ingredientesid",
                principalTable: "Ingrediente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientePizza_Pizza_pizzasid",
                table: "IngredientePizza",
                column: "pizzasid",
                principalTable: "Pizza",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
