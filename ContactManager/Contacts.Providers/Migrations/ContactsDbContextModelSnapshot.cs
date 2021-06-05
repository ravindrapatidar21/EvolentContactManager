﻿// <auto-generated />
using System;
using ContactManager.Providers.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactManager.Providers.Migrations
{
    [DbContext(typeof(ContactsDbContext))]
    partial class ContactsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactManager.Entities.ContactEmails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<int?>("ContactsId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ContactsId");

                    b.ToTable("ContactEmails");
                });

            modelBuilder.Entity("ContactManager.Entities.ContactPhones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<int?>("ContactsId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContactsId");

                    b.ToTable("ContactPhones");
                });

            modelBuilder.Entity("ContactManager.Entities.Contacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ContactManager.Entities.ContactEmails", b =>
                {
                    b.HasOne("ContactManager.Entities.Contacts", null)
                        .WithMany("EmailAddresses")
                        .HasForeignKey("ContactsId");
                });

            modelBuilder.Entity("ContactManager.Entities.ContactPhones", b =>
                {
                    b.HasOne("ContactManager.Entities.Contacts", null)
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("ContactsId");
                });

            modelBuilder.Entity("ContactManager.Entities.Contacts", b =>
                {
                    b.Navigation("EmailAddresses");

                    b.Navigation("PhoneNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}