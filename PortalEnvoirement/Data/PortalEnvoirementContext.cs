using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortalEnvoirement.Models;

namespace PortalEnvoirement.Data
{
    public class PortalEnvoirementContext : DbContext
    {
        public PortalEnvoirementContext (DbContextOptions<PortalEnvoirementContext> options)
            : base(options)
        {
        }

        public DbSet<PortalEnvoirement.Models.UserModel> UserModel { get; set; } = default!;
    }
}
