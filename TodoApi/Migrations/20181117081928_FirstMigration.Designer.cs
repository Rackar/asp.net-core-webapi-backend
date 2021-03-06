﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TodoApi.Models;

namespace TodoApi.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20181117081928_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TodoApi.Models.TodoItem", b =>
                {
                    b.Property<Guid>("Gid")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("DownLoadCount");

                    b.Property<string>("DownloadFileName");

                    b.Property<string>("DownloadFilePath");

                    b.Property<DateTime?>("DownloadTime");

                    b.Property<int>("Status");

                    b.Property<string>("UploadFileName");

                    b.Property<string>("UploadFilePath");

                    b.HasKey("Gid");

                    b.ToTable("TodoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
