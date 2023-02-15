using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Migrations
{
    /// <inheritdoc />
    public partial class AddSubtaskTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubTaskTasks");

            migrationBuilder.AddColumn<int>(
                name: "TasksId",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_TasksId",
                table: "SubTasks",
                column: "TasksId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Tasks_TasksId",
                table: "SubTasks",
                column: "TasksId",
                principalTable: "Tasks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Tasks_TasksId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_TasksId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "TasksId",
                table: "SubTasks");

            migrationBuilder.CreateTable(
                name: "SubTaskTasks",
                columns: table => new
                {
                    SubTasksId = table.Column<int>(type: "int", nullable: false),
                    TasksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTaskTasks", x => new { x.SubTasksId, x.TasksId });
                    table.ForeignKey(
                        name: "FK_SubTaskTasks_SubTasks_SubTasksId",
                        column: x => x.SubTasksId,
                        principalTable: "SubTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubTaskTasks_Tasks_TasksId",
                        column: x => x.TasksId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SubTaskTasks_TasksId",
                table: "SubTaskTasks",
                column: "TasksId");
        }
    }
}
