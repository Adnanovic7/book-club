using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bookclub.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    username = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    phonenumber = table.Column<int>(nullable: false),
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    relasedate = table.Column<DateTime>(nullable: false),
                    price = table.Column<decimal>(type: "decimal(9,4)", nullable: false),
                    type = table.Column<string>(nullable: true),
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    publisher_onepublisher_one = table.Column<int>(nullable: false),
                    Publisherpid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                    table.ForeignKey(
                        name: "FK_books_Publishers_Publisherpid",
                        column: x => x.Publisherpid,
                        principalTable: "Publishers",
                        principalColumn: "pid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    phone = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    Bookid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.id);
                    table.ForeignKey(
                        name: "FK_Authors_books_Bookid",
                        column: x => x.Bookid,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bookuser",
                columns: table => new
                {
                    bookid = table.Column<int>(nullable: false),
                    userid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookuser", x => new { x.bookid, x.userid });
                    table.ForeignKey(
                        name: "FK_Bookuser_books_bookid",
                        column: x => x.bookid,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookuser_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authorbook",
                columns: table => new
                {
                    author_book_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    authorid = table.Column<int>(nullable: false),
                    bookid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorbook", x => x.author_book_id);
                    table.ForeignKey(
                        name: "FK_Authorbook_Authors_authorid",
                        column: x => x.authorid,
                        principalTable: "Authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Authorbook_books_bookid",
                        column: x => x.bookid,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authorbook_authorid",
                table: "Authorbook",
                column: "authorid");

            migrationBuilder.CreateIndex(
                name: "IX_Authorbook_bookid",
                table: "Authorbook",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Bookid",
                table: "Authors",
                column: "Bookid");

            migrationBuilder.CreateIndex(
                name: "IX_books_Publisherpid",
                table: "books",
                column: "Publisherpid");

            migrationBuilder.CreateIndex(
                name: "IX_Bookuser_userid",
                table: "Bookuser",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authorbook");

            migrationBuilder.DropTable(
                name: "Bookuser");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
