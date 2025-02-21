using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Accounts
    {
        [Key]
        public int account_id { get; set; }
        public string Username { get; set; }
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string AccountRole { get; set; }

    }
}
