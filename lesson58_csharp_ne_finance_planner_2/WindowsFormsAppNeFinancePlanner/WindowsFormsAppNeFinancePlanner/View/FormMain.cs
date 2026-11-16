using System;
using System.Windows.Forms;
using WindowsFormsAppNeFinancePlanner.Model;
using WindowsFormsAppNeFinancePlanner.Presenter;

namespace WindowsFormsAppNeFinancePlanner
{
    /// <summary>
    /// Только логика приложения.
    /// Оформление формы лежит в FormMain.Designer.cs (свойства компонентов)
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
            _presenter = new FormMainPresenter(this, Db.GetInstance());
            _presenter.RefreshIncomesDataGrid();
        }
    }
}
