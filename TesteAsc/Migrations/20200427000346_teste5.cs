using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteAsc.Migrations
{
    public partial class teste5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competicao",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competicao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    IdAluno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Alunos = table.Column<int>(nullable: true),
                    Competicaoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.IdAluno);
                    table.ForeignKey(
                        name: "FK_Alunos_Turmas_Alunos",
                        column: x => x.Alunos,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alunos_Competicao_Competicaoid",
                        column: x => x.Competicaoid,
                        principalTable: "Competicao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Boletim",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunoIdAluno = table.Column<int>(nullable: true),
                    AlunoAprovado = table.Column<bool>(nullable: false),
                    MediaAluno = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletim", x => x.id);
                    table.ForeignKey(
                        name: "FK_Boletim_Alunos_AlunoIdAluno",
                        column: x => x.AlunoIdAluno,
                        principalTable: "Alunos",
                        principalColumn: "IdAluno",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoProva = table.Column<string>(nullable: true),
                    Nota = table.Column<double>(nullable: false),
                    AlunoIdAluno = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provas_Alunos_AlunoIdAluno",
                        column: x => x.AlunoIdAluno,
                        principalTable: "Alunos",
                        principalColumn: "IdAluno",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Alunos",
                table: "Alunos",
                column: "Alunos");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Competicaoid",
                table: "Alunos",
                column: "Competicaoid");

            migrationBuilder.CreateIndex(
                name: "IX_Boletim_AlunoIdAluno",
                table: "Boletim",
                column: "AlunoIdAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Provas_AlunoIdAluno",
                table: "Provas",
                column: "AlunoIdAluno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boletim");

            migrationBuilder.DropTable(
                name: "Provas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropTable(
                name: "Competicao");
        }
    }
}
