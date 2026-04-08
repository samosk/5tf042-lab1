using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PrenumerantSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_prenumeranter",
                columns: table => new
                {
                    pre_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pre_prenumerantnummer = table.Column<int>(type: "integer", nullable: false),
                    pre_personnummer = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    pre_fornamn = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    pre_efternamn = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    pre_utdelningsadress = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    pre_postnummer = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    pre_ort = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    pre_telefonnummer = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_prenumeranter", x => x.pre_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_prenumeranter_pre_personnummer",
                table: "tbl_prenumeranter",
                column: "pre_personnummer",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_prenumeranter_pre_prenumerantnummer",
                table: "tbl_prenumeranter",
                column: "pre_prenumerantnummer",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_prenumeranter");
        }
    }
}
