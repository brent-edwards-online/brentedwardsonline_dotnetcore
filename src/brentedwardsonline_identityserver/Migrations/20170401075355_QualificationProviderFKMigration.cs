using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrentEdwardsOnlineDotNetCore.Migrations
{
    public partial class QualificationProviderFKMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_QualificationProviders_QualificationProviderId",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_Qualifications_QualificationProviderId",
                table: "Qualifications");

            migrationBuilder.AddColumn<int>(
                name: "QualificationProvidersId",
                table: "Qualifications",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_QualificationProvidersId",
                table: "Qualifications",
                column: "QualificationProvidersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_QualificationProviders_QualificationProvidersId",
                table: "Qualifications",
                column: "QualificationProvidersId",
                principalTable: "QualificationProviders",
                principalColumn: "QualificationProviderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_QualificationProviders_QualificationProvidersId",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_Qualifications_QualificationProvidersId",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "QualificationProvidersId",
                table: "Qualifications");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_QualificationProviderId",
                table: "Qualifications",
                column: "QualificationProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_QualificationProviders_QualificationProviderId",
                table: "Qualifications",
                column: "QualificationProviderId",
                principalTable: "QualificationProviders",
                principalColumn: "QualificationProviderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
