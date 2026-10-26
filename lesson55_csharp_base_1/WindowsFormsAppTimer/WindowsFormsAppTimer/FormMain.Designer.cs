namespace WindowsFormsAppTimer
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonLap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelLapTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxLapsTime = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountLap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCurrentLap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(106, 191);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(126, 96);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(249, 191);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(123, 96);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(545, 191);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(146, 96);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonLap
            // 
            this.buttonLap.Location = new System.Drawing.Point(389, 191);
            this.buttonLap.Name = "buttonLap";
            this.buttonLap.Size = new System.Drawing.Size(139, 96);
            this.buttonLap.TabIndex = 3;
            this.buttonLap.Text = "Круг";
            this.buttonLap.UseVisualStyleBackColor = true;
            this.buttonLap.Click += new System.EventHandler(this.buttonLap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Общее время";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(108, 69);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(70, 25);
            this.labelTotalTime.TabIndex = 5;
            this.labelTotalTime.Text = "label2";
            // 
            // labelLapTime
            // 
            this.labelLapTime.AutoSize = true;
            this.labelLapTime.Location = new System.Drawing.Point(108, 148);
            this.labelLapTime.Name = "labelLapTime";
            this.labelLapTime.Size = new System.Drawing.Size(70, 25);
            this.labelLapTime.TabIndex = 7;
            this.labelLapTime.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Текущий круг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Круги";
            // 
            // listBoxLapsTime
            // 
            this.listBoxLapsTime.FormattingEnabled = true;
            this.listBoxLapsTime.ItemHeight = 25;
            this.listBoxLapsTime.Location = new System.Drawing.Point(106, 364);
            this.listBoxLapsTime.Name = "listBoxLapsTime";
            this.listBoxLapsTime.Size = new System.Drawing.Size(596, 404);
            this.listBoxLapsTime.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пройдено кругов";
            // 
            // labelCountLap
            // 
            this.labelCountLap.AutoSize = true;
            this.labelCountLap.Location = new System.Drawing.Point(540, 69);
            this.labelCountLap.Name = "labelCountLap";
            this.labelCountLap.Size = new System.Drawing.Size(70, 25);
            this.labelCountLap.TabIndex = 11;
            this.labelCountLap.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Текущий круг";
            // 
            // labelCurrentLap
            // 
            this.labelCurrentLap.AutoSize = true;
            this.labelCurrentLap.Location = new System.Drawing.Point(540, 148);
            this.labelCurrentLap.Name = "labelCurrentLap";
            this.labelCurrentLap.Size = new System.Drawing.Size(70, 25);
            this.labelCurrentLap.TabIndex = 13;
            this.labelCurrentLap.Text = "label7";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 837);
            this.Controls.Add(this.labelCurrentLap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCountLap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxLapsTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelLapTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLap);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormMain";
            this.Text = "Таймер кругов";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelLapTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxLapsTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCurrentLap;
    }
}

