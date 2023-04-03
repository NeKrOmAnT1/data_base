using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DB
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
