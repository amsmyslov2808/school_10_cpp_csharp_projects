using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppNeFinancePlanner.Model.Entity
{
    internal class Income
    {
        public int Id { get; set; }
        public DateTime OccurredAt { get; set; }

        public IncomeCategory Category { get; set; }

        public string Comment { get; set; }

        public int Money { get; set; }
    }
}
