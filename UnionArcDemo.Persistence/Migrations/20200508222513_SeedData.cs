using Microsoft.EntityFrameworkCore.Migrations;
using UnionArcDemo.Infrastructure.Properties;

namespace UnionArcDemo.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(Resources.ResourceManager.GetString("SeedData_Up"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(Resources.ResourceManager.GetString("SeedData_Down"));
        }
    }
}
