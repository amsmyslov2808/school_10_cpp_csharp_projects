using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;

namespace WindowsFormsAppNeFinancePlanner.Model.Repository
{
    // Справочник категорий доходов, общий для всех операций в текущем хранилище.
    internal class RepositoryIncomesCategories
    {
        private List<IncomeCategory> _incomesCategories;
        // Счётчик растёт при добавлении; удалённые идентификаторы повторно не выдаются.
        private int _currentId;

        public RepositoryIncomesCategories()
        {
            _incomesCategories = new List<IncomeCategory>();
            _currentId = 0;
        }

        public void AddCategory(IncomeCategory category)
        {
            // Назначаем новой категории Id перед помещением в справочник.
            _currentId++;
            category.Id = _currentId;
            _incomesCategories.Add(category);
        }

        public IncomeCategory GetById(int id)
        {
            // Ищем по Id, а не по позиции: после удаления категории индексы списка сдвигаются.
            foreach (IncomeCategory category in _incomesCategories)
            {
                if (category.Id == id)
                {
                    return category;
                }
            }

            // Отсутствующую категорию обозначаем null; вызывающий код должен учитывать этот результат.
            return null;
        }

        public List<IncomeCategory> GetAllCategories()
        {
            // Возвращается исходный список, а не копия: внешние изменения затронут справочник.
            return _incomesCategories;
        }

        public void RemoveCategory(IncomeCategory category)
        {
            // Удаляем переданный объект из справочника. Ссылки на него в доходах сохраняются.
            _incomesCategories.Remove(category);
        }

    }
}
