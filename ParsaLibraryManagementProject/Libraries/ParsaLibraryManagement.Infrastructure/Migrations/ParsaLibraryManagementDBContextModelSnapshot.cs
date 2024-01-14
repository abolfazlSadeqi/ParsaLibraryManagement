﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParsaLibraryManagement.Infrastructure.Data.Contexts;

#nullable disable

namespace ParsaLibraryManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ParsaLibraryManagementDBContext))]
    partial class ParsaLibraryManagementDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("CategoryId")
                        .HasColumnType("smallint");

                    b.Property<short>("CountInStock")
                        .HasColumnType("smallint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAddress")
                        .IsRequired()
                        .HasMaxLength(37)
                        .IsUnicode(false)
                        .HasColumnType("varchar(37)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<short>("PageCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 0)");

                    b.Property<short>("PublisherId")
                        .HasColumnType("smallint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasComment("- Available  -NotAvailable");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.BooksCategory", b =>
                {
                    b.Property<short>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("CategoryId"));

                    b.Property<string>("ImageAddress")
                        .IsRequired()
                        .HasMaxLength(37)
                        .IsUnicode(false)
                        .HasColumnType("varchar(37)");

                    b.Property<short?>("RefId")
                        .HasColumnType("smallint")
                        .HasComment("If it is null then it will be a SuperGroup, but if it is not Null then it will be a SubGroup.");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("BooksCategories");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.BorrowedBook", b =>
                {
                    b.Property<int>("Bid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Bid"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBorrowed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Bid");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BorrowedBooks");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.Gender", b =>
                {
                    b.Property<short>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("GenderId"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.Publisher", b =>
                {
                    b.Property<short>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("PublisherId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<short>("GenderId")
                        .HasColumnType("smallint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasComment("This is only for Iranian phone numbers - This field is null for foreign users.");

                    b.HasKey("PublisherId");

                    b.HasIndex("GenderId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<short>("GenderId")
                        .HasColumnType("smallint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasComment("This is only for Iranian phone numbers - This field is null for foreign users.");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("UserId");

                    b.HasIndex("GenderId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.Books", b =>
                {
                    b.HasOne("ParsaLibraryManagement.Domain.Entities.BooksCategory", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Books_BooksCategories");

                    b.HasOne("ParsaLibraryManagement.Domain.Entities.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .IsRequired()
                        .HasConstraintName("FK_Books_Publishers");

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.BorrowedBook", b =>
                {
                    b.HasOne("ParsaLibraryManagement.Domain.Entities.Books", "Books")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK_BorrowedBooks_Books");

                    b.HasOne("ParsaLibraryManagement.Domain.Entities.User", "User")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_BorrowedBooks_Users");

                    b.Navigation("Books");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.Publisher", b =>
                {
                    b.HasOne("ParsaLibraryManagement.Domain.Entities.Gender", "Gender")
                        .WithMany("Publishers")
                        .HasForeignKey("GenderId")
                        .IsRequired()
                        .HasConstraintName("FK_Publishers_Genders");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.User", b =>
                {
                    b.HasOne("ParsaLibraryManagement.Domain.Entities.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .IsRequired()
                        .HasConstraintName("FK_Users_Genders");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.Books", b =>
                {
                    b.Navigation("BorrowedBooks");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.BooksCategory", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.Gender", b =>
                {
                    b.Navigation("Publishers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("ParsaLibraryManagement.Domain.Entities.User", b =>
                {
                    b.Navigation("BorrowedBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
