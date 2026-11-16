using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppNeFinancePlanner.Model.Entity
{
    // Одна операция расхода денег; категория описывает, на что потрачена сумма.
    internal class Outcome
    {
        public int Id { get; set; }
        // Дата самой финансовой операции.
        public DateTime OccurredAt { get; set; }

        // Расходы используют собственный справочник категорий, отдельный от доходов.
        public OutcomeCategory Category { get; set; }

        // Пользовательское пояснение к конкретной трате.
        public string Comment { get; set; }

        // Сумма хранится целым числом: дробная часть здесь не предусмотрена.
        public int Money { get; set; }
    }
}
