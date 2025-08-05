using Microsoft.EntityFrameworkCore;
using Mix.tj.Domain.Entities.Identity;
using Mix.tj.Domain.Entities.Infrastructure;
using Mix.tj.Domain.Entities.Notification;
using Mix.tj.Domain.Entities.Verification;

namespace Mix.tj.Persistance.DataContexts;
public class AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : DbContext(dbContextOptions)
{
    //Identity
    public DbSet<User> Users => Set<User>();
    public DbSet<UserSettings> UserSettings => Set<UserSettings>();

    //Verification
    public DbSet<UserInfoVerificationCode> UserInfoVerificationCodes => Set<UserInfoVerificationCode>();
    public DbSet<AccessToken> AccessTokens => Set<AccessToken>();
    
    //Notification
    public DbSet<EmailTemplate> EmailTemplates => Set<EmailTemplate>();
    public DbSet<EmailHistory> EmailHistories => Set<EmailHistory>();

    //Infrastructure
    public DbSet<Comment> Comments => Set<Comment>();
    public DbSet<Like> Likes => Set<Like>();
    public DbSet<News> News => Set<News>();
    public DbSet<Video> Videos => Set<Video>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
