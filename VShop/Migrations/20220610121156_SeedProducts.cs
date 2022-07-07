using Microsoft.EntityFrameworkCore.Migrations;

namespace VShop.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into products(Name, Price, Description, Stock, ImageURL, CategoryID) " +
                "values('Caderno',7.55, 'Caderno', 10, 'caderno.jpg', 1)");

            mb.Sql("Insert into products(Name, Price, Description, Stock, ImageURL, CategoryID) " +
                "values('Lapis',3.45, 'lapis preto', 10, 'lapis.jpg', 1)");

            mb.Sql("Insert into products(Name, Price, Description, Stock, ImageURL, CategoryID) " +
                "values('CLips',5.33, 'Clips de papel', 50, 'clips.jpg', 2)");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");
        }
    }
}
