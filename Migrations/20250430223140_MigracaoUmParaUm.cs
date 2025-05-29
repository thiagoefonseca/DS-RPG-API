using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 161, 83, 118, 92, 148, 168, 156, 16, 155, 218, 125, 158, 180, 208, 20, 108, 135, 168, 232, 86, 170, 145, 9, 115, 42, 93, 189, 218, 140, 6, 209, 255, 7, 234, 173, 125, 208, 51, 128, 103, 33, 203, 252, 216, 94, 25, 20, 103, 114, 246, 251, 170, 59, 200, 143, 215, 38, 68, 234, 216, 26, 5, 180, 19 }, new byte[] { 166, 36, 225, 94, 170, 48, 167, 169, 194, 245, 171, 216, 10, 176, 80, 131, 71, 227, 158, 142, 186, 146, 108, 95, 78, 118, 194, 86, 97, 166, 1, 161, 2, 14, 227, 35, 124, 180, 44, 71, 118, 113, 159, 17, 103, 239, 230, 151, 132, 145, 210, 146, 172, 206, 62, 237, 133, 14, 93, 167, 123, 56, 81, 74, 114, 41, 50, 82, 56, 37, 100, 81, 69, 54, 115, 154, 73, 248, 90, 99, 159, 132, 129, 85, 3, 120, 145, 139, 152, 30, 72, 12, 224, 189, 41, 72, 233, 139, 239, 223, 217, 154, 185, 132, 93, 41, 118, 136, 240, 129, 41, 127, 209, 181, 15, 200, 188, 33, 181, 85, 45, 154, 168, 36, 141, 191, 254, 111 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 8, 38, 246, 110, 47, 49, 234, 125, 128, 154, 32, 242, 116, 26, 138, 34, 36, 175, 30, 30, 62, 1, 190, 102, 119, 69, 120, 141, 141, 234, 100, 22, 169, 19, 170, 252, 64, 33, 152, 147, 254, 153, 147, 64, 98, 85, 144, 180, 85, 19, 216, 101, 218, 191, 106, 108, 89, 228, 250, 120, 40, 75, 205, 46 }, new byte[] { 153, 76, 125, 49, 107, 68, 142, 148, 56, 249, 135, 102, 29, 254, 116, 237, 156, 224, 67, 48, 70, 22, 81, 32, 4, 38, 7, 178, 99, 15, 214, 107, 20, 253, 195, 17, 25, 186, 211, 135, 171, 56, 74, 48, 72, 74, 26, 146, 221, 160, 235, 140, 25, 117, 165, 212, 165, 152, 251, 117, 240, 55, 152, 154, 224, 238, 69, 200, 22, 175, 178, 144, 89, 106, 1, 56, 182, 243, 101, 61, 135, 114, 98, 117, 92, 33, 74, 127, 0, 118, 69, 58, 14, 70, 11, 35, 141, 82, 64, 90, 56, 165, 2, 56, 114, 195, 164, 100, 130, 147, 159, 129, 46, 71, 244, 94, 198, 180, 232, 26, 242, 194, 59, 3, 226, 134, 53, 198 } });
        }
    }
}
