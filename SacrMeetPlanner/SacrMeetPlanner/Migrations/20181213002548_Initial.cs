using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacrMeetPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Conducting = table.Column<string>(nullable: true),
                    Presiding = table.Column<string>(nullable: true),
                    FirstHimnTitle = table.Column<string>(nullable: true),
                    FirstHimnNum = table.Column<int>(nullable: false),
                    FirstPrayer = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Announcements = table.Column<string>(nullable: true),
                    FirstSpeaker = table.Column<string>(nullable: true),
                    SecondSpeaker = table.Column<string>(nullable: true),
                    SecondHimnTitle = table.Column<string>(nullable: true),
                    SecondHimnNum = table.Column<int>(nullable: false),
                    ThirdSpeaker = table.Column<string>(nullable: true),
                    LastHimnTitle = table.Column<string>(nullable: true),
                    LastHimnNum = table.Column<int>(nullable: false),
                    LastPrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
