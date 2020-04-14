using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreRestApi.Data.Migrations
{
    public partial class OnlineReferenceRandomInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OnlineReference",
                table: "Customers",
                nullable: false,
                defaultValueSql: "ABS(CHECKSUM(NEWID())) % 1000000 + 1",
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OnlineReference",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "ABS(CHECKSUM(NEWID())) % 1000000 + 1");
        }
    }
}
