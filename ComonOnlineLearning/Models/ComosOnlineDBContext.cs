using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ComonOnlineLearning.Models
{
    public partial class ComosOnlineDBContext : DbContext
    {
        public ComosOnlineDBContext()
        {
        }

        public ComosOnlineDBContext(DbContextOptions<ComosOnlineDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<GradeSubject> GradeSubject { get; set; }
        public virtual DbSet<GradeSubjectTopic> GradeSubjectTopic { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostSchool> PostSchool { get; set; }
        public virtual DbSet<SubTopic> SubTopic { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<TopicSubTopic> TopicSubTopic { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;initial catalog=ComosOnlineDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.Property(e => e.GradeId)
                    .HasColumnName("GradeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Grade1)
                    .IsRequired()
                    .HasColumnName("Grade")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GradeSubject>(entity =>
            {
                entity.Property(e => e.GradeSubjectId)
                    .HasColumnName("GradeSubjectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GradeSubjectDescription)
                    .HasColumnName("GradeSubject_Description")
                    .IsUnicode(false);

                entity.Property(e => e.GsGradeId).HasColumnName("GS_GradeID");

                entity.Property(e => e.GsSubjectId).HasColumnName("GS_SubjectID");

                entity.HasOne(d => d.GsGrade)
                    .WithMany(p => p.GradeSubject)
                    .HasForeignKey(d => d.GsGradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradeSubject_Grade");

                entity.HasOne(d => d.GsSubject)
                    .WithMany(p => p.GradeSubject)
                    .HasForeignKey(d => d.GsSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradeSubject_Subject");
            });

            modelBuilder.Entity<GradeSubjectTopic>(entity =>
            {
                entity.Property(e => e.GradeSubjectTopicId)
                    .HasColumnName("GradeSubjectTopicID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GstGradeSubjectId).HasColumnName("GST_GradeSubjectID");

                entity.Property(e => e.GstTopicId).HasColumnName("GST_TopicID");

                entity.HasOne(d => d.GstGradeSubject)
                    .WithMany(p => p.GradeSubjectTopic)
                    .HasForeignKey(d => d.GstGradeSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradeSubjectTopic_GradeSubject");

                entity.HasOne(d => d.GstTopic)
                    .WithMany(p => p.GradeSubjectTopic)
                    .HasForeignKey(d => d.GstTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradeSubjectTopic_Topic");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.PostId)
                    .HasColumnName("PostID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PostActive).HasColumnName("Post_Active");

                entity.Property(e => e.PostAuthor)
                    .HasColumnName("Post_Author")
                    .HasMaxLength(50);

                entity.Property(e => e.PostContent).HasColumnName("Post_Content");

                entity.Property(e => e.PostFeatured).HasColumnName("Post_Featured");

                entity.Property(e => e.PostPublishedDate)
                    .HasColumnName("Post_Published_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PostRating).HasColumnName("Post_Rating");

                entity.Property(e => e.PostTitle)
                    .HasColumnName("Post_Title")
                    .HasMaxLength(100);

                entity.Property(e => e.PostViews).HasColumnName("Post_Views");
            });

            modelBuilder.Entity<PostSchool>(entity =>
            {
                entity.Property(e => e.PostSchoolId)
                    .HasColumnName("PostSchoolID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PsGradeSubjectId).HasColumnName("PS_GradeSubjectID");

                entity.Property(e => e.PsPostId).HasColumnName("PS_PostID");

                entity.Property(e => e.PsSubTopicId).HasColumnName("PS_SubTopicID");

                entity.Property(e => e.PsTopicId).HasColumnName("PS_TopicID");

                entity.HasOne(d => d.PsGradeSubject)
                    .WithMany(p => p.PostSchool)
                    .HasForeignKey(d => d.PsGradeSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostSchool_GradeSubject");

                entity.HasOne(d => d.PsPost)
                    .WithMany(p => p.PostSchool)
                    .HasForeignKey(d => d.PsPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostSchool_Post");

                entity.HasOne(d => d.PsSubTopic)
                    .WithMany(p => p.PostSchool)
                    .HasForeignKey(d => d.PsSubTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostSchool_SubTopic");

                entity.HasOne(d => d.PsTopic)
                    .WithMany(p => p.PostSchool)
                    .HasForeignKey(d => d.PsTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostSchool_Topic");
            });

            modelBuilder.Entity<SubTopic>(entity =>
            {
                entity.Property(e => e.SubTopicId)
                    .HasColumnName("SubTopicID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SubTopicName)
                    .IsRequired()
                    .HasColumnName("SubTopic_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.SubjectId)
                    .HasColumnName("SubjectID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SubjectCoverUrl).HasColumnName("Subject_Cover_URL");

                entity.Property(e => e.SubjectDescription).HasColumnName("Subject_Description");

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasColumnName("Subject_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SubjectStatus).HasColumnName("Subject_Status");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.TopicId)
                    .HasColumnName("TopicID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TopicDescription).HasColumnName("Topic_Description");

                entity.Property(e => e.TopicName)
                    .IsRequired()
                    .HasColumnName("Topic_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TopicSubTopic>(entity =>
            {
                entity.Property(e => e.TopicSubTopicId)
                    .HasColumnName("TopicSubTopicID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TstSubTopicId).HasColumnName("TST_SubTopicID");

                entity.Property(e => e.TstTopicId).HasColumnName("TST_TopicID");

                entity.HasOne(d => d.TstSubTopic)
                    .WithMany(p => p.TopicSubTopic)
                    .HasForeignKey(d => d.TstSubTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicSubTopic_SubTopic");

                entity.HasOne(d => d.TstTopic)
                    .WithMany(p => p.TopicSubTopic)
                    .HasForeignKey(d => d.TstTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicSubTopic_Topic");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
