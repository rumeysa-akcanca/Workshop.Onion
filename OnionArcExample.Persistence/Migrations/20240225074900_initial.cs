using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionArcExample.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("1d7143a6-d198-4f25-aef8-277f32ef9d3f"), "Pamuklu ", "Gömlek", 12, 12 },
                    { new Guid("32425b98-8268-4a05-8478-28412190e231"), "Polyester ", "Kazak", 12, 42 },
                    { new Guid("3fd523c4-6f75-447e-b6bb-f2a53ddfdfde"), "Kadife ", "Pantolan", 12, 22 },
                    { new Guid("abdddcd9-06c4-48a8-af20-17b0030fcea4"), "Yün ", "Hırka", 12, 32 },
                    { new Guid("e6e9a4bd-a160-4c9a-803f-51420a866be7"), "Keten ", "Etek", 12, 52 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
