﻿// <auto-generated />
using System;
using ADminLteTest.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ADminLteTest.Migrations
{
    [DbContext(typeof(OrgDbContext))]
    [Migration("20221108224620_EditOrgnaizationsApplicationModel_AddRelationships")]
    partial class EditOrgnaizationsApplicationModel_AddRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ADminLteTest.Entites.AccommodationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccommodationType");
                });

            modelBuilder.Entity("ADminLteTest.Entites.Age", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AgeAvarege")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ages");
                });

            modelBuilder.Entity("ADminLteTest.Entites.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ADminLteTest.Entites.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ADminLteTest.Entites.CommunicationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CommunicationType");
                });

            modelBuilder.Entity("ADminLteTest.Entites.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("ADminLteTest.Entites.EconomicLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EconomicLevel");
                });

            modelBuilder.Entity("ADminLteTest.Entites.EducationalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationalStatus");
                });

            modelBuilder.Entity("ADminLteTest.Entites.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegularMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkNatureNo")
                        .HasColumnType("int");

                    b.Property<string>("WorkingFor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("WorkNatureNo");

                    b.ToTable("Expert");
                });

            modelBuilder.Entity("ADminLteTest.Entites.ExpertPublications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExpertNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExpertNo");

                    b.ToTable("ExpertPublications");
                });

            modelBuilder.Entity("ADminLteTest.Entites.ExpertQualifications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Division")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpertNo")
                        .HasColumnType("int");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QualificationsNo")
                        .HasColumnType("int");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExpertNo");

                    b.HasIndex("QualificationsNo");

                    b.ToTable("ExpertQualifications");
                });

            modelBuilder.Entity("ADminLteTest.Entites.ExpertTraining", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExpertNo")
                        .HasColumnType("int");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<string>("TrainingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExpertNo");

                    b.ToTable("ExpertTraining");
                });

            modelBuilder.Entity("ADminLteTest.Entites.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GenderType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("ADminLteTest.Entites.HandicappedCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgeNo")
                        .HasColumnType("int");

                    b.Property<int>("CategoryNo")
                        .HasColumnType("int");

                    b.Property<int>("GenderNo")
                        .HasColumnType("int");

                    b.Property<int>("OrgDetailsNo")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgeNo");

                    b.HasIndex("CategoryNo");

                    b.HasIndex("GenderNo");

                    b.HasIndex("OrgDetailsNo");

                    b.ToTable("HandicappedCategory");
                });

            modelBuilder.Entity("ADminLteTest.Entites.HandicappedInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccommodationTypeNo")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryNo")
                        .HasColumnType("int");

                    b.Property<int>("CityNo")
                        .HasColumnType("int");

                    b.Property<int>("DistrictNo")
                        .HasColumnType("int");

                    b.Property<bool>("DrawAndColoringCapability")
                        .HasColumnType("bit");

                    b.Property<int>("EconomicLevelNo")
                        .HasColumnType("int");

                    b.Property<int>("EducationalStatusNo")
                        .HasColumnType("int");

                    b.Property<int>("FatherEducationalStatusNo")
                        .HasColumnType("int");

                    b.Property<string>("FatherMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderNo")
                        .HasColumnType("int");

                    b.Property<bool>("HafezCapability")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWorking")
                        .HasColumnType("bit");

                    b.Property<bool>("LiteratureCapability")
                        .HasColumnType("bit");

                    b.Property<int>("MotherEducationalStatusNo")
                        .HasColumnType("int");

                    b.Property<string>("MotherMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrgDetailsNo")
                        .HasColumnType("int");

                    b.Property<bool>("SwimmingCapability")
                        .HasColumnType("bit");

                    b.Property<string>("Weaknesses")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkNatureNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccommodationTypeNo");

                    b.HasIndex("CategoryNo");

                    b.HasIndex("CityNo");

                    b.HasIndex("DistrictNo");

                    b.HasIndex("EconomicLevelNo");

                    b.HasIndex("EducationalStatusNo");

                    b.HasIndex("FatherEducationalStatusNo");

                    b.HasIndex("GenderNo");

                    b.HasIndex("MotherEducationalStatusNo");

                    b.HasIndex("OrgDetailsNo");

                    b.HasIndex("WorkNatureNo");

                    b.ToTable("HandicappedInfo");
                });

            modelBuilder.Entity("ADminLteTest.Entites.OrgDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityNo")
                        .HasColumnType("int");

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistrictNo")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FaoundationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrgTypeNo")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityNo");

                    b.HasIndex("DistrictNo");

                    b.HasIndex("OrgTypeNo");

                    b.ToTable("OrgDetails");
                });

            modelBuilder.Entity("ADminLteTest.Entites.OrgnaizationsApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApprochNature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CommunicationTypeNo")
                        .HasColumnType("int");

                    b.Property<string>("IdeasAndRecommondaions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproched")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProgreessed")
                        .HasColumnType("bit");

                    b.Property<int>("OrgDetailsNo")
                        .HasColumnType("int");

                    b.Property<int>("ProgressTypeNo")
                        .HasColumnType("int");

                    b.Property<int>("QualificationPeriod")
                        .HasColumnType("int");

                    b.Property<bool>("ResourcesRoom")
                        .HasColumnType("bit");

                    b.Property<int>("StaffNo")
                        .HasColumnType("int");

                    b.Property<int>("WorkNutureNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommunicationTypeNo");

                    b.HasIndex("OrgDetailsNo");

                    b.HasIndex("ProgressTypeNo");

                    b.HasIndex("StaffNo");

                    b.HasIndex("WorkNutureNo");

                    b.ToTable("OrgnaizationsApplications");
                });

            modelBuilder.Entity("ADminLteTest.Entites.OrgType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrgTypes");
                });

            modelBuilder.Entity("ADminLteTest.Entites.ProgressType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProgressTypes");
                });

            modelBuilder.Entity("ADminLteTest.Entites.Qualifications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsBsc")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMsc")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPhd")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("ADminLteTest.Entites.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("ADminLteTest.Entites.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ADminLteTest.Entites.WorkNature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkNatures");
                });

            modelBuilder.Entity("ADminLteTest.Entites.Expert", b =>
                {
                    b.HasOne("ADminLteTest.Entites.WorkNature", "WorkNature")
                        .WithMany()
                        .HasForeignKey("WorkNatureNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkNature");
                });

            modelBuilder.Entity("ADminLteTest.Entites.ExpertPublications", b =>
                {
                    b.HasOne("ADminLteTest.Entites.Expert", "Expert")
                        .WithMany()
                        .HasForeignKey("ExpertNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expert");
                });

            modelBuilder.Entity("ADminLteTest.Entites.ExpertQualifications", b =>
                {
                    b.HasOne("ADminLteTest.Entites.Expert", "Expert")
                        .WithMany()
                        .HasForeignKey("ExpertNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.Qualifications", "Qualification")
                        .WithMany()
                        .HasForeignKey("QualificationsNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expert");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("ADminLteTest.Entites.ExpertTraining", b =>
                {
                    b.HasOne("ADminLteTest.Entites.Expert", "Expert")
                        .WithMany()
                        .HasForeignKey("ExpertNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expert");
                });

            modelBuilder.Entity("ADminLteTest.Entites.HandicappedCategory", b =>
                {
                    b.HasOne("ADminLteTest.Entites.Age", "Ages")
                        .WithMany()
                        .HasForeignKey("AgeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.Gender", "Genders")
                        .WithMany()
                        .HasForeignKey("GenderNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.OrgDetails", "OrgDetails")
                        .WithMany()
                        .HasForeignKey("OrgDetailsNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ages");

                    b.Navigation("Categories");

                    b.Navigation("Genders");

                    b.Navigation("OrgDetails");
                });

            modelBuilder.Entity("ADminLteTest.Entites.HandicappedInfo", b =>
                {
                    b.HasOne("ADminLteTest.Entites.AccommodationType", "AccommodationTypes")
                        .WithMany()
                        .HasForeignKey("AccommodationTypeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.City", "Cities")
                        .WithMany()
                        .HasForeignKey("CityNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.District", "Districts")
                        .WithMany()
                        .HasForeignKey("DistrictNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.EconomicLevel", "EconomicLevels")
                        .WithMany()
                        .HasForeignKey("EconomicLevelNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.EducationalStatus", "PersonalEducationalStatuses")
                        .WithMany()
                        .HasForeignKey("EducationalStatusNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.EducationalStatus", "FatherEducationalStatuses")
                        .WithMany()
                        .HasForeignKey("FatherEducationalStatusNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.Gender", "Genders")
                        .WithMany()
                        .HasForeignKey("GenderNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.EducationalStatus", "MotherEducationalStatuses")
                        .WithMany()
                        .HasForeignKey("MotherEducationalStatusNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.OrgDetails", "OrgDetails")
                        .WithMany()
                        .HasForeignKey("OrgDetailsNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.WorkNature", "WorkNatures")
                        .WithMany()
                        .HasForeignKey("WorkNatureNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccommodationTypes");

                    b.Navigation("Categories");

                    b.Navigation("Cities");

                    b.Navigation("Districts");

                    b.Navigation("EconomicLevels");

                    b.Navigation("FatherEducationalStatuses");

                    b.Navigation("Genders");

                    b.Navigation("MotherEducationalStatuses");

                    b.Navigation("OrgDetails");

                    b.Navigation("PersonalEducationalStatuses");

                    b.Navigation("WorkNatures");
                });

            modelBuilder.Entity("ADminLteTest.Entites.OrgDetails", b =>
                {
                    b.HasOne("ADminLteTest.Entites.City", "City")
                        .WithMany()
                        .HasForeignKey("CityNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.OrgType", "OrgType")
                        .WithMany()
                        .HasForeignKey("OrgTypeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("District");

                    b.Navigation("OrgType");
                });

            modelBuilder.Entity("ADminLteTest.Entites.OrgnaizationsApplication", b =>
                {
                    b.HasOne("ADminLteTest.Entites.CommunicationType", "CommunicationType")
                        .WithMany()
                        .HasForeignKey("CommunicationTypeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.OrgDetails", "OrgDetails")
                        .WithMany()
                        .HasForeignKey("OrgDetailsNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.ProgressType", "ProgressType")
                        .WithMany()
                        .HasForeignKey("ProgressTypeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADminLteTest.Entites.WorkNature", "WorkNature")
                        .WithMany()
                        .HasForeignKey("WorkNutureNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommunicationType");

                    b.Navigation("OrgDetails");

                    b.Navigation("ProgressType");

                    b.Navigation("Staff");

                    b.Navigation("WorkNature");
                });
#pragma warning restore 612, 618
        }
    }
}
