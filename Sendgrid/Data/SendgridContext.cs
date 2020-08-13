using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sendgrid.Models;

namespace Sendgrid.Data
{
    public class SendgridContext : DbContext
    {
        public SendgridContext (DbContextOptions<SendgridContext> options)
            : base(options)
        {
        }

        public DbSet<Sendgrid.Models.Mail> Mail { get; set; }
    }
}
