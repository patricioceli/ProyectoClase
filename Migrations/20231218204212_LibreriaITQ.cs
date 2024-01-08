using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoClase.Migrations
{
    /// <inheritdoc />
    public partial class LibreriaITQ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Libros_LibroId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Usuarios_UsuarioId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Ventas",
                newName: "UsuarioIdUsuario");

            migrationBuilder.RenameColumn(
                name: "LibroId",
                table: "Ventas",
                newName: "LibroIdLibro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ventas",
                newName: "IdVenta");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_UsuarioId",
                table: "Ventas",
                newName: "IX_Ventas_UsuarioIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_LibroId",
                table: "Ventas",
                newName: "IX_Ventas_LibroIdLibro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Libros",
                newName: "IdLibro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categorias",
                newName: "IdCategoria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Autores",
                newName: "IdAutor");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Libros_LibroIdLibro",
                table: "Ventas",
                column: "LibroIdLibro",
                principalTable: "Libros",
                principalColumn: "IdLibro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Usuarios_UsuarioIdUsuario",
                table: "Ventas",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Libros_LibroIdLibro",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Usuarios_UsuarioIdUsuario",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "UsuarioIdUsuario",
                table: "Ventas",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "LibroIdLibro",
                table: "Ventas",
                newName: "LibroId");

            migrationBuilder.RenameColumn(
                name: "IdVenta",
                table: "Ventas",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_UsuarioIdUsuario",
                table: "Ventas",
                newName: "IX_Ventas_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_LibroIdLibro",
                table: "Ventas",
                newName: "IX_Ventas_LibroId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdLibro",
                table: "Libros",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "Categorias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdAutor",
                table: "Autores",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Libros_LibroId",
                table: "Ventas",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Usuarios_UsuarioId",
                table: "Ventas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
