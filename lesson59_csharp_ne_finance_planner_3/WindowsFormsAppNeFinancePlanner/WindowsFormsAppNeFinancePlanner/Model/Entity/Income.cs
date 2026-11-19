using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppNeFinancePlanner.Model.Entity
{
    /// <summary>
    /// Запись о доходе: дата операции, категория, пояснение и сумма.
    /// </summary>
    internal class Income
    {
        public int Id { get; set; }
        // Дата самой финансовой операции, а не время создания объекта.
        public DateTime OccurredAt { get; set; }

        // Ссылка на объект категории; её название используется при отображении записи.
        public IncomeCategory Category { get; set; }

        public string Comment { get; set; }

        // Сумма хранится целым числом: дробная часть в текущей модели не предусмотрена.
        public int Money { get; set; }
    }
}
