using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DB
{
    public class Account
    {
        [Key]
        public Guid IdAccount { get; set; }
        public string Name { get; set; }
    }
}
