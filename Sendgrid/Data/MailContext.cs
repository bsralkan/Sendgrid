using Microsoft.EntityFrameworkCore;
using Sendgrid.Models;

namespace Mail.Data
{
    public class MailContext : DbContext
    {
        public MailContext(DbContextOptions<MailContext> options)
            : base(options)
        {
        }

        public DbSet<MailContext> Mail { get; set; }
    }
}