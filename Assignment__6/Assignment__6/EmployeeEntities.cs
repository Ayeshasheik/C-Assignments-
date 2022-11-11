using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__6
{
    public class EmployeeEntities
    {
        public double account_number { get; set; }

        public string customer_name { get; set; }

        public long balance { get; set; } = 50000;

        public long withdraw { get; set; }

        public long deposit_amount { get; set; }

        public long balanceAmount { get; set; }

        public int underBalance { get; set; }

        public int zeroBalance { get; set; }


    }
}
