﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using wms_android.data.Data;

#nullable disable

namespace wms_android.data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241223003223_SmsConfigutrationsDetails")]
    partial class SmsConfigutrationsDetails
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("wms_android.data.Models.Drivers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9eef5061-b2f0-4521-9ae9-b9bbad636417"),
                            FirstName = "John",
                            Initials = "JN",
                            LastName = "Njuguna",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("fa7047a7-d08e-4981-ab05-23c2c3cdbbc4"),
                            FirstName = "Robert",
                            Initials = "RN",
                            LastName = "Njuguna",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("a250e5ef-48f9-4946-9fad-d087fae9898d"),
                            FirstName = "John",
                            Initials = "JM",
                            LastName = "Mwai",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("cf03f065-0d2a-45d3-b501-229572977b9a"),
                            FirstName = "David",
                            Initials = "DM",
                            LastName = "Mwangi",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("cca00b71-1068-4992-b23a-29c953e6bee6"),
                            FirstName = "David",
                            Initials = "DK",
                            LastName = "Kibet",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("72fa8a8b-0ea4-4b30-93ff-3f6b41dfb17a"),
                            FirstName = "Erastus",
                            Initials = "EK",
                            LastName = "Kagwa",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("063c3fb1-a9d5-42fd-adbd-2e0ea69b79dc"),
                            FirstName = "Julius",
                            Initials = "JK",
                            LastName = "Kamula",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("1f49db4d-19ec-49ea-859e-06ae058a5ab8"),
                            FirstName = "Stephen",
                            Initials = "SK",
                            LastName = "Kimuyu",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("1de7cd61-d2e9-4876-a9f6-ba5be3f1a917"),
                            FirstName = "Charles",
                            Initials = "SK",
                            LastName = "Maina",
                            LicenseNumber = "DL123456"
                        },
                        new
                        {
                            Id = new Guid("353c139f-d796-466a-a63d-130d8cbac759"),
                            FirstName = "James",
                            Initials = "SK",
                            LastName = "Gichohi",
                            LicenseNumber = "DL123456"
                        });
                });

            modelBuilder.Entity("wms_android.data.Models.Parcel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DispatchTrackingCode")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DispatchedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PaymentMethods")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("Rate")
                        .HasColumnType("numeric");

                    b.Property<string>("Receiver")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverTelephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SenderTelephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalRate")
                        .HasColumnType("numeric");

                    b.Property<string>("WaybillNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Parcels");
                });

            modelBuilder.Entity("wms_android.data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Administrator",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Manager",
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Regular User",
                            Name = "Clerk"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Client User",
                            Name = "Client"
                        });
                });

            modelBuilder.Entity("wms_android.data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "admin@example.com",
                            Password = "admin123",
                            PasswordHash = new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 },
                            PasswordSalt = new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 },
                            RoleId = 1,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "manager@example.com",
                            Password = "manager123",
                            PasswordHash = new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 },
                            PasswordSalt = new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 },
                            RoleId = 2,
                            Username = "manager"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "clerk1@example.com",
                            Password = "clerk123",
                            PasswordHash = new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 },
                            PasswordSalt = new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 },
                            RoleId = 3,
                            Username = "clerk1"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "clerk2@example.com",
                            Password = "clerk123",
                            PasswordHash = new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 },
                            PasswordSalt = new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 },
                            RoleId = 3,
                            Username = "clerk2"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Email = "client1@example.com",
                            Password = "client123",
                            PasswordHash = new byte[] { 105, 60, 84, 193, 42, 245, 158, 244, 249, 68, 112, 61, 54, 82, 153, 221, 178, 33, 31, 135, 43, 58, 14, 41, 17, 119, 111, 233, 143, 128, 195, 254, 82, 247, 66, 185, 86, 132, 236, 9, 104, 149, 237, 97, 190, 148, 32, 92, 93, 167, 33, 119, 6, 111, 55, 207, 24, 147, 229, 198, 216, 128, 130, 207 },
                            PasswordSalt = new byte[] { 209, 46, 215, 59, 70, 185, 97, 153, 29, 96, 30, 26, 35, 102, 134, 247, 245, 173, 14, 215, 75, 112, 69, 75, 65, 213, 129, 155, 198, 152, 253, 236, 198, 69, 138, 212, 201, 102, 103, 253, 240, 160, 181, 39, 0, 240, 151, 171, 100, 133, 100, 102, 142, 8, 128, 227, 38, 44, 93, 195, 159, 172, 25, 213, 16, 81, 173, 221, 51, 25, 8, 92, 172, 17, 235, 220, 172, 148, 234, 162, 104, 171, 1, 99, 250, 73, 192, 123, 62, 59, 70, 115, 213, 160, 155, 190, 6, 195, 110, 148, 160, 22, 29, 197, 11, 156, 30, 42, 135, 212, 194, 151, 0, 74, 88, 243, 215, 22, 202, 46, 79, 25, 4, 209, 80, 89, 214, 90 },
                            RoleId = 4,
                            Username = "client1"
                        });
                });

            modelBuilder.Entity("wms_android.data.Models.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VehicleRegistrationNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c0ea063a-3290-44a4-9c23-c7b34067cd66"),
                            BodyType = "Truck",
                            VehicleRegistrationNumber = "KDL 085M"
                        },
                        new
                        {
                            Id = new Guid("b4bd30f6-ff32-4a54-99ba-e554ca9192b8"),
                            BodyType = "Truck",
                            VehicleRegistrationNumber = "KCY 067A"
                        },
                        new
                        {
                            Id = new Guid("50490d62-f841-43d7-82e5-6b03a6ff36d9"),
                            BodyType = "Truck",
                            VehicleRegistrationNumber = "KCZ 595L"
                        },
                        new
                        {
                            Id = new Guid("a4a343e5-f7f7-4b17-a5e9-0d114417cc5b"),
                            BodyType = "Truck",
                            VehicleRegistrationNumber = "KDB 387Q"
                        },
                        new
                        {
                            Id = new Guid("9e63e7ab-7a1b-42dc-bf90-d09575293cb7"),
                            BodyType = "Truck",
                            VehicleRegistrationNumber = "KDE 228S"
                        },
                        new
                        {
                            Id = new Guid("e88786f2-9116-4280-ab95-318a75f18c13"),
                            BodyType = "Van",
                            VehicleRegistrationNumber = "KAY 215H"
                        },
                        new
                        {
                            Id = new Guid("80c5b6ba-6ab6-47d3-8038-cc609aa404b5"),
                            BodyType = "Van",
                            VehicleRegistrationNumber = "KBF 462A"
                        });
                });

            modelBuilder.Entity("wms_android.data.Models.User", b =>
                {
                    b.HasOne("wms_android.data.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}