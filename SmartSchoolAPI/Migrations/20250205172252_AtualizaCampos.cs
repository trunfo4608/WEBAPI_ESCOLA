using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchoolAPI.Migrations
{
    public partial class AtualizaCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 265, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 265, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 265, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 265, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 265, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 265, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 265, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 5, 14, 22, 51, 266, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 5, 14, 22, 51, 255, DateTimeKind.Local).AddTicks(4472), "333333333333" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 5, 14, 22, 51, 258, DateTimeKind.Local).AddTicks(8985), "1111111111" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 5, 14, 22, 51, 258, DateTimeKind.Local).AddTicks(9168), "11111111111" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 5, 14, 22, 51, 258, DateTimeKind.Local).AddTicks(9173), "22222222222" });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 5, 14, 22, 51, 258, DateTimeKind.Local).AddTicks(9176), "99999999999" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataInicio",
                value: new DateTime(2025, 2, 4, 9, 49, 51, 848, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 4, 9, 49, 51, 841, DateTimeKind.Local).AddTicks(1004), null });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 4, 9, 49, 51, 842, DateTimeKind.Local).AddTicks(7091), null });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 4, 9, 49, 51, 842, DateTimeKind.Local).AddTicks(7197), null });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 4, 9, 49, 51, 842, DateTimeKind.Local).AddTicks(7202), null });

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataIni", "Telefone" },
                values: new object[] { new DateTime(2025, 2, 4, 9, 49, 51, 842, DateTimeKind.Local).AddTicks(7204), null });
        }
    }
}
