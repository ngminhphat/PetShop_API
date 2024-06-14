using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Migrations
{
    public partial class data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DogItem",
                columns: new[] { "DogItemId", "Age", "Color", "CreateAt", "Description", "DogName", "DogSpeciesId", "HealthStatus", "Images", "IsDeleted", "IsInStock", "Origin", "Price", "Sex", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, "Golden", null, "Friendly and playful dog.", "Buddy", 1, "Healthy", "buddy.jpg", false, true, "United States", 500, "Male", "Labrador", null },
                    { 2, 3, "Black", null, "Intelligent and loyal companion.", "Max", 1, "Vaccinated", "max.jpg", false, true, "Germany", 550, "Male", "German Shepherd", null }
                });

            migrationBuilder.InsertData(
                table: "DogProductItem",
                columns: new[] { "DogProductItemId", "Category", "CreateAt", "Description", "Images", "IsDeleted", "IsInStock", "ItemName", "Price", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Accessories", null, "A strong and durable leash for walking your dog.", "leash.jpg", false, true, "Dog Leash", 20, 50, null },
                    { 2, "Furniture", null, "A comfortable bed for your dog to sleep on.", "bed.jpg", false, true, "Dog Bed", 50, 30, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DogItem",
                keyColumn: "DogItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DogProductItem",
                keyColumn: "DogProductItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DogProductItem",
                keyColumn: "DogProductItemId",
                keyValue: 2);
        }
    }
}
