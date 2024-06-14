using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogSpecies",
                keyColumn: "DogSpeciesId",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 1,
                columns: new[] { "HealthStatus", "Origin", "Sex" },
                values: new object[] { "Đã tiêm vacxin", "Mỹ", "Đực" });

            migrationBuilder.UpdateData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 2,
                columns: new[] { "HealthStatus", "Origin", "Sex" },
                values: new object[] { "Đã tiêm vacxin", "Đức", "Đực" });

            migrationBuilder.InsertData(
                table: "DogItem",
                columns: new[] { "DogItemId", "Age", "Color", "CreateAt", "Description", "DogName", "DogSpeciesId", "HealthStatus", "Images", "IsDeleted", "IsInStock", "Origin", "Price", "Sex", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 1, "Gray", null, "Thông minh và lanh lợi", "Bull ", 4, "Đã tiêm vacxin", "bull.jpg", false, true, "xứ Wales thuộc Vương quốc Anh", 600, "Cái", "Chó chăn gia súc nhỏ", null },
                    { 4, 2, "Black", null, "Thông minh ,lanh lợi,hoạt bát", "Bill ", 8, "Đã tiêm vacxin", "Bill.jpg", false, true, "Tây Âu", 650, "Female", "Chó săn vịt", null },
                    { 5, 3, "Gray and white", null, "Thông minh,cảnh giác,hiếu động", "Bule ", 3, "Đã tiêm vacxin", "Bule.jpg", false, true, "Nga", 500, "Male", "Chó kéo xe", null },
                    { 6, 1, "Black and dark", null, "Bạo dạn,cảnh giác", "Kilu", 10, "Đã tiêm vacxin,khỏe mạnh", "Kilu.jpg", false, true, "Nhật bản", 600, "Female", "Chó cảnh", null }
                });

            migrationBuilder.InsertData(
                table: "DogProductItem",
                columns: new[] { "DogProductItemId", "Category", "CreateAt", "Description", "Images", "IsDeleted", "IsInStock", "ItemName", "Price", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, "Furniture", null, "một cái bát giúp cho chó được vệ sinh hơn", "Dog Bowls.jpg", false, true, "Bát uống nước", 100, 40, null },
                    { 4, "Accessories", null, "Một phụ kiện cho chó", "DOG COLLAR.jpg", false, true, "Nón cute", 120, 41, null },
                    { 5, "Accessories", null, "giúp chú chó xin xắn hơn", "Pet clothing.jpg", false, true, "Quần áo cho chó", 100, 30, null },
                    { 6, "Furniture", null, "một cái lồng để nuôi chó", "dog cage.jpg", false, true, "Lồng chó", 150, 10, null }
                });

            migrationBuilder.UpdateData(
                table: "DogSpecies",
                keyColumn: "DogSpeciesId",
                keyValue: 1,
                column: "DogSpeciesName",
                value: " Golden Retriever");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DogProductItem",
                keyColumn: "DogProductItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DogProductItem",
                keyColumn: "DogProductItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DogProductItem",
                keyColumn: "DogProductItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DogProductItem",
                keyColumn: "DogProductItemId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 1,
                columns: new[] { "HealthStatus", "Origin", "Sex" },
                values: new object[] { "Healthy", "United States", "Male" });

            migrationBuilder.UpdateData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 2,
                columns: new[] { "HealthStatus", "Origin", "Sex" },
                values: new object[] { "Vaccinated", "Germany", "Male" });

            migrationBuilder.UpdateData(
                table: "DogSpecies",
                keyColumn: "DogSpeciesId",
                keyValue: 1,
                column: "DogSpeciesName",
                value: "Golden Retriever");

            migrationBuilder.InsertData(
                table: "DogSpecies",
                columns: new[] { "DogSpeciesId", "CreateAt", "DogSpeciesName", "IsDeleted", "UpdatedAt" },
                values: new object[] { 19, null, "Đồ cho mèo", null, null });
        }
    }
}
