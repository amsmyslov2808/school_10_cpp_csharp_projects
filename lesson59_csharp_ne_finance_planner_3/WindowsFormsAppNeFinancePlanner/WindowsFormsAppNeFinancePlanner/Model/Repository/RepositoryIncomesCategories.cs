using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;

namespace WindowsFormsAppNeFinancePlanner.Model.Repository
{
    /// <summary>
    /// Хранит справочник категорий доходов в памяти приложения.
    /// </summary>
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
            // Счётчик не уменьшается при удалении: старые идентификаторы не выдаются повторно.
            _currentId++;
            category.Id = _currentId;
            _incomesCategories.Add(category);
        }

        // Возвращает найденную категорию или null, если такого идентификатора нет.
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

        // Возвращается исходный список, поэтому вызывающий код может изменить справочник.
        public List<IncomeCategory> GetAllCategories()
        {
            return _incomesCategories;
        }

        // Удаляет категорию только из справочника; ссылки в существующих доходах сохраняются.
        public void RemoveCategory(IncomeCategory category)
        {
            _incomesCategories.Remove(category);
        }

    }
}
