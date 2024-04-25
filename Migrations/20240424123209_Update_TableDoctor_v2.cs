using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_Healthcare.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableDoctor_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_MedicalSpecialties_MedicalSpecialtyId_Specialty",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "MedicalSpecialtyId_Specialty",
                table: "Doctors",
                newName: "Id_Specialty");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_MedicalSpecialtyId_Specialty",
                table: "Doctors",
                newName: "IX_Doctors_Id_Specialty");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_MedicalSpecialties_Id_Specialty",
                table: "Doctors",
                column: "Id_Specialty",
                principalTable: "MedicalSpecialties",
                principalColumn: "Id_Specialty");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_MedicalSpecialties_Id_Specialty",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "Id_Specialty",
                table: "Doctors",
                newName: "MedicalSpecialtyId_Specialty");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_Id_Specialty",
                table: "Doctors",
                newName: "IX_Doctors_MedicalSpecialtyId_Specialty");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_MedicalSpecialties_MedicalSpecialtyId_Specialty",
                table: "Doctors",
                column: "MedicalSpecialtyId_Specialty",
                principalTable: "MedicalSpecialties",
                principalColumn: "Id_Specialty");
        }
    }
}
