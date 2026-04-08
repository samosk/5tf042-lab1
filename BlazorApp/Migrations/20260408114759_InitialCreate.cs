using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_annonsorer",
                columns: table => new
                {
                    ann_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ann_typ = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    ann_pre_id = table.Column<int>(type: "integer", nullable: true),
                    ann_namn = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ann_organisationsnummer = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    ann_telefonnummer = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    ann_utdelningsadress = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ann_postnummer = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    ann_ort = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ann_fakt_adress = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    ann_fakt_postnummer = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    ann_fakt_ort = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_annonsorer", x => x.ann_id);
                    table.CheckConstraint("ck_ann_typ", "ann_typ IN ('prenumerant', 'foretag')");
                });

            migrationBuilder.CreateTable(
                name: "tbl_ads",
                columns: table => new
                {
                    ad_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ad_ann_id = table.Column<int>(type: "integer", nullable: false),
                    ad_rubrik = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ad_innehall = table.Column<string>(type: "text", nullable: false),
                    ad_varupris = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    ad_annonspris = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ads", x => x.ad_id);
                    table.ForeignKey(
                        name: "FK_tbl_ads_tbl_annonsorer_ad_ann_id",
                        column: x => x.ad_ann_id,
                        principalTable: "tbl_annonsorer",
                        principalColumn: "ann_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ads_ad_ann_id",
                table: "tbl_ads",
                column: "ad_ann_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_ads");

            migrationBuilder.DropTable(
                name: "tbl_annonsorer");
        }
    }
}
