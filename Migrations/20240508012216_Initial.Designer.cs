﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using too_many_params.Infra;

#nullable disable

namespace too_many_params.Migrations
{
    [DbContext(typeof(ParamsDbContext))]
    [Migration("20240508012216_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("too_many_params.Domain.Contract", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contracts", (string)null);
                });

            modelBuilder.Entity("too_many_params.Domain.Contract", b =>
                {
                    b.OwnsOne("too_many_params.Domain.ContractDetails", "Details", b1 =>
                        {
                            b1.Property<int>("ContractId")
                                .HasColumnType("int");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("decimal(65,30)")
                                .HasColumnName("Amount");

                            b1.Property<string>("ClientName")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("ClientName");

                            b1.Property<string>("ContractNumber")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("ContractNumber");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("Description");

                            b1.Property<DateTime>("EndDate")
                                .HasColumnType("datetime(6)")
                                .HasColumnName("EndDate");

                            b1.Property<DateTime>("StartDate")
                                .HasColumnType("datetime(6)")
                                .HasColumnName("StartDate");

                            b1.HasKey("ContractId");

                            b1.ToTable("Contracts", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ContractId");
                        });

                    b.OwnsOne("too_many_params.Domain.ContractStatus", "Status", b1 =>
                        {
                            b1.Property<int>("ContractId")
                                .HasColumnType("int");

                            b1.Property<bool>("IsActive")
                                .HasColumnType("tinyint(1)")
                                .HasColumnName("IsActive");

                            b1.Property<bool>("IsApproved")
                                .HasColumnType("tinyint(1)")
                                .HasColumnName("IsApproved");

                            b1.Property<bool>("IsCancelled")
                                .HasColumnType("tinyint(1)")
                                .HasColumnName("IsCancelled");

                            b1.Property<bool>("IsSigned")
                                .HasColumnType("tinyint(1)")
                                .HasColumnName("IsSigned");

                            b1.HasKey("ContractId");

                            b1.ToTable("Contracts", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ContractId");
                        });

                    b.Navigation("Details")
                        .IsRequired();

                    b.Navigation("Status")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
