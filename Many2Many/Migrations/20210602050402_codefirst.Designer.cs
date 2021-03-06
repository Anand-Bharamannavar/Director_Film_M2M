// <auto-generated />
using Many2Many.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Many2Many.Migrations
{
    [DbContext(typeof(DirectorFilm))]
    [Migration("20210602050402_codefirst")]
    partial class codefirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Many2Many.Model.Director", b =>
                {
                    b.Property<string>("DirectorName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<byte>("AwardCount")
                        .HasColumnType("tinyint");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("DirectorName");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("Many2Many.Model.Film", b =>
                {
                    b.Property<string>("FilmName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Collection")
                        .HasColumnType("float");

                    b.Property<int>("FilmID")
                        .HasColumnType("int");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.HasKey("FilmName");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Many2Many.Model.FilmDirector", b =>
                {
                    b.Property<string>("FilmName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DirectorName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("FilmName", "DirectorName");

                    b.HasIndex("DirectorName");

                    b.ToTable("FilmDirectors");
                });

            modelBuilder.Entity("Many2Many.Model.FilmDirector", b =>
                {
                    b.HasOne("Many2Many.Model.Director", "Director")
                        .WithMany("FilmDirectors")
                        .HasForeignKey("DirectorName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Many2Many.Model.Film", "Film")
                        .WithMany("FilmDirectors")
                        .HasForeignKey("FilmName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("Many2Many.Model.Director", b =>
                {
                    b.Navigation("FilmDirectors");
                });

            modelBuilder.Entity("Many2Many.Model.Film", b =>
                {
                    b.Navigation("FilmDirectors");
                });
#pragma warning restore 612, 618
        }
    }
}
