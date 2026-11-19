using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;
using WindowsFormsAppNeFinancePlanner.Model.Repository;

namespace WindowsFormsAppNeFinancePlanner.Model
{
    /// <summary>
    /// Общее хранилище приложения: содержит репозитории доходов и их категорий.
    /// Данные существуют только в памяти и заново создаются при запуске программы.
    /// </summary>
    internal class Db
    {
        private static Db _instance = null;

        // Формы получают один экземпляр Db, поэтому работают с одними и теми же данными.
        // Текущая реализация рассчитана на вызовы из одного UI-потока.
        public static Db GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Db();
            }
            return _instance;
        }


        private RepositoryIncomes _repositoryIncomes;
        private RepositoryIncomesCategories _repositoryIncomesCategories;

        // Закрытый конструктор не позволяет создавать отдельные хранилища через new Db().
        private Db()
        {
            _repositoryIncomes = new RepositoryIncomes();
            _repositoryIncomesCategories = new RepositoryIncomesCategories();

            FillMockData();
        }

        public RepositoryIncomes GetRepositoryIncomes()
        {
            return _repositoryIncomes;
        }

        public RepositoryIncomesCategories GetRepositoryIncomesCategories()
        {
            return _repositoryIncomesCategories;
        }

        // Демонстрационные записи создаются один раз, при создании общего хранилища.
        private void FillMockData()
        {
            _repositoryIncomesCategories.AddCategory(new IncomeCategory { Name = "Зарплата" });
            _repositoryIncomesCategories.AddCategory(new IncomeCategory { Name = "Фриланс" });

            // Категории добавлены первыми: репозиторий назначил им идентификаторы 1 и 2.
            _repositoryIncomes.AddIncome(new Income
            {
                OccurredAt = DateTime.Now,
                Category = _repositoryIncomesCategories.GetById(1),
                Comment = "Зарплата за июнь",
                Money = 100000
            });

            _repositoryIncomes.AddIncome(new Income
            {
                OccurredAt = DateTime.Now,
                Category = _repositoryIncomesCategories.GetById(2),
                Comment = "Фриланс за июнь",
                Money = 50000
            });

        }


    }
}
