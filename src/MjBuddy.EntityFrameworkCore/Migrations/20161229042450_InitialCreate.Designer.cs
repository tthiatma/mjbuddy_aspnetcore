using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MjBuddy.EntityFrameworkCore;

namespace MjBuddy.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(MjBuddyDbContext))]
    [Migration("20161229042450_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.Account.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long?>("SettingId");

                    b.HasKey("Id");

                    b.HasIndex("SettingId");

                    b.ToTable("AppGames");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.GameRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentWind");

                    b.Property<bool>("HaltMove");

                    b.Property<long?>("LastTileId");

                    b.Property<long?>("Player1Id");

                    b.Property<long?>("Player2Id");

                    b.Property<long?>("Player3Id");

                    b.Property<long?>("Player4Id");

                    b.Property<string>("PlayerTurn");

                    b.Property<int>("TilesLeft");

                    b.HasKey("Id");

                    b.HasIndex("LastTileId");

                    b.HasIndex("Player1Id");

                    b.HasIndex("Player2Id");

                    b.HasIndex("Player3Id");

                    b.HasIndex("Player4Id");

                    b.ToTable("AppGameRecords");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.GameSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("GameId");

                    b.Property<long?>("SettingId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("SettingId");

                    b.ToTable("AppGameSettings");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActiveTileCount");

                    b.Property<bool>("CanDoNoFlower");

                    b.Property<bool>("CanPickTile");

                    b.Property<bool>("CanThrowTile");

                    b.Property<int>("CurrentPoint");

                    b.Property<int>("InActiveTileCount");

                    b.Property<bool>("IsPlaying");

                    b.Property<bool>("IsTileAutoSort");

                    b.Property<long>("LeftPlayerId");

                    b.Property<string>("NickName");

                    b.Property<long>("RightPlayerId");

                    b.Property<long>("TopPlayerId");

                    b.Property<string>("UserAccountId");

                    b.Property<int>("Wind");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId");

                    b.ToTable("AppPlayers");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.Setting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("SkipInitialFlowerSwapping");

                    b.Property<int>("TurnCountDownInSecond");

                    b.HasKey("Id");

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.Tile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("ImageSmall");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.ToTable("AppTiles");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.TileGame", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GraveYardCounter");

                    b.Property<string>("Owner");

                    b.Property<long?>("PlayerId");

                    b.Property<long?>("PlayerId1");

                    b.Property<int?>("TileId");

                    b.Property<int>("TileStatus");

                    b.Property<int>("UserHandCounter");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("PlayerId1");

                    b.HasIndex("TileId");

                    b.ToTable("AppTileGames");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MjBuddy.Core.Entities.Account.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MjBuddy.Core.Entities.Account.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MjBuddy.Core.Entities.Account.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.Game", b =>
                {
                    b.HasOne("MjBuddy.Core.Entities.MjGame.Setting", "Setting")
                        .WithMany()
                        .HasForeignKey("SettingId");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.GameRecord", b =>
                {
                    b.HasOne("MjBuddy.Core.Entities.MjGame.TileGame", "LastTile")
                        .WithMany()
                        .HasForeignKey("LastTileId");

                    b.HasOne("MjBuddy.Core.Entities.MjGame.Player", "Player1")
                        .WithMany()
                        .HasForeignKey("Player1Id");

                    b.HasOne("MjBuddy.Core.Entities.MjGame.Player", "Player2")
                        .WithMany()
                        .HasForeignKey("Player2Id");

                    b.HasOne("MjBuddy.Core.Entities.MjGame.Player", "Player3")
                        .WithMany()
                        .HasForeignKey("Player3Id");

                    b.HasOne("MjBuddy.Core.Entities.MjGame.Player", "Player4")
                        .WithMany()
                        .HasForeignKey("Player4Id");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.GameSetting", b =>
                {
                    b.HasOne("MjBuddy.Core.Entities.MjGame.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("MjBuddy.Core.Entities.MjGame.Setting", "Setting")
                        .WithMany()
                        .HasForeignKey("SettingId");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.Player", b =>
                {
                    b.HasOne("MjBuddy.Core.Entities.Account.ApplicationUser", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserAccountId");
                });

            modelBuilder.Entity("MjBuddy.Core.Entities.MjGame.TileGame", b =>
                {
                    b.HasOne("MjBuddy.Core.Entities.MjGame.Player")
                        .WithMany("ActiveTiles")
                        .HasForeignKey("PlayerId");

                    b.HasOne("MjBuddy.Core.Entities.MjGame.Player")
                        .WithMany("InActiveTiles")
                        .HasForeignKey("PlayerId1");

                    b.HasOne("MjBuddy.Core.Entities.MjGame.Tile", "Tile")
                        .WithMany()
                        .HasForeignKey("TileId");
                });
        }
    }
}
