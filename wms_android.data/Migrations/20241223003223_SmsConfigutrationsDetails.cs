using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.data.Migrations
{
    /// <inheritdoc />
    public partial class SmsConfigutrationsDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("11ceabc4-4d8d-4fbd-85d0-5abe53881797"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1cabcf11-bfa9-4e32-9db5-10630fc66568"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1cc71fff-97b3-4b72-8c4f-bcf66fb82880"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("289d13f6-b87c-475c-b8d2-49735ddcddfd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3a3c514d-767f-4ef7-b6ba-2adacdbd318a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("504ae303-b8cf-4416-84a7-e51736d45a72"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("8db8838e-49bf-4c52-b350-c641d8cebc94"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("9ca13f45-a62a-49cd-b4c5-d75e59896213"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c00e9133-8a7f-4174-9d7a-5d8957ca8e33"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c6cbc754-c6b5-4ecd-919d-b1840502df91"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("11b5e0dd-8699-4432-b216-bd2799408716"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("526365ca-b37a-4b43-b1b8-876b2055e028"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("79b2a1b1-29fd-444c-8540-fbba94f8e330"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("826b498f-94af-423f-afcb-f5d5edc146ec"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8dbb49a8-4f67-4480-8339-451de202fe32"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d17f4e37-01ed-4956-80fe-e50121a15e9e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f4ab06a0-a204-4d3b-b15e-ed01418e7943"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DispatchedAt",
                table: "Parcels",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Parcels",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("063c3fb1-a9d5-42fd-adbd-2e0ea69b79dc"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("1de7cd61-d2e9-4876-a9f6-ba5be3f1a917"), "Charles", "SK", "Maina", "DL123456" },
                    { new Guid("1f49db4d-19ec-49ea-859e-06ae058a5ab8"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("353c139f-d796-466a-a63d-130d8cbac759"), "James", "SK", "Gichohi", "DL123456" },
                    { new Guid("72fa8a8b-0ea4-4b30-93ff-3f6b41dfb17a"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("9eef5061-b2f0-4521-9ae9-b9bbad636417"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("a250e5ef-48f9-4946-9fad-d087fae9898d"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("cca00b71-1068-4992-b23a-29c953e6bee6"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("cf03f065-0d2a-45d3-b501-229572977b9a"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("fa7047a7-d08e-4981-ab05-23c2c3cdbbc4"), "Robert", "RN", "Njuguna", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 }, new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 }, new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 }, new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 }, new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 }, new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("50490d62-f841-43d7-82e5-6b03a6ff36d9"), "Truck", "KCZ 595L" },
                    { new Guid("80c5b6ba-6ab6-47d3-8038-cc609aa404b5"), "Van", "KBF 462A" },
                    { new Guid("9e63e7ab-7a1b-42dc-bf90-d09575293cb7"), "Truck", "KDE 228S" },
                    { new Guid("a4a343e5-f7f7-4b17-a5e9-0d114417cc5b"), "Truck", "KDB 387Q" },
                    { new Guid("b4bd30f6-ff32-4a54-99ba-e554ca9192b8"), "Truck", "KCY 067A" },
                    { new Guid("c0ea063a-3290-44a4-9c23-c7b34067cd66"), "Truck", "KDL 085M" },
                    { new Guid("e88786f2-9116-4280-ab95-318a75f18c13"), "Van", "KAY 215H" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("063c3fb1-a9d5-42fd-adbd-2e0ea69b79dc"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1de7cd61-d2e9-4876-a9f6-ba5be3f1a917"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1f49db4d-19ec-49ea-859e-06ae058a5ab8"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("353c139f-d796-466a-a63d-130d8cbac759"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("72fa8a8b-0ea4-4b30-93ff-3f6b41dfb17a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("9eef5061-b2f0-4521-9ae9-b9bbad636417"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a250e5ef-48f9-4946-9fad-d087fae9898d"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("cca00b71-1068-4992-b23a-29c953e6bee6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("cf03f065-0d2a-45d3-b501-229572977b9a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("fa7047a7-d08e-4981-ab05-23c2c3cdbbc4"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("50490d62-f841-43d7-82e5-6b03a6ff36d9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("80c5b6ba-6ab6-47d3-8038-cc609aa404b5"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9e63e7ab-7a1b-42dc-bf90-d09575293cb7"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a4a343e5-f7f7-4b17-a5e9-0d114417cc5b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b4bd30f6-ff32-4a54-99ba-e554ca9192b8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c0ea063a-3290-44a4-9c23-c7b34067cd66"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e88786f2-9116-4280-ab95-318a75f18c13"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DispatchedAt",
                table: "Parcels",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Parcels",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "FirstName", "Initials", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("11ceabc4-4d8d-4fbd-85d0-5abe53881797"), "David", "DM", "Mwangi", "DL123456" },
                    { new Guid("1cabcf11-bfa9-4e32-9db5-10630fc66568"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("1cc71fff-97b3-4b72-8c4f-bcf66fb82880"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("289d13f6-b87c-475c-b8d2-49735ddcddfd"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("3a3c514d-767f-4ef7-b6ba-2adacdbd318a"), "James", "SK", "Gichohi", "DL123456" },
                    { new Guid("504ae303-b8cf-4416-84a7-e51736d45a72"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("8db8838e-49bf-4c52-b350-c641d8cebc94"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("9ca13f45-a62a-49cd-b4c5-d75e59896213"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("c00e9133-8a7f-4174-9d7a-5d8957ca8e33"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("c6cbc754-c6b5-4ecd-919d-b1840502df91"), "Charles", "SK", "Maina", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 16, 102, 101, 105, 40, 158, 175, 226, 84, 198, 37, 233, 104, 167, 3, 110, 253, 139, 252, 140, 44, 104, 35, 36, 243, 91, 51, 105, 45, 142, 73, 49, 158, 154, 181, 64, 99, 227, 26, 216, 79, 80, 240, 209, 74, 0, 71, 182, 128, 184, 23, 207, 136, 105, 47, 50, 122, 67, 78, 39, 124, 178, 19 }, new byte[] { 10, 7, 102, 234, 22, 210, 29, 156, 82, 95, 102, 89, 180, 28, 190, 48, 66, 24, 9, 25, 98, 219, 138, 255, 44, 154, 60, 218, 228, 117, 157, 186, 194, 63, 169, 168, 225, 90, 135, 196, 95, 116, 58, 22, 110, 145, 180, 135, 207, 184, 46, 6, 47, 23, 186, 149, 123, 33, 14, 97, 193, 176, 5, 6, 171, 3, 174, 118, 239, 130, 147, 111, 212, 34, 139, 180, 66, 123, 181, 2, 80, 192, 152, 237, 139, 139, 139, 79, 147, 117, 214, 5, 57, 235, 69, 241, 125, 36, 65, 226, 29, 147, 124, 26, 43, 235, 190, 230, 4, 169, 7, 161, 143, 150, 208, 227, 231, 90, 136, 48, 95, 81, 139, 235, 22, 52, 12, 137 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 16, 102, 101, 105, 40, 158, 175, 226, 84, 198, 37, 233, 104, 167, 3, 110, 253, 139, 252, 140, 44, 104, 35, 36, 243, 91, 51, 105, 45, 142, 73, 49, 158, 154, 181, 64, 99, 227, 26, 216, 79, 80, 240, 209, 74, 0, 71, 182, 128, 184, 23, 207, 136, 105, 47, 50, 122, 67, 78, 39, 124, 178, 19 }, new byte[] { 10, 7, 102, 234, 22, 210, 29, 156, 82, 95, 102, 89, 180, 28, 190, 48, 66, 24, 9, 25, 98, 219, 138, 255, 44, 154, 60, 218, 228, 117, 157, 186, 194, 63, 169, 168, 225, 90, 135, 196, 95, 116, 58, 22, 110, 145, 180, 135, 207, 184, 46, 6, 47, 23, 186, 149, 123, 33, 14, 97, 193, 176, 5, 6, 171, 3, 174, 118, 239, 130, 147, 111, 212, 34, 139, 180, 66, 123, 181, 2, 80, 192, 152, 237, 139, 139, 139, 79, 147, 117, 214, 5, 57, 235, 69, 241, 125, 36, 65, 226, 29, 147, 124, 26, 43, 235, 190, 230, 4, 169, 7, 161, 143, 150, 208, 227, 231, 90, 136, 48, 95, 81, 139, 235, 22, 52, 12, 137 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 16, 102, 101, 105, 40, 158, 175, 226, 84, 198, 37, 233, 104, 167, 3, 110, 253, 139, 252, 140, 44, 104, 35, 36, 243, 91, 51, 105, 45, 142, 73, 49, 158, 154, 181, 64, 99, 227, 26, 216, 79, 80, 240, 209, 74, 0, 71, 182, 128, 184, 23, 207, 136, 105, 47, 50, 122, 67, 78, 39, 124, 178, 19 }, new byte[] { 10, 7, 102, 234, 22, 210, 29, 156, 82, 95, 102, 89, 180, 28, 190, 48, 66, 24, 9, 25, 98, 219, 138, 255, 44, 154, 60, 218, 228, 117, 157, 186, 194, 63, 169, 168, 225, 90, 135, 196, 95, 116, 58, 22, 110, 145, 180, 135, 207, 184, 46, 6, 47, 23, 186, 149, 123, 33, 14, 97, 193, 176, 5, 6, 171, 3, 174, 118, 239, 130, 147, 111, 212, 34, 139, 180, 66, 123, 181, 2, 80, 192, 152, 237, 139, 139, 139, 79, 147, 117, 214, 5, 57, 235, 69, 241, 125, 36, 65, 226, 29, 147, 124, 26, 43, 235, 190, 230, 4, 169, 7, 161, 143, 150, 208, 227, 231, 90, 136, 48, 95, 81, 139, 235, 22, 52, 12, 137 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 16, 102, 101, 105, 40, 158, 175, 226, 84, 198, 37, 233, 104, 167, 3, 110, 253, 139, 252, 140, 44, 104, 35, 36, 243, 91, 51, 105, 45, 142, 73, 49, 158, 154, 181, 64, 99, 227, 26, 216, 79, 80, 240, 209, 74, 0, 71, 182, 128, 184, 23, 207, 136, 105, 47, 50, 122, 67, 78, 39, 124, 178, 19 }, new byte[] { 10, 7, 102, 234, 22, 210, 29, 156, 82, 95, 102, 89, 180, 28, 190, 48, 66, 24, 9, 25, 98, 219, 138, 255, 44, 154, 60, 218, 228, 117, 157, 186, 194, 63, 169, 168, 225, 90, 135, 196, 95, 116, 58, 22, 110, 145, 180, 135, 207, 184, 46, 6, 47, 23, 186, 149, 123, 33, 14, 97, 193, 176, 5, 6, 171, 3, 174, 118, 239, 130, 147, 111, 212, 34, 139, 180, 66, 123, 181, 2, 80, 192, 152, 237, 139, 139, 139, 79, 147, 117, 214, 5, 57, 235, 69, 241, 125, 36, 65, 226, 29, 147, 124, 26, 43, 235, 190, 230, 4, 169, 7, 161, 143, 150, 208, 227, 231, 90, 136, 48, 95, 81, 139, 235, 22, 52, 12, 137 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 16, 102, 101, 105, 40, 158, 175, 226, 84, 198, 37, 233, 104, 167, 3, 110, 253, 139, 252, 140, 44, 104, 35, 36, 243, 91, 51, 105, 45, 142, 73, 49, 158, 154, 181, 64, 99, 227, 26, 216, 79, 80, 240, 209, 74, 0, 71, 182, 128, 184, 23, 207, 136, 105, 47, 50, 122, 67, 78, 39, 124, 178, 19 }, new byte[] { 10, 7, 102, 234, 22, 210, 29, 156, 82, 95, 102, 89, 180, 28, 190, 48, 66, 24, 9, 25, 98, 219, 138, 255, 44, 154, 60, 218, 228, 117, 157, 186, 194, 63, 169, 168, 225, 90, 135, 196, 95, 116, 58, 22, 110, 145, 180, 135, 207, 184, 46, 6, 47, 23, 186, 149, 123, 33, 14, 97, 193, 176, 5, 6, 171, 3, 174, 118, 239, 130, 147, 111, 212, 34, 139, 180, 66, 123, 181, 2, 80, 192, 152, 237, 139, 139, 139, 79, 147, 117, 214, 5, 57, 235, 69, 241, 125, 36, 65, 226, 29, 147, 124, 26, 43, 235, 190, 230, 4, 169, 7, 161, 143, 150, 208, 227, 231, 90, 136, 48, 95, 81, 139, 235, 22, 52, 12, 137 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("11b5e0dd-8699-4432-b216-bd2799408716"), "Truck", "KCZ 595L" },
                    { new Guid("526365ca-b37a-4b43-b1b8-876b2055e028"), "Truck", "KCY 067A" },
                    { new Guid("79b2a1b1-29fd-444c-8540-fbba94f8e330"), "Truck", "KDL 085M" },
                    { new Guid("826b498f-94af-423f-afcb-f5d5edc146ec"), "Van", "KBF 462A" },
                    { new Guid("8dbb49a8-4f67-4480-8339-451de202fe32"), "Van", "KAY 215H" },
                    { new Guid("d17f4e37-01ed-4956-80fe-e50121a15e9e"), "Truck", "KDB 387Q" },
                    { new Guid("f4ab06a0-a204-4d3b-b15e-ed01418e7943"), "Truck", "KDE 228S" }
                });
        }
    }
}
