using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model;
using WindowsFormsAppNeFinancePlanner.Model.Entity;

namespace WindowsFormsAppNeFinancePlanner.Presenter
{
    internal class FormMainPresenter
    {
        private FormMain _formMain;
        private Db _db;

        public FormMainPresenter(FormMain formMain, Db db)
        {
            _formMain = formMain;
            _db = db;
        }

        public void RefreshIncomesDataGrid()
        {
            _formMain.dataGridViewIncomes.Rows.Clear();

            foreach(Income income in _db.GetRepositoryIncomes().GetAllIncomes())
            {
                _formMain.dataGridViewIncomes.Rows.Add(income.Id,income.OccurredAt, income.Category.Name, income.Comment, income.Money);
            }
        }

    }
}
