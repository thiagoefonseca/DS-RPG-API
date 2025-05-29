using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 31, 202, 91, 161, 98, 224, 181, 107, 107, 125, 144, 192, 173, 244, 255, 113, 147, 17, 82, 202, 93, 44, 21, 26, 203, 70, 79, 236, 216, 204, 128, 157, 221, 194, 246, 101, 67, 178, 222, 10, 104, 12, 195, 226, 142, 103, 222, 189, 225, 150, 224, 197, 218, 128, 93, 150, 31, 121, 231, 20, 12, 90, 151 }, new byte[] { 76, 109, 152, 167, 162, 40, 177, 51, 68, 87, 67, 29, 69, 138, 129, 162, 178, 226, 86, 13, 135, 117, 89, 155, 69, 65, 142, 48, 135, 89, 83, 18, 81, 235, 126, 137, 124, 143, 84, 246, 199, 68, 163, 67, 146, 98, 157, 23, 212, 143, 106, 250, 30, 226, 229, 203, 26, 225, 168, 135, 114, 120, 121, 202, 149, 213, 139, 40, 110, 74, 153, 16, 40, 65, 164, 49, 87, 69, 93, 230, 28, 62, 15, 191, 143, 38, 53, 91, 4, 222, 228, 123, 34, 244, 150, 76, 198, 66, 55, 80, 253, 9, 159, 56, 215, 254, 41, 97, 242, 8, 16, 137, 46, 122, 94, 122, 214, 175, 232, 146, 247, 130, 51, 108, 15, 250, 235, 169 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 161, 83, 118, 92, 148, 168, 156, 16, 155, 218, 125, 158, 180, 208, 20, 108, 135, 168, 232, 86, 170, 145, 9, 115, 42, 93, 189, 218, 140, 6, 209, 255, 7, 234, 173, 125, 208, 51, 128, 103, 33, 203, 252, 216, 94, 25, 20, 103, 114, 246, 251, 170, 59, 200, 143, 215, 38, 68, 234, 216, 26, 5, 180, 19 }, new byte[] { 166, 36, 225, 94, 170, 48, 167, 169, 194, 245, 171, 216, 10, 176, 80, 131, 71, 227, 158, 142, 186, 146, 108, 95, 78, 118, 194, 86, 97, 166, 1, 161, 2, 14, 227, 35, 124, 180, 44, 71, 118, 113, 159, 17, 103, 239, 230, 151, 132, 145, 210, 146, 172, 206, 62, 237, 133, 14, 93, 167, 123, 56, 81, 74, 114, 41, 50, 82, 56, 37, 100, 81, 69, 54, 115, 154, 73, 248, 90, 99, 159, 132, 129, 85, 3, 120, 145, 139, 152, 30, 72, 12, 224, 189, 41, 72, 233, 139, 239, 223, 217, 154, 185, 132, 93, 41, 118, 136, 240, 129, 41, 127, 209, 181, 15, 200, 188, 33, 181, 85, 45, 154, 168, 36, 141, 191, 254, 111 } });
        }
    }
}
