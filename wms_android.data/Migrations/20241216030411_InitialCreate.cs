using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wms_android.data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    { new Guid("07b40d8d-5b84-4365-aeb2-72f033cc2eb3"), "Stephen", "SK", "Kimuyu", "DL123456" },
                    { new Guid("14095293-1189-4e88-b018-bb3a4cf382de"), "Robert", "RN", "Njuguna", "DL123456" },
                    { new Guid("1af35b07-6e2a-43a6-be20-56ca5b0396fe"), "David", "DK", "Kibet", "DL123456" },
                    { new Guid("3dad3867-d0e4-4532-835b-f18161c0efd6"), "Charles", "SK", "Maina", "DL123456" },
                    { new Guid("41f27fb1-e341-491b-a70c-73f26b55223f"), "Julius", "JK", "Kamula", "DL123456" },
                    { new Guid("5131d676-47cc-479b-9f4d-aadd65f32501"), "Erastus", "EK", "Kagwa", "DL123456" },
                    { new Guid("7859e4a0-9ec4-43c1-95be-33a28156d129"), "John", "JM", "Mwai", "DL123456" },
                    { new Guid("940948c2-2591-4094-93d0-d9a3a3c89820"), "James", "SK", "Gichohi", "DL123456" },
                    { new Guid("a368177a-1e28-41fe-9c76-7516cb4cdc4a"), "John", "JN", "Njuguna", "DL123456" },
                    { new Guid("e2e48262-46da-463f-8ae3-00a10b95f58f"), "David", "DM", "Mwangi", "DL123456" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 255, 159, 96, 88, 199, 214, 9, 132, 118, 127, 30, 161, 11, 246, 133, 234, 34, 211, 73, 96, 136, 23, 201, 95, 50, 218, 251, 117, 46, 125, 226, 107, 80, 95, 90, 227, 170, 69, 5, 0, 214, 187, 63, 141, 208, 117, 21, 142, 123, 135, 223, 69, 184, 142, 124, 67, 111, 201, 25, 3, 188, 182, 149 }, new byte[] { 222, 160, 245, 218, 72, 237, 145, 87, 252, 59, 38, 195, 109, 16, 72, 199, 167, 150, 232, 71, 189, 180, 63, 94, 149, 144, 231, 177, 18, 127, 57, 59, 225, 7, 131, 46, 105, 132, 115, 85, 129, 125, 227, 116, 102, 79, 109, 10, 225, 157, 115, 43, 144, 76, 188, 38, 212, 26, 234, 249, 209, 194, 210, 109, 55, 214, 25, 186, 50, 13, 138, 111, 201, 97, 114, 188, 84, 185, 105, 234, 216, 250, 99, 54, 65, 68, 123, 191, 130, 119, 30, 79, 239, 155, 59, 58, 250, 119, 64, 24, 253, 24, 174, 231, 199, 139, 67, 146, 107, 60, 189, 147, 214, 221, 208, 61, 134, 207, 236, 129, 3, 168, 141, 209, 188, 93, 118, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 255, 159, 96, 88, 199, 214, 9, 132, 118, 127, 30, 161, 11, 246, 133, 234, 34, 211, 73, 96, 136, 23, 201, 95, 50, 218, 251, 117, 46, 125, 226, 107, 80, 95, 90, 227, 170, 69, 5, 0, 214, 187, 63, 141, 208, 117, 21, 142, 123, 135, 223, 69, 184, 142, 124, 67, 111, 201, 25, 3, 188, 182, 149 }, new byte[] { 222, 160, 245, 218, 72, 237, 145, 87, 252, 59, 38, 195, 109, 16, 72, 199, 167, 150, 232, 71, 189, 180, 63, 94, 149, 144, 231, 177, 18, 127, 57, 59, 225, 7, 131, 46, 105, 132, 115, 85, 129, 125, 227, 116, 102, 79, 109, 10, 225, 157, 115, 43, 144, 76, 188, 38, 212, 26, 234, 249, 209, 194, 210, 109, 55, 214, 25, 186, 50, 13, 138, 111, 201, 97, 114, 188, 84, 185, 105, 234, 216, 250, 99, 54, 65, 68, 123, 191, 130, 119, 30, 79, 239, 155, 59, 58, 250, 119, 64, 24, 253, 24, 174, 231, 199, 139, 67, 146, 107, 60, 189, 147, 214, 221, 208, 61, 134, 207, 236, 129, 3, 168, 141, 209, 188, 93, 118, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 255, 159, 96, 88, 199, 214, 9, 132, 118, 127, 30, 161, 11, 246, 133, 234, 34, 211, 73, 96, 136, 23, 201, 95, 50, 218, 251, 117, 46, 125, 226, 107, 80, 95, 90, 227, 170, 69, 5, 0, 214, 187, 63, 141, 208, 117, 21, 142, 123, 135, 223, 69, 184, 142, 124, 67, 111, 201, 25, 3, 188, 182, 149 }, new byte[] { 222, 160, 245, 218, 72, 237, 145, 87, 252, 59, 38, 195, 109, 16, 72, 199, 167, 150, 232, 71, 189, 180, 63, 94, 149, 144, 231, 177, 18, 127, 57, 59, 225, 7, 131, 46, 105, 132, 115, 85, 129, 125, 227, 116, 102, 79, 109, 10, 225, 157, 115, 43, 144, 76, 188, 38, 212, 26, 234, 249, 209, 194, 210, 109, 55, 214, 25, 186, 50, 13, 138, 111, 201, 97, 114, 188, 84, 185, 105, 234, 216, 250, 99, 54, 65, 68, 123, 191, 130, 119, 30, 79, 239, 155, 59, 58, 250, 119, 64, 24, 253, 24, 174, 231, 199, 139, 67, 146, 107, 60, 189, 147, 214, 221, 208, 61, 134, 207, 236, 129, 3, 168, 141, 209, 188, 93, 118, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 255, 159, 96, 88, 199, 214, 9, 132, 118, 127, 30, 161, 11, 246, 133, 234, 34, 211, 73, 96, 136, 23, 201, 95, 50, 218, 251, 117, 46, 125, 226, 107, 80, 95, 90, 227, 170, 69, 5, 0, 214, 187, 63, 141, 208, 117, 21, 142, 123, 135, 223, 69, 184, 142, 124, 67, 111, 201, 25, 3, 188, 182, 149 }, new byte[] { 222, 160, 245, 218, 72, 237, 145, 87, 252, 59, 38, 195, 109, 16, 72, 199, 167, 150, 232, 71, 189, 180, 63, 94, 149, 144, 231, 177, 18, 127, 57, 59, 225, 7, 131, 46, 105, 132, 115, 85, 129, 125, 227, 116, 102, 79, 109, 10, 225, 157, 115, 43, 144, 76, 188, 38, 212, 26, 234, 249, 209, 194, 210, 109, 55, 214, 25, 186, 50, 13, 138, 111, 201, 97, 114, 188, 84, 185, 105, 234, 216, 250, 99, 54, 65, 68, 123, 191, 130, 119, 30, 79, 239, 155, 59, 58, 250, 119, 64, 24, 253, 24, 174, 231, 199, 139, 67, 146, 107, 60, 189, 147, 214, 221, 208, 61, 134, 207, 236, 129, 3, 168, 141, 209, 188, 93, 118, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 255, 159, 96, 88, 199, 214, 9, 132, 118, 127, 30, 161, 11, 246, 133, 234, 34, 211, 73, 96, 136, 23, 201, 95, 50, 218, 251, 117, 46, 125, 226, 107, 80, 95, 90, 227, 170, 69, 5, 0, 214, 187, 63, 141, 208, 117, 21, 142, 123, 135, 223, 69, 184, 142, 124, 67, 111, 201, 25, 3, 188, 182, 149 }, new byte[] { 222, 160, 245, 218, 72, 237, 145, 87, 252, 59, 38, 195, 109, 16, 72, 199, 167, 150, 232, 71, 189, 180, 63, 94, 149, 144, 231, 177, 18, 127, 57, 59, 225, 7, 131, 46, 105, 132, 115, 85, 129, 125, 227, 116, 102, 79, 109, 10, 225, 157, 115, 43, 144, 76, 188, 38, 212, 26, 234, 249, 209, 194, 210, 109, 55, 214, 25, 186, 50, 13, 138, 111, 201, 97, 114, 188, 84, 185, 105, 234, 216, 250, 99, 54, 65, 68, 123, 191, 130, 119, 30, 79, 239, 155, 59, 58, 250, 119, 64, 24, 253, 24, 174, 231, 199, 139, 67, 146, 107, 60, 189, 147, 214, 221, 208, 61, 134, 207, 236, 129, 3, 168, 141, 209, 188, 93, 118, 180 } });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BodyType", "VehicleRegistrationNumber" },
                values: new object[,]
                {
                    { new Guid("0de54a86-2585-41ad-823b-889f69a98c61"), "Truck", "KDL 085M" },
                    { new Guid("5b0b3cb3-f778-4a34-82fe-a8857d188724"), "Van", "KBF 462A" },
                    { new Guid("87f19bcc-b830-4e27-b616-eb6543ac3eac"), "Truck", "KDB 387Q" },
                    { new Guid("94582076-4dad-4c50-8e8d-84e220142e87"), "Truck", "KDE 228S" },
                    { new Guid("bf8b6d86-53b0-47c3-b3e6-1c81d84e5834"), "Van", "KAY 215H" },
                    { new Guid("c429e52c-cdfb-40be-8343-1b4c1588a468"), "Truck", "KCY 067A" },
                    { new Guid("db52f6d4-b762-4d72-9eba-de293e6d320d"), "Truck", "KCZ 595L" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("07b40d8d-5b84-4365-aeb2-72f033cc2eb3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("14095293-1189-4e88-b018-bb3a4cf382de"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1af35b07-6e2a-43a6-be20-56ca5b0396fe"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("3dad3867-d0e4-4532-835b-f18161c0efd6"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("41f27fb1-e341-491b-a70c-73f26b55223f"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5131d676-47cc-479b-9f4d-aadd65f32501"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7859e4a0-9ec4-43c1-95be-33a28156d129"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("940948c2-2591-4094-93d0-d9a3a3c89820"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("a368177a-1e28-41fe-9c76-7516cb4cdc4a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("e2e48262-46da-463f-8ae3-00a10b95f58f"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0de54a86-2585-41ad-823b-889f69a98c61"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5b0b3cb3-f778-4a34-82fe-a8857d188724"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("87f19bcc-b830-4e27-b616-eb6543ac3eac"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("94582076-4dad-4c50-8e8d-84e220142e87"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bf8b6d86-53b0-47c3-b3e6-1c81d84e5834"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c429e52c-cdfb-40be-8343-1b4c1588a468"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("db52f6d4-b762-4d72-9eba-de293e6d320d"));

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
