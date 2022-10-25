using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListApp.Api.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "f642ad02-32cb-4705-b744-f5ed4f591c44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "334fac40-bf66-4604-bb3d-f2e644a17d66");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "045e90e6-ba58-49d9-aef3-9fc464633191", "AQAAAAEAACcQAAAAEA10hwUPz3kqGktLjHDfXt/cF/Tl4MpwKqWH2zV8FRcRpYs1/x5sOT3ze5OJBIfxZQ==", "4b4c0385-17dc-4a78-a767-067605b51168" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec61c1c5-50a1-4864-9170-8590f23f6f0c", "AQAAAAEAACcQAAAAEFCTpwBS2r+Dvy4hOyN7izGdzVKmA/MmYohyWLPQALb2rZ3UhW0MxHaS7V/28r6jvw==", "37aeab6d-04db-429f-8d47-a39d5a6e8d2d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                column: "ConcurrencyStamp",
                value: "4ead6e79-84b4-4a80-b0e1-dc4006a233de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                column: "ConcurrencyStamp",
                value: "fc3acd77-dc02-4553-a71e-d7020a16a569");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "817a9d48-83e4-44f5-9d3b-e9a4819ce3fe", "AQAAAAEAACcQAAAAEFJbxKluFqbCpZQZHoi0HzQZltt4dV/RU/HaC1L9qqABT7Mh0M8e4SDiL4ELavqMtw==", "a96ccbd7-5608-4a56-b38c-45725850eb71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b81255b9-0e99-41e2-9ea5-9c9c2b193f4c", "AQAAAAEAACcQAAAAEK7Bt9mF1ZbBeFbOer1RI4Pdw0OL3vOG/jSspdPkzyBaEPoUyAV4BS5vqSuGlcnf1Q==", "da100006-0caa-4be2-b515-2ea21d086ff7" });
        }
    }
}
