using Microsoft.EntityFrameworkCore;

namespace UnrealServer.Data
{
    public class UnrealContext : DbContext {
        public DbSet<SpeechResult> SpeechResults { get; set; }

        public UnrealContext(DbContextOptions<UnrealContext> options) : base(options)
        {
            
        }
    }  
}
