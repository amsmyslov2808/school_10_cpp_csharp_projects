namespace WindowsFormsAppNeFinancePlanner
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageIncome = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonIncomesAddNewIncome = new System.Windows.Forms.Button();
            this.dataGridViewIncomes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIncomesShowResult = new System.Windows.Forms.Button();
            this.textBoxIncomesMoneyTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIncomesMoneyFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxIncomesCategories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerIncomesFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerIncomesStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageOutcome = new System.Windows.Forms.TabPage();
            this.tabPageBalance = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPageIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageIncome);
            this.tabControl.Controls.Add(this.tabPageOutcome);
            this.tabControl.Controls.Add(this.tabPageBalance);
            this.tabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1604, 829);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageIncome
            // 
            this.tabPageIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageIncome.Controls.Add(this.splitContainer1);
            this.tabPageIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPageIncome.Location = new System.Drawing.Point(8, 50);
            this.tabPageIncome.Name = "tabPageIncome";
            this.tabPageIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncome.Size = new System.Drawing.Size(1588, 771);
            this.tabPageIncome.TabIndex = 0;
            this.tabPageIncome.Text = "Доходы";
            this.tabPageIncome.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitContainer1.Panel1.Controls.Add(this.buttonIncomesAddNewIncome);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewIncomes);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.splitContainer1.Panel2.Controls.Add(this.buttonIncomesShowResult);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIncomesMoneyTo);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIncomesMoneyFrom);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxIncomesCategories);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerIncomesFinishDate);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePickerIncomesStartDate);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1582, 765);
            this.splitContainer1.SplitterDistance = 1103;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonIncomesAddNewIncome
            // 
            this.buttonIncomesAddNewIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIncomesAddNewIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.buttonIncomesAddNewIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIncomesAddNewIncome.FlatAppearance.BorderSize = 0;
            this.buttonIncomesAddNewIncome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(116)))), ((int)(((byte)(18)))));
            this.buttonIncomesAddNewIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(58)))));
            this.buttonIncomesAddNewIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncomesAddNewIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonIncomesAddNewIncome.Location = new System.Drawing.Point(764, 533);
            this.buttonIncomesAddNewIncome.Name = "buttonIncomesAddNewIncome";
            this.buttonIncomesAddNewIncome.Size = new System.Drawing.Size(330, 61);
            this.buttonIncomesAddNewIncome.TabIndex = 2;
            this.buttonIncomesAddNewIncome.Text = "Добавить новый доход";
            this.buttonIncomesAddNewIncome.UseVisualStyleBackColor = false;
            this.buttonIncomesAddNewIncome.Click += new System.EventHandler(this.buttonIncomesAddNewIncome_Click);
            // 
            // dataGridViewIncomes
            // 
            this.dataGridViewIncomes.AllowUserToAddRows = false;
            this.dataGridViewIncomes.AllowUserToDeleteRows = false;
            this.dataGridViewIncomes.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewIncomes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewIncomes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIncomes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridViewIncomes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewIncomes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIncomes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIncomes.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewIncomes.EnableHeadersVisualStyles = false;
            this.dataGridViewIncomes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dataGridViewIncomes.Location = new System.Drawing.Point(13, 60);
            this.dataGridViewIncomes.Name = "dataGridViewIncomes";
            this.dataGridViewIncomes.ReadOnly = true;
            this.dataGridViewIncomes.RowHeadersVisible = false;
            this.dataGridViewIncomes.RowHeadersWidth = 82;
            this.dataGridViewIncomes.RowTemplate.Height = 32;
            this.dataGridViewIncomes.Size = new System.Drawing.Size(1081, 431);
            this.dataGridViewIncomes.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата и Время";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Категория дохода";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Комментарий";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Сумма";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица доходов";
            // 
            // buttonIncomesShowResult
            // 
            this.buttonIncomesShowResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIncomesShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.buttonIncomesShowResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIncomesShowResult.FlatAppearance.BorderSize = 0;
            this.buttonIncomesShowResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(116)))), ((int)(((byte)(18)))));
            this.buttonIncomesShowResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(58)))));
            this.buttonIncomesShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncomesShowResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonIncomesShowResult.Location = new System.Drawing.Point(13, 533);
            this.buttonIncomesShowResult.Name = "buttonIncomesShowResult";
            this.buttonIncomesShowResult.Size = new System.Drawing.Size(330, 61);
            this.buttonIncomesShowResult.TabIndex = 3;
            this.buttonIncomesShowResult.Text = "Показать";
            this.buttonIncomesShowResult.UseVisualStyleBackColor = false;
            // 
            // textBoxIncomesMoneyTo
            // 
            this.textBoxIncomesMoneyTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBoxIncomesMoneyTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIncomesMoneyTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxIncomesMoneyTo.Location = new System.Drawing.Point(13, 471);
            this.textBoxIncomesMoneyTo.Name = "textBoxIncomesMoneyTo";
            this.textBoxIncomesMoneyTo.Size = new System.Drawing.Size(324, 42);
            this.textBoxIncomesMoneyTo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(12, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "Сумма до";
            // 
            // textBoxIncomesMoneyFrom
            // 
            this.textBoxIncomesMoneyFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBoxIncomesMoneyFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIncomesMoneyFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxIncomesMoneyFrom.Location = new System.Drawing.Point(8, 379);
            this.textBoxIncomesMoneyFrom.Name = "textBoxIncomesMoneyFrom";
            this.textBoxIncomesMoneyFrom.Size = new System.Drawing.Size(324, 42);
            this.textBoxIncomesMoneyFrom.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(7, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "Сумма от";
            // 
            // comboBoxIncomesCategories
            // 
            this.comboBoxIncomesCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.comboBoxIncomesCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncomesCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxIncomesCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.comboBoxIncomesCategories.FormattingEnabled = true;
            this.comboBoxIncomesCategories.Items.AddRange(new object[] {
            "все",
            "1",
            "2",
            "3"});
            this.comboBoxIncomesCategories.Location = new System.Drawing.Point(8, 281);
            this.comboBoxIncomesCategories.Name = "comboBoxIncomesCategories";
            this.comboBoxIncomesCategories.Size = new System.Drawing.Size(324, 44);
            this.comboBoxIncomesCategories.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(7, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Категория";
            // 
            // dateTimePickerIncomesFinishDate
            // 
            this.dateTimePickerIncomesFinishDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dateTimePickerIncomesFinishDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dateTimePickerIncomesFinishDate.Location = new System.Drawing.Point(8, 181);
            this.dateTimePickerIncomesFinishDate.Name = "dateTimePickerIncomesFinishDate";
            this.dateTimePickerIncomesFinishDate.Size = new System.Drawing.Size(324, 42);
            this.dateTimePickerIncomesFinishDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(2, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Конец периода";
            // 
            // dateTimePickerIncomesStartDate
            // 
            this.dateTimePickerIncomesStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dateTimePickerIncomesStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dateTimePickerIncomesStartDate.Location = new System.Drawing.Point(8, 94);
            this.dateTimePickerIncomesStartDate.Name = "dateTimePickerIncomesStartDate";
            this.dateTimePickerIncomesStartDate.Size = new System.Drawing.Size(324, 42);
            this.dateTimePickerIncomesStartDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(2, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начало периода";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фильтры";
            // 
            // tabPageOutcome
            // 
            this.tabPageOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageOutcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPageOutcome.Location = new System.Drawing.Point(8, 50);
            this.tabPageOutcome.Name = "tabPageOutcome";
            this.tabPageOutcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutcome.Size = new System.Drawing.Size(1588, 771);
            this.tabPageOutcome.TabIndex = 1;
            this.tabPageOutcome.Text = "Расходы";
            this.tabPageOutcome.UseVisualStyleBackColor = true;
            // 
            // tabPageBalance
            // 
            this.tabPageBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPageBalance.Location = new System.Drawing.Point(8, 50);
            this.tabPageBalance.Name = "tabPageBalance";
            this.tabPageBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBalance.Size = new System.Drawing.Size(1588, 771);
            this.tabPageBalance.TabIndex = 2;
            this.tabPageBalance.Text = "Баланс";
            this.tabPageBalance.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1604, 829);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ne Finance Planner";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageIncome.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageIncome;
        private System.Windows.Forms.TabPage tabPageOutcome;
        private System.Windows.Forms.TabPage tabPageBalance;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIncomesAddNewIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonIncomesShowResult;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.DataGridView dataGridViewIncomes;
        internal System.Windows.Forms.ComboBox comboBoxIncomesCategories;
        internal System.Windows.Forms.DateTimePicker dateTimePickerIncomesFinishDate;
        internal System.Windows.Forms.DateTimePicker dateTimePickerIncomesStartDate;
        internal System.Windows.Forms.TextBox textBoxIncomesMoneyTo;
        internal System.Windows.Forms.TextBox textBoxIncomesMoneyFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
