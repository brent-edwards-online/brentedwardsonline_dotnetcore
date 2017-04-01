using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BrentEdwardsOnlineDotNetCore.Entities;

namespace BrentEdwardsOnlineDotNetCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170401021935_QualificationMigration")]
    partial class QualificationMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrentEdwardsOnlineDotNetCore.Entities.Qualification", b =>
                {
                    b.Property<int>("QualificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CertificateUrl");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<string>("QualificationGroup");

                    b.Property<int>("QualificationProviderId");

                    b.Property<int>("SortOrder");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("QualificationId");

                    b.HasIndex("QualificationProviderId");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("BrentEdwardsOnlineDotNetCore.Entities.QualificationProvider", b =>
                {
                    b.Property<int>("QualificationProviderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("QualificationProviderImageUrl");

                    b.Property<string>("QualificationProviderName");

                    b.Property<string>("QualificationProviderUrl");

                    b.HasKey("QualificationProviderId");

                    b.ToTable("QualificationProviders");
                });

            modelBuilder.Entity("BrentEdwardsOnlineDotNetCore.Entities.Qualification", b =>
                {
                    b.HasOne("BrentEdwardsOnlineDotNetCore.Entities.QualificationProvider", "Provider")
                        .WithMany("Qualifications")
                        .HasForeignKey("QualificationProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
