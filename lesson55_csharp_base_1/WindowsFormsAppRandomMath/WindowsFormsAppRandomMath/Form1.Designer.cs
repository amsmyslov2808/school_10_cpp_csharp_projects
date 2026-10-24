namespace WindowsFormsAppRandomMath
{
    partial class Form1
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
            this.buttonNewExample = new System.Windows.Forms.Button();
            this.labelExample = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
            this.buttonCheckUserAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewExample
            // 
            this.buttonNewExample.Location = new System.Drawing.Point(12, 12);
            this.buttonNewExample.Name = "buttonNewExample";
            this.buttonNewExample.Size = new System.Drawing.Size(217, 29);
            this.buttonNewExample.TabIndex = 0;
            this.buttonNewExample.Text = "Новый пример";
            this.buttonNewExample.UseVisualStyleBackColor = true;
            this.buttonNewExample.Click += new System.EventHandler(this.buttonNewExample_Click);
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExample.Location = new System.Drawing.Point(12, 44);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(101, 25);
            this.labelExample.TabIndex = 1;
            this.labelExample.Text = "X + Y = ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ваш ответ:";
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Location = new System.Drawing.Point(17, 115);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(212, 20);
            this.textBoxUserAnswer.TabIndex = 3;
            // 
            // buttonCheckUserAnswer
            // 
            this.buttonCheckUserAnswer.Location = new System.Drawing.Point(17, 164);
            this.buttonCheckUserAnswer.Name = "buttonCheckUserAnswer";
            this.buttonCheckUserAnswer.Size = new System.Drawing.Size(212, 30);
            this.buttonCheckUserAnswer.TabIndex = 4;
            this.buttonCheckUserAnswer.Text = "Проверить ответ";
            this.buttonCheckUserAnswer.UseVisualStyleBackColor = true;
            this.buttonCheckUserAnswer.Click += new System.EventHandler(this.buttonCheckUserAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(241, 208);
            this.Controls.Add(this.buttonCheckUserAnswer);
            this.Controls.Add(this.textBoxUserAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.buttonNewExample);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РандомМат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewExample;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserAnswer;
        private System.Windows.Forms.Button buttonCheckUserAnswer;
    }
}

