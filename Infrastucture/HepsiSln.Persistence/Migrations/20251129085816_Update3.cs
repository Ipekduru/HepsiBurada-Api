using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HepsiSln.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 58, 16, 217, DateTimeKind.Local).AddTicks(6802), "Baby, Health & Automotive" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 58, 16, 217, DateTimeKind.Local).AddTicks(6813), "Clothing & Sports" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 58, 16, 217, DateTimeKind.Local).AddTicks(6823), "Tools, Beauty & Health" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 58, 16, 217, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 58, 16, 217, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 58, 16, 217, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 29, 11, 58, 16, 217, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 58, 16, 219, DateTimeKind.Local).AddTicks(817), "Ex ad quia voluptatem voluptatem.\nUzattı eaque laudantium orta aut lakin çarpan commodi ekşili magni.\nMagnam quam gördüm sandalye deleniti veniam sit ad.\nSinema filmini et çarpan.\nAdanaya gül ut aspernatur mutlu autem.", "Voluptatem." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 58, 16, 219, DateTimeKind.Local).AddTicks(1134), "Velit corporis ex ipsa ab masaya oldular ex.\nAma çünkü için ad autem vitae sıla mıknatıslı patlıcan kalemi.\nSequi quaerat olduğu çobanın aliquid masanın nostrum çorba.\nAliquid yazın ab ipsa bilgiyasayarı ratione de deleniti.\nOdit adresini ki eaque nesciunt in et umut açılmadan perferendis.", "Çobanın iusto." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 58, 16, 219, DateTimeKind.Local).AddTicks(1209), "Gazete masaya ducimus ex aliquid.\nNostrum qui çobanın lambadaki ışık quae yazın cezbelendi.\nDışarı suscipit voluptate vitae kutusu tempora exercitationem.\nİpsum ışık değirmeni biber ışık enim modi.\nAut çobanın blanditiis quam tv kapının qui vel aut sandalye.", "Quis." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 58, 16, 220, DateTimeKind.Local).AddTicks(7235), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2.620292689400720m, 324.60m, "Fantastic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 11, 29, 11, 58, 16, 220, DateTimeKind.Local).AddTicks(7256), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6.671217317689050m, 272.66m, "Intelligent Rubber Sausages" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
