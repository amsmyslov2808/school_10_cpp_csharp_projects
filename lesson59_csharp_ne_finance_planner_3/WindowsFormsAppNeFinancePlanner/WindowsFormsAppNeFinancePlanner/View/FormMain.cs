using System;
using System.Windows.Forms;
using WindowsFormsAppNeFinancePlanner.Model;
using WindowsFormsAppNeFinancePlanner.Presenter;

namespace WindowsFormsAppNeFinancePlanner
{
    /// <summary>
    /// Главная форма: передаёт действия пользователя презентеру.
    /// Создание и настройка элементов интерфейса находятся в FormMain.Designer.cs.
    /// </summary>
    public partial class FormMain : Form
    {
        private FormMainPresenter _presenter;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // При загрузке формы подключаем общее хранилище и показываем текущие доходы.
            _presenter = new FormMainPresenter(this, Db.GetInstance());
            _presenter.RefreshIncomesDataGrid();
        }

        private void buttonIncomesAddNewIncome_Click(object sender, EventArgs e)
        {
            // Обновляем таблицу после подтверждения; при отмене её содержимое сохраняется.
            if (_presenter.ShowDialogFormAddIncome() == DialogResult.OK)
            {
                _presenter.RefreshIncomesDataGrid();
            }
        }
    }
}
