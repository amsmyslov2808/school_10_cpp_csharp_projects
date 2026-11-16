using System;
using System.Windows.Forms;
using WindowsFormsAppNeFinancePlanner.Model;
using WindowsFormsAppNeFinancePlanner.Presenter;

namespace WindowsFormsAppNeFinancePlanner
{
    /// <summary>
    /// Главная форма принимает события интерфейса и передаёт работу с данными презентеру.
    /// Оформление формы лежит в FormMain.Designer.cs (свойства компонентов).
    /// </summary>
    public partial class FormMain : Form
    {
        private FormMainPresenter _presenter;

        public FormMain()
        {
            // Создаём элементы управления, описанные в файле дизайнера.
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Связываем загруженную форму с общим хранилищем данных через презентер.
            _presenter = new FormMainPresenter(this, Db.GetInstance());
            // При первом открытии показываем доходы, уже добавленные в хранилище.
            _presenter.RefreshIncomesDataGrid();
        }
    }
}
