using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HepsiSln.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategorytId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategorytId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategorytId",
                        column: x => x.CategorytId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategorytId",
                table: "ProductCategories",
                column: "CategorytId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 23, 10, 50, 20, 545, DateTimeKind.Local).AddTicks(3751), "Sports, Automotive & Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 23, 10, 50, 20, 545, DateTimeKind.Local).AddTicks(3758), "Garden" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 11, 23, 10, 50, 20, 545, DateTimeKind.Local).AddTicks(3766), "Sports & Kids" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 23, 10, 50, 20, 545, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 23, 10, 50, 20, 545, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 23, 10, 50, 20, 545, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 23, 10, 50, 20, 545, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 23, 10, 50, 20, 546, DateTimeKind.Local).AddTicks(6532), "Enim uzattı göze aliquid beatae ışık voluptas hesap.\nKoşuyorlar consequatur oldular odio gülüyorum sıfat suscipit voluptas praesentium.\nYaptı makinesi dolor çobanın.\nQuasi öyle consequatur açılmadan yaptı kulu quis.\nNisi inventore patlıcan commodi ekşili.", "Voluptate." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 23, 10, 50, 20, 546, DateTimeKind.Local).AddTicks(6851), "Magnam nemo domates karşıdakine ad.\nCezbelendi olduğu gidecekmiş sarmal şafak domates ducimus koşuyorlar cezbelendi.\nGöze sıfat sarmal.\nIşık sıradanlıktan sevindi bahar doloremque.\nSit odit çobanın sed enim ea karşıdakine aut sokaklarda.", "Beatae aperiam." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 11, 23, 10, 50, 20, 546, DateTimeKind.Local).AddTicks(6917), "Gidecekmiş adresini dignissimos veritatis ona telefonu.\nGidecekmiş bundan vitae öyle odio.\nÇıktılar quaerat architecto et.\nLaboriosam doğru değerli adipisci çıktılar vel.\nCommodi mutlu yapacakmış hesap qui tv.", "Aut." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 11, 23, 10, 50, 20, 547, DateTimeKind.Local).AddTicks(7721), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8.371681513461820m, 160.26m, "Sleek Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 11, 23, 10, 50, 20, 547, DateTimeKind.Local).AddTicks(7740), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0.5292576709663210m, 48.61m, "Handcrafted Wooden Car" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
