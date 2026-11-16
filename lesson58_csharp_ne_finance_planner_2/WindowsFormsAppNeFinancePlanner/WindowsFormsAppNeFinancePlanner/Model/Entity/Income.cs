using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppNeFinancePlanner.Model.Entity
{
    // Одна операция поступления денег; хранение и отображение выполняют другие классы.
    internal class Income
    {
        // Идентификатор назначает репозиторий при добавлении дохода.
        public int Id { get; set; }
        // Дата самой финансовой операции, которая выводится в таблице доходов.
        public DateTime OccurredAt { get; set; }

        // Ссылка на категорию позволяет получить и её идентификатор, и название.
        public IncomeCategory Category { get; set; }

        // Пользовательское пояснение к конкретному поступлению.
        public string Comment { get; set; }

        // Сумма хранится целым числом: дробная часть здесь не предусмотрена.
        public int Money { get; set; }
    }
}
