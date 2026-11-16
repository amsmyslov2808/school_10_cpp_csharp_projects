using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model;
using WindowsFormsAppNeFinancePlanner.Model.Entity;

namespace WindowsFormsAppNeFinancePlanner.Presenter
{
    // Связывает форму с моделью: получает данные из хранилища и готовит их для интерфейса.
    internal class FormMainPresenter
    {
        private FormMain _formMain;
        private Db _db;

        public FormMainPresenter(FormMain formMain, Db db)
        {
            // Получаем готовые объекты снаружи, чтобы работать с формой и её общим хранилищем.
            _formMain = formMain;
            _db = db;
        }

        public void RefreshIncomesDataGrid()
        {
            // Полностью перестраиваем таблицу, чтобы повторное обновление не дублировало строки.
            _formMain.dataGridViewIncomes.Rows.Clear();

            // Для каждого дохода создаём строку в порядке столбцов, заданном в дизайнере.
            foreach(Income income in _db.GetRepositoryIncomes().GetAllIncomes())
            {
                // В таблице показываем название категории, поэтому у дохода должна быть категория.
                _formMain.dataGridViewIncomes.Rows.Add(income.Id,income.OccurredAt, income.Category.Name, income.Comment, income.Money);
            }
        }

    }
}
