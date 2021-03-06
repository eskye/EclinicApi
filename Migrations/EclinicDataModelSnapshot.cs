﻿// <auto-generated />
using EClinicApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EClinicApi.Migrations
{
    [DbContext(typeof(EclinicData))]
    partial class EclinicDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EClinicApi.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessLevel");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastLoginTime");

                    b.Property<string>("LastName");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("RoleId");

                    b.Property<string>("RoleName");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
