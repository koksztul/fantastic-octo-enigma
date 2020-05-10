using Lab1_Oksztulski.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_Oksztulski.Context
{
    public class PersonContext :DbContext
    {
       
        private readonly string _connectionString = "Server=tcp:koksztulski-cdv.database.windows.net,1433;Initial Catalog=koksztulski_cdv;Persist Security Info=False;User ID=koksztulski;Password=iksLut25KoLim@k;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
