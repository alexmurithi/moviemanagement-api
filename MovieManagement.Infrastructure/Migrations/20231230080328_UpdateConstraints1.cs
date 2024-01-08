using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConstraints1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biographies_Actors_ActorId",
                table: "Biographies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Biographies_ActorId",
                table: "Biographies");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("273425b1-0e23-40a3-a40f-5632a6456e60"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b5650ba4-5bbb-4f4c-82ae-3fa3790c2a3a"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("ee3c4d69-9b72-44c9-8fcc-690835923d9e"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ActorId",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ActorId",
                table: "Biographies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11b80f9b-324d-4b2b-b828-59103873a533"), new DateTime(2023, 12, 30, 8, 3, 28, 345, DateTimeKind.Utc).AddTicks(6727), "Justin", "Timberlake", new DateTime(2023, 12, 30, 8, 3, 28, 345, DateTimeKind.Utc).AddTicks(6729) },
                    { new Guid("317a5245-cd81-461d-99a2-041a96ed0223"), new DateTime(2023, 12, 30, 8, 3, 28, 345, DateTimeKind.Utc).AddTicks(6730), "Chuck", "Norris", new DateTime(2023, 12, 30, 8, 3, 28, 345, DateTimeKind.Utc).AddTicks(6731) },
                    { new Guid("f08a4034-65a9-4529-84a4-8aa532b9c089"), new DateTime(2023, 12, 30, 8, 3, 28, 345, DateTimeKind.Utc).AddTicks(6732), "Van", "Damme", new DateTime(2023, 12, 30, 8, 3, 28, 345, DateTimeKind.Utc).AddTicks(6732) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biographies_ActorId",
                table: "Biographies",
                column: "ActorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Biographies_Actors_ActorId",
                table: "Biographies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biographies_Actors_ActorId",
                table: "Biographies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Biographies_ActorId",
                table: "Biographies");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("11b80f9b-324d-4b2b-b828-59103873a533"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("317a5245-cd81-461d-99a2-041a96ed0223"));

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("f08a4034-65a9-4529-84a4-8aa532b9c089"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ActorId",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ActorId",
                table: "Biographies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("273425b1-0e23-40a3-a40f-5632a6456e60"), new DateTime(2023, 12, 30, 8, 1, 43, 199, DateTimeKind.Utc).AddTicks(1506), "Chuck", "Norris", new DateTime(2023, 12, 30, 8, 1, 43, 199, DateTimeKind.Utc).AddTicks(1507) },
                    { new Guid("b5650ba4-5bbb-4f4c-82ae-3fa3790c2a3a"), new DateTime(2023, 12, 30, 8, 1, 43, 199, DateTimeKind.Utc).AddTicks(1508), "Van", "Damme", new DateTime(2023, 12, 30, 8, 1, 43, 199, DateTimeKind.Utc).AddTicks(1508) },
                    { new Guid("ee3c4d69-9b72-44c9-8fcc-690835923d9e"), new DateTime(2023, 12, 30, 8, 1, 43, 199, DateTimeKind.Utc).AddTicks(1503), "Justin", "Timberlake", new DateTime(2023, 12, 30, 8, 1, 43, 199, DateTimeKind.Utc).AddTicks(1504) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biographies_ActorId",
                table: "Biographies",
                column: "ActorId",
                unique: true,
                filter: "[ActorId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Biographies_Actors_ActorId",
                table: "Biographies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Actors_ActorId",
                table: "Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id");
        }
    }
}
