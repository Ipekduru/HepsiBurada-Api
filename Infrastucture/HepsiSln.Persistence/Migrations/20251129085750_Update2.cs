using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HepsiSln.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 57, 50, 708, DateTimeKind.Local).AddTicks(4752), "Home, Movies & Sports" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 57, 50, 708, DateTimeKind.Local).AddTicks(4761), "Grocery & Movies" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 57, 50, 708, DateTimeKind.Local).AddTicks(4766), "Shoes" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 57, 50, 708, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 57, 50, 708, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 57, 50, 708, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 57, 50, 708, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 57, 50, 709, DateTimeKind.Local).AddTicks(8326), "Odit ona sinema çünkü dicta quae nihil.\nEsse için consectetur ipsa voluptatum.\nDoloremque gidecekmiş dolorem oldular.\nUllam veniam lakin inventore yapacakmış inventore ışık voluptate.\nAdipisci fugit architecto accusantium otobüs masaya non esse ad reprehenderit.", "Sit." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 57, 50, 709, DateTimeKind.Local).AddTicks(8628), "Kapının qui mıknatıslı qui.\nVelit sed non çakıl nemo aperiam sokaklarda quia.\nAutem mi tv.\nEa yazın orta koşuyorlar ipsa çorba consectetur.\nMagni ona telefonu aliquid nesciunt.", "Consectetur quia." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 57, 50, 709, DateTimeKind.Local).AddTicks(8731), "Ad şafak masanın duyulmamış explicabo dignissimos ut ex eius.\nRem değirmeni balıkhaneye et gülüyorum değirmeni voluptatum balıkhaneye sıla dergi.\nCorporis nesciunt commodi ut quae telefonu doğru.\nVoluptatem consequatur ut koşuyorlar ad sinema.\nBilgiyasayarı beatae tempora.", "Orta." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 57, 50, 711, DateTimeKind.Local).AddTicks(6535), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5.674342284295360m, 396.73m, "Small Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 57, 50, 711, DateTimeKind.Local).AddTicks(6554), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6.429443024436240m, 575.55m, "Gorgeous Soft Cheese" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 50, 30, 139, DateTimeKind.Local).AddTicks(3472), "Music & Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 50, 30, 139, DateTimeKind.Local).AddTicks(3478), "Sports" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 50, 30, 139, DateTimeKind.Local).AddTicks(3481), "Sports" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 50, 30, 139, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 50, 30, 139, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 50, 30, 139, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 50, 30, 139, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 50, 30, 140, DateTimeKind.Local).AddTicks(7134), "Yazın kulu veniam çorba dolores sit açılmadan odio aut rem.\nMıknatıslı gül quia quia.\nİnventore et ekşili laboriosam çobanın ab aperiam.\nUllam quaerat quia ki uzattı eius dergi dicta eaque gördüm.\nCezbelendi ut sıla iure.", "Çünkü." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 50, 30, 140, DateTimeKind.Local).AddTicks(7411), "Dağılımı exercitationem çorba adresini çünkü doğru aperiam masaya inventore sit.\nMagnam aut velit non sıradanlıktan sandalye.\nNon kutusu iusto.\nHesap şafak enim.\nOdio quia ea exercitationem veritatis öyle quia et masanın.", "Reprehenderit qui." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 50, 30, 140, DateTimeKind.Local).AddTicks(7509), "Yazın sit non olduğu için quia modi çorba totam praesentium.\nMakinesi olduğu salladı ullam labore sokaklarda cesurca.\nVeniam dışarı ratione.\nİure sed koştum duyulmamış beğendim amet sevindi.\nEnim de explicabo otobüs masaya cesurca.", "Velit." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 50, 30, 142, DateTimeKind.Local).AddTicks(3466), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3.278124573024010m, 403.27m, "Rustic Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 50, 30, 142, DateTimeKind.Local).AddTicks(3507), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1.763900033459610m, 851.82m, "Incredible Steel Sausages" });
        }
    }
}
