﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal class Transactions
    {
        [Key]
        public int trans_id { get; set; }
        public int subs_id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }
        public string Note { get; set; }
        public string Duedate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TransactionDateTime { get; set; }
    }
}
