﻿// <auto-generated />
using System;
using Dream_Bridge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dream_Bridge.Migrations
{
    [DbContext(typeof(DreambrightContext))]
    [Migration("20240919173039_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dream_Bridge.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("admin_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("full_name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("role");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("AdminId")
                        .HasName("PK__admin__43AA4141467AED95");

                    b.HasIndex(new[] { "Email" }, "UQ__admin__AB6E616498076E62")
                        .IsUnique();

                    b.ToTable("admin", null, t =>
                        {
                            t.HasTrigger("trg_UpdateAdmin");
                        });

                    b.HasAnnotation("SqlServer:UseSqlOutputClause", false);
                });

            modelBuilder.Entity("Dream_Bridge.Models.Consultation", b =>
                {
                    b.Property<int>("ConsultationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("consultation_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsultationId"));

                    b.Property<DateOnly?>("ConsultationDate")
                        .HasColumnType("date")
                        .HasColumnName("consultation_date");

                    b.Property<string>("ConsultationType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("consultation_type");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<string>("Notes")
                        .HasColumnType("text")
                        .HasColumnName("notes");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("student_id");

                    b.HasKey("ConsultationId")
                        .HasName("PK__consulta__650FE0FB83277122");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("StudentId");

                    b.ToTable("consultations", (string)null);
                });

            modelBuilder.Entity("Dream_Bridge.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("contact_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("full_name");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("message");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("student_id");

                    b.Property<DateTime?>("SubmittedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("submitted_at")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("ContactId")
                        .HasName("PK__contacts__024E7A8637DE8559");

                    b.HasIndex("StudentId");

                    b.ToTable("contacts", (string)null);
                });

            modelBuilder.Entity("Dream_Bridge.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("country_name");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.HasKey("CountryId")
                        .HasName("PK__countrie__7E8CD055B5ED544E");

                    b.ToTable("countries", (string)null);
                });

            modelBuilder.Entity("Dream_Bridge.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("full_name");

                    b.Property<DateOnly?>("HireDate")
                        .HasColumnType("date")
                        .HasColumnName("hire_date");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("position");

                    b.HasKey("EmployeeId")
                        .HasName("PK__employee__C52E0BA8886FEE9A");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("Dream_Bridge.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("school_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolId"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("address");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("school_name");

                    b.Property<string>("Website")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("website");

                    b.HasKey("SchoolId")
                        .HasName("PK__schools__27CA6CF4AAF2F826");

                    b.HasIndex("CountryId");

                    b.ToTable("schools", (string)null);
                });

            modelBuilder.Entity("Dream_Bridge.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("student_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("address");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("full_name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("phone_number");

                    b.HasKey("StudentId")
                        .HasName("PK__students__2A33069AD38804B1");

                    b.HasIndex("CountryId");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("Dream_Bridge.Models.Testimonial", b =>
                {
                    b.Property<int>("TestimonialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("testimonial_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestimonialId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("student_id");

                    b.HasKey("TestimonialId")
                        .HasName("PK__testimon__2E3B190CDD7FED37");

                    b.HasIndex("StudentId");

                    b.ToTable("testimonials", (string)null);
                });

            modelBuilder.Entity("Dream_Bridge.Models.Consultation", b =>
                {
                    b.HasOne("Dream_Bridge.Models.Employee", "Employee")
                        .WithMany("Consultations")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK__consultat__emplo__45F365D3");

                    b.HasOne("Dream_Bridge.Models.Student", "Student")
                        .WithMany("Consultations")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__consultat__stude__44FF419A");

                    b.Navigation("Employee");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Dream_Bridge.Models.Contact", b =>
                {
                    b.HasOne("Dream_Bridge.Models.Student", "Student")
                        .WithMany("Contacts")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__contacts__studen__5BE2A6F2");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Dream_Bridge.Models.School", b =>
                {
                    b.HasOne("Dream_Bridge.Models.Country", "Country")
                        .WithMany("Schools")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK__schools__country__4222D4EF");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Dream_Bridge.Models.Student", b =>
                {
                    b.HasOne("Dream_Bridge.Models.Country", "Country")
                        .WithMany("Students")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK__students__countr__3C69FB99");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Dream_Bridge.Models.Testimonial", b =>
                {
                    b.HasOne("Dream_Bridge.Models.Student", "Student")
                        .WithMany("Testimonials")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__testimoni__stude__4AB81AF0");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Dream_Bridge.Models.Country", b =>
                {
                    b.Navigation("Schools");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Dream_Bridge.Models.Employee", b =>
                {
                    b.Navigation("Consultations");
                });

            modelBuilder.Entity("Dream_Bridge.Models.Student", b =>
                {
                    b.Navigation("Consultations");

                    b.Navigation("Contacts");

                    b.Navigation("Testimonials");
                });
#pragma warning restore 612, 618
        }
    }
}
