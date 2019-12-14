

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using talantly.Models;
using talantly.Models.Publications;
using talantly.Models.User;

namespace talanty.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<AttachmentType> AttachmentTypes { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfilePriority> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(d => d.attachmentType);
            });
            modelBuilder.Entity<AttachmentType>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Publication>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasMany(d => d.attachmentList);
            });
            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasOne(e => e.category);
            });
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasOne(e => e.accountRole);
                entity.HasMany(d => d.ProfileList);

            });
            
        }

    }

}
