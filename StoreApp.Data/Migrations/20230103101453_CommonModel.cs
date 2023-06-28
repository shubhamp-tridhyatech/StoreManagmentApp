using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CommonModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Stores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Stores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Stores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Stores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Stores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "State",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "State",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "State",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "State",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "State",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "State",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductUnits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "ProductUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductUnits",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "ProductUnits",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductUnits",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "ProductUnits",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTaxes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "ProductTaxes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductTaxes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "ProductTaxes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTaxes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "ProductTaxes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductRates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "ProductRates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductRates",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "ProductRates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductRates",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "ProductRates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "ProductCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "ProductCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Country",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Country",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Country",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Country",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Country",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "City",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "City",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "City",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "City",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "State");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "State");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "State");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "State");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "State");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "State");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductUnits");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductUnits");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductUnits");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductUnits");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductUnits");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductUnits");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductTaxes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductTaxes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductTaxes");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductTaxes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductTaxes");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductTaxes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductRates");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductRates");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductRates");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductRates");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductRates");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductRates");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "City");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "City");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "City");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "City");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "City");
        }
    }
}
