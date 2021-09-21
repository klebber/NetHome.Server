﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetHomeServer.Data;

namespace NetHomeServer.Data.Migrations
{
    [DbContext(typeof(NetHomeContext))]
    partial class NetHomeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("DeviceUser", b =>
                {
                    b.Property<int>("DevicesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UsersId")
                        .HasColumnType("TEXT");

                    b.HasKey("DevicesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("DeviceUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("DevicePassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceUsername")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IpAdress")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RoomId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("TypeId");

                    b.ToTable("Device");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Device");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.DeviceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeviceType");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<int>("AccessLevel")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Role");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Devices.AirConditioner", b =>
                {
                    b.HasBaseType("NetHomeServer.Data.Entities.Device");

                    b.Property<int>("FanSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ison")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Swing")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Temperature")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TimerSet")
                        .HasColumnType("INTEGER");

                    b.Property<double>("TimerValue")
                        .HasColumnType("REAL");

                    b.HasDiscriminator().HasValue("AirConditioner");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Devices.DWSensor", b =>
                {
                    b.HasBaseType("NetHomeServer.Data.Entities.Device");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("DWSensor");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Devices.RGBLight", b =>
                {
                    b.HasBaseType("NetHomeServer.Data.Entities.Device");

                    b.Property<int>("Blue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Brightness")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Gain")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Green")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ison")
                        .HasColumnType("INTEGER")
                        .HasColumnName("RGBLight_Ison");

                    b.Property<string>("Mode")
                        .HasColumnType("TEXT");

                    b.Property<int>("Red")
                        .HasColumnType("INTEGER");

                    b.Property<int>("White")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("RGBLight");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Devices.RollerShutter", b =>
                {
                    b.HasBaseType("NetHomeServer.Data.Entities.Device");

                    b.Property<int>("Percentage")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("RollerShutter");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Devices.SmartSwitch", b =>
                {
                    b.HasBaseType("NetHomeServer.Data.Entities.Device");

                    b.Property<bool>("Ison")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SmartSwitch_Ison");

                    b.HasDiscriminator().HasValue("SmartSwitch");
                });

            modelBuilder.Entity("DeviceUser", b =>
                {
                    b.HasOne("NetHomeServer.Data.Entities.Device", null)
                        .WithMany()
                        .HasForeignKey("DevicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHomeServer.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NetHomeServer.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NetHomeServer.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetHomeServer.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NetHomeServer.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Device", b =>
                {
                    b.HasOne("NetHomeServer.Data.Entities.Room", "Room")
                        .WithMany("Devices")
                        .HasForeignKey("RoomId");

                    b.HasOne("NetHomeServer.Data.Entities.DeviceType", "Type")
                        .WithMany("Devices")
                        .HasForeignKey("TypeId");

                    b.Navigation("Room");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.DeviceType", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("NetHomeServer.Data.Entities.Room", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
