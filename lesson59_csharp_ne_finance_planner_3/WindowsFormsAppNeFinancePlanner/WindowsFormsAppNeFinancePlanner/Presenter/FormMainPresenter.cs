using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppNeFinancePlanner.Model;
using WindowsFormsAppNeFinancePlanner.Model.Entity;
using WindowsFormsAppNeFinancePlanner.View;

namespace WindowsFormsAppNeFinancePlanner.Presenter
{
    /// <summary>
    /// Связывает главную форму с моделью: заполняет таблицу доходов
    /// и открывает окно добавления дохода.
    /// </summary>
    internal class FormMainPresenter
    {
        private FormMain _formMain;
        private Db _db;

        public FormMainPresenter(FormMain formMain, Db db)
        {
            _formMain = formMain;
            _db = db;
        }

        // Таблица заполняется вручную, поэтому перед обновлением удаляем прежние строки.
        public void RefreshIncomesDataGrid()
        {
            _formMain.dataGridViewIncomes.Rows.Clear();

            // Порядок значений должен совпадать с порядком столбцов в дизайнере формы.
            foreach(Income income in _db.GetRepositoryIncomes().GetAllIncomes())
            {
                _formMain.dataGridViewIncomes.Rows.Add(income.Id,income.OccurredAt, income.Category.Name, income.Comment, income.Money);
            }
        }

        // Модальное окно возвращает результат, по которому главная форма решает, обновлять ли таблицу.
        public DialogResult ShowDialogFormAddIncome()
        { 
            FormAddIncome formAddIncome = new FormAddIncome();
            // Передаём то же хранилище, с которым работает главная форма.
            FormAddIncomePresenter formAddIncomePresenter = new FormAddIncomePresenter(formAddIncome, _db);

            return formAddIncome.ShowDialog();
        }

    }
}
