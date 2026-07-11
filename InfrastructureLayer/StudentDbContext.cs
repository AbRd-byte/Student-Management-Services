using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApplicationLayer.Module.Registration;

namespace InfrastructureLayer
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        // Define DbSet properties for your entities here
        public DbSet<RegisterDTO> RegisterDTO { get; set; }
    }
}
