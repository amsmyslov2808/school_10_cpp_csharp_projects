using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;

namespace WindowsFormsAppNeFinancePlanner.Model.Repository
{
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
            _currentId++;
            income.Id = _currentId;
            _incomes.Add(income);
        }

        public List<Income> GetAllIncomes()
        {
            return _incomes;
        }

    }
}
