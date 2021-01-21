using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC.Data.Migrations
{
    public partial class Asset_Facility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "FacilitySites",
                columns: table => new
                {
                    FacilitySiteID = table.Column<Guid>(nullable: false),
                    FacilityName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitySites", x => x.FacilitySiteID);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    AssetID = table.Column<Guid>(nullable: false),
                    Barcode = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    FacilitySiteID = table.Column<Guid>(nullable: false),
                    PMGuide = table.Column<string>(nullable: true),
                    AstID = table.Column<string>(nullable: false),
                    ChildAsset = table.Column<string>(nullable: true),
                    GeneralAssetDescription = table.Column<string>(nullable: true),
                    SecondaryAssetDescription = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    ModelNumber = table.Column<string>(nullable: true),
                    Building = table.Column<string>(nullable: true),
                    Floor = table.Column<string>(nullable: true),
                    Corridor = table.Column<string>(nullable: true),
                    RoomNo = table.Column<string>(nullable: true),
                    MERNo = table.Column<string>(nullable: true),
                    EquipSystem = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Issued = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.AssetID);
                    table.ForeignKey(
                        name: "FK_Assets_FacilitySites_FacilitySiteID",
                        column: x => x.FacilitySiteID,
                        principalTable: "FacilitySites",
                        principalColumn: "FacilitySiteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_FacilitySiteID",
                table: "Assets",
                column: "FacilitySiteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "FacilitySites");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
