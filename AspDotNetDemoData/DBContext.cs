using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspDotNetDemoCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace AspDotNetDemoData
{
   public class DBContext :DbContext
    {
        // Connecting in Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constring = "Server=DESKTOP-0SRN5KR;Database=ASPDOTNETDEMODB;TrustServerCertificate=True;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(constring);
        }
        public DbSet<User> Users { get; set; }
    }
}
