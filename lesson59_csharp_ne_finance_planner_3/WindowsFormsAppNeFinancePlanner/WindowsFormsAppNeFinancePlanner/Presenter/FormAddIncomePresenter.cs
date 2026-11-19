using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppNeFinancePlanner.Model;
using WindowsFormsAppNeFinancePlanner.View;

namespace WindowsFormsAppNeFinancePlanner.Presenter
{
    /// <summary>
    /// Заготовка презентера формы добавления дохода.
    /// Пока сохраняет ссылки на форму и хранилище; обработка ввода ещё не реализована.
    /// </summary>
    internal class FormAddIncomePresenter
    {
        private FormAddIncome _formAddIncome;
        private Db _db;

        public FormAddIncomePresenter(FormAddIncome formAddIncome, Db db)
        {
            _formAddIncome = formAddIncome;
            _db = db;
        }
    }
}
