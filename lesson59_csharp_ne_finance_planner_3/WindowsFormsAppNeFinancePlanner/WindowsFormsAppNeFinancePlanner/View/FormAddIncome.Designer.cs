namespace WindowsFormsAppNeFinancePlanner.View
{
    partial class FormAddIncome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerOccurredAt = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonEditCategories = new System.Windows.Forms.Button();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата и время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория дохода";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма, руб.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Комментарий (необязательно)";
            // 
            // dateTimePickerOccurredAt
            // 
            this.dateTimePickerOccurredAt.Location = new System.Drawing.Point(28, 70);
            this.dateTimePickerOccurredAt.Name = "dateTimePickerOccurredAt";
            this.dateTimePickerOccurredAt.Size = new System.Drawing.Size(525, 31);
            this.dateTimePickerOccurredAt.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(28, 175);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(368, 33);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // buttonEditCategories
            // 
            this.buttonEditCategories.Location = new System.Drawing.Point(438, 175);
            this.buttonEditCategories.Name = "buttonEditCategories";
            this.buttonEditCategories.Size = new System.Drawing.Size(237, 86);
            this.buttonEditCategories.TabIndex = 6;
            this.buttonEditCategories.Text = "Редактировать категории";
            this.buttonEditCategories.UseVisualStyleBackColor = true;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(28, 298);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(307, 31);
            this.textBoxMoney.TabIndex = 7;
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(28, 409);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(658, 179);
            this.richTextBoxComment.TabIndex = 8;
            this.richTextBoxComment.Text = "";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(301, 628);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 64);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddIncome
            // 
            this.buttonAddIncome.Location = new System.Drawing.Point(434, 628);
            this.buttonAddIncome.Name = "buttonAddIncome";
            this.buttonAddIncome.Size = new System.Drawing.Size(252, 64);
            this.buttonAddIncome.TabIndex = 10;
            this.buttonAddIncome.Text = "Добавить доход";
            this.buttonAddIncome.UseVisualStyleBackColor = true;
            // 
            // FormAddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 704);
            this.Controls.Add(this.buttonAddIncome);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.buttonEditCategories);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.dateTimePickerOccurredAt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddIncome";
            this.Text = "FormAddIncome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEditCategories;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddIncome;
        internal System.Windows.Forms.DateTimePicker dateTimePickerOccurredAt;
        internal System.Windows.Forms.ComboBox comboBoxCategory;
        internal System.Windows.Forms.TextBox textBoxMoney;
        internal System.Windows.Forms.RichTextBox richTextBoxComment;
    }
}