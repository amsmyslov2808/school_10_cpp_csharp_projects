using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model.Entity;
using WindowsFormsAppNeFinancePlanner.Model.Repository;

namespace WindowsFormsAppNeFinancePlanner.Model
{
    internal class Db
    {
        private static Db _instance = null;

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

        private void FillMockData()
        {
            _repositoryIncomesCategories.AddCategory(new IncomeCategory { Name = "Зарплата" });
            _repositoryIncomesCategories.AddCategory(new IncomeCategory { Name = "Фриланс" });

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
