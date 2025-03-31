using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ebuy.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_USER",
                columns: table => new
                {
                    PK_USER = table.Column<Guid>(type: "uuid", nullable: false),
                    TX_NAME = table.Column<string>(type: "text", nullable: false),
                    T_EMAIL = table.Column<string>(type: "text", nullable: false),
                    T_PASSWORD = table.Column<string>(type: "text", nullable: false),
                    FL_ACTIVE = table.Column<bool>(type: "boolean", nullable: false),
                    DT_REGISTRATION_DATE = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER", x => x.PK_USER);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_USER");
        }
    }
}
