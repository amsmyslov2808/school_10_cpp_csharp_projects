using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;
using WindowsFormsAppNeFinancePlanner.Model.Repository;

namespace WindowsFormsAppNeFinancePlanner.Model
{
    // Общее хранилище приложения: пока данные живут в памяти, а не в базе на диске.
    internal class Db
    {
        private static Db _instance = null;

        // Singleton: создаём хранилище при первом обращении и затем возвращаем тот же объект.
        public static Db GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Db();
            }
            return _instance;
        }


        // Репозитории отдельно управляют доходами и справочником их категорий.
        private RepositoryIncomes _repositoryIncomes;
        private RepositoryIncomesCategories _repositoryIncomesCategories;

        // Закрытый конструктор не позволяет создавать отдельные хранилища через new снаружи.
        private Db()
        {
            _repositoryIncomes = new RepositoryIncomes();
            _repositoryIncomesCategories = new RepositoryIncomesCategories();

            // Демонстрационные записи создаются один раз, вместе с экземпляром хранилища.
            FillMockData();
        }

        // Возвращаем существующий репозиторий, чтобы все обращения работали с одними доходами.
        public RepositoryIncomes GetRepositoryIncomes()
        {
            return _repositoryIncomes;
        }

        // Этот же справочник используется при создании и отображении доходов.
        public RepositoryIncomesCategories GetRepositoryIncomesCategories()
        {
            return _repositoryIncomesCategories;
        }

        private void FillMockData()
        {
            // Сначала создаём категории: репозиторий назначит им идентификаторы 1 и 2.
            _repositoryIncomesCategories.AddCategory(new IncomeCategory { Name = "Зарплата" });
            _repositoryIncomesCategories.AddCategory(new IncomeCategory { Name = "Фриланс" });

            // Доход хранит ссылку на категорию из справочника, а не отдельную копию её названия.
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
