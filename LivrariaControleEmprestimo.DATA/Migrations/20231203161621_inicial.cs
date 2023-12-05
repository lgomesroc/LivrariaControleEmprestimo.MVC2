using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    cliCPF = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    cliNome = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    cliEndereco = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    cliCidade = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    cliBairro = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    cliNumero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cliTelefoneCelular = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    cliTelefoneFixo = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    livroNome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    livroAutor = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    livroEditora = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    livroAnoPublicacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    livroEdicao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Livro_Cliente_Emprestimo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    lceIdLivro = table.Column<int>(type: "int", nullable: true),
                    lceIdCliente = table.Column<int>(type: "int", nullable: true),
                    lceDataEmprestimo = table.Column<DateTime>(type: "datetime", nullable: true),
                    lceDataDevolucao = table.Column<DateTime>(type: "datetime", nullable: true),
                    lceEntrega = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro_Cliente_Emprestimo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Livro_Cliente_Emprestimo_Cliente",
                        column: x => x.id,
                        principalTable: "Cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Livro_Cliente_Emprestimo_Livro",
                        column: x => x.id,
                        principalTable: "Livro",
                        principalColumn: "id");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro_Cliente_Emprestimo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Livro");
        }
    }
}
