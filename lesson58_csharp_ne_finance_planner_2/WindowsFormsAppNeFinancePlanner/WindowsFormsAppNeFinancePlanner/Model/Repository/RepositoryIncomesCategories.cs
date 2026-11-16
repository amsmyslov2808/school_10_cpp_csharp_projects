using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;

namespace WindowsFormsAppNeFinancePlanner.Model.Repository
{
    internal class RepositoryIncomesCategories
    {
        private List<IncomeCategory> _incomesCategories;
        private int _currentId;

        public RepositoryIncomesCategories()
        {
            _incomesCategories = new List<IncomeCategory>();
            _currentId = 0;
        }

        public void AddCategory(IncomeCategory category)
        {
            _currentId++;
            category.Id = _currentId;
            _incomesCategories.Add(category);
        }

        public IncomeCategory GetById(int id)
        {
            foreach (IncomeCategory category in _incomesCategories)
            {
                if (category.Id == id)
                {
                    return category;
                }
            }

            return null;
        }

        public List<IncomeCategory> GetAllCategories()
        {
            return _incomesCategories;
        }

        public void RemoveCategory(IncomeCategory category)
        {
            _incomesCategories.Remove(category);
        }

    }
}
