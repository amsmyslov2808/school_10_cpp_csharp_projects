using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;

namespace WindowsFormsAppNeFinancePlanner.Model.Repository
{
    /// <summary>
    /// Хранит доходы в памяти и назначает идентификаторы новым записям.
    /// </summary>
    internal class RepositoryIncomes
    {
        private List<Income> _incomes;
        private int _currentId;

        public RepositoryIncomes()
        {
            _incomes = new List<Income>();
            _currentId = 0;
        }

        public void AddIncome(Income income)
        {
            // Идентификатор назначает репозиторий, независимо от значения в переданном объекте.
            _currentId++;
            income.Id = _currentId;

            _incomes.Add(income);
        }

        // Возвращается сам список, а не копия: его изменения повлияют на хранилище.
        public List<Income> GetAllIncomes()
        {
            return _incomes;
        }

    }
}
