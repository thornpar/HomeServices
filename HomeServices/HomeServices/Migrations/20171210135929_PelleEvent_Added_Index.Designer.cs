﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using netcore.Models;
using System;

namespace HomeServices.Migrations
{
    [DbContext(typeof(PelleEventContext))]
    [Migration("20171210135929_PelleEvent_Added_Index")]
    partial class PelleEvent_Added_Index
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("netcore.Models.PelleEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.ToTable("PelleEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
