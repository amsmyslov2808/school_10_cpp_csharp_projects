using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;

namespace WindowsFormsAppNeFinancePlanner.Model.Repository
{
    // Управляет коллекцией доходов в памяти; после закрытия приложения записи не сохраняются.
    internal class RepositoryIncomes
    {
        private List<Income> _incomes;
        // Последний выданный идентификатор; первый добавленный доход получит Id = 1.
        private int _currentId;

        public RepositoryIncomes()
        {
            _incomes = new List<Income>();
            _currentId = 0;
        }

        public void AddIncome(Income income)
        {
            // Репозиторий сам назначает Id, заменяя значение, переданное в объекте дохода.
            _currentId++;
            income.Id = _currentId;
            _incomes.Add(income);
        }

        public List<Income> GetAllIncomes()
        {
            // Возвращается сам список, поэтому его изменение снаружи изменит данные репозитория.
            return _incomes;
        }

    }
}
