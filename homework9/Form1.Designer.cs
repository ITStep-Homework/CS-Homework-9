namespace homework9
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGuess = new System.Windows.Forms.TabPage();
            this.buttonStartGuess = new System.Windows.Forms.Button();
            this.labelGuessInfo = new System.Windows.Forms.Label();
            this.tabPageRunning = new System.Windows.Forms.TabPage();
            this.labelRunningStatic = new System.Windows.Forms.Label();
            this.labelRunningInfo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageGuess.SuspendLayout();
            this.tabPageRunning.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGuess);
            this.tabControl1.Controls.Add(this.tabPageRunning);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGuess
            // 
            this.tabPageGuess.Controls.Add(this.buttonStartGuess);
            this.tabPageGuess.Controls.Add(this.labelGuessInfo);
            this.tabPageGuess.Location = new System.Drawing.Point(4, 25);
            this.tabPageGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageGuess.Name = "tabPageGuess";
            this.tabPageGuess.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageGuess.Size = new System.Drawing.Size(1059, 525);
            this.tabPageGuess.TabIndex = 0;
            this.tabPageGuess.Text = "Угадай число";
            this.tabPageGuess.UseVisualStyleBackColor = true;
            // 
            // buttonStartGuess
            // 
            this.buttonStartGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGuess.Location = new System.Drawing.Point(65, 269);
            this.buttonStartGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartGuess.Name = "buttonStartGuess";
            this.buttonStartGuess.Size = new System.Drawing.Size(429, 143);
            this.buttonStartGuess.TabIndex = 1;
            this.buttonStartGuess.Text = "Начать игру";
            this.buttonStartGuess.UseVisualStyleBackColor = true;
            this.buttonStartGuess.Click += new System.EventHandler(this.buttonStartGuess_Click);
            // 
            // labelGuessInfo
            // 
            this.labelGuessInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuessInfo.Location = new System.Drawing.Point(61, 81);
            this.labelGuessInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuessInfo.Name = "labelGuessInfo";
            this.labelGuessInfo.Size = new System.Drawing.Size(579, 148);
            this.labelGuessInfo.TabIndex = 0;
            this.labelGuessInfo.Text = "Игра \"Угадай число\"\r\n\r\nКомпьютер будет угадывать число от 1 до 2000, которое вы з" +
    "агадали.\r\nОтвечайте честно на вопросы компьютера!\r\n\r\nНажмите кнопку \"Начать игру" +
    "\" для старта.";
            // 
            // tabPageRunning
            // 
            this.tabPageRunning.Controls.Add(this.labelRunningStatic);
            this.tabPageRunning.Controls.Add(this.labelRunningInfo);
            this.tabPageRunning.Location = new System.Drawing.Point(4, 25);
            this.tabPageRunning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRunning.Name = "tabPageRunning";
            this.tabPageRunning.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRunning.Size = new System.Drawing.Size(799, 525);
            this.tabPageRunning.TabIndex = 1;
            this.tabPageRunning.Text = "Убегающий статик";
            this.tabPageRunning.UseVisualStyleBackColor = true;
            this.tabPageRunning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabPageRunning_MouseMove);
            // 
            // labelRunningStatic
            // 
            this.labelRunningStatic.BackColor = System.Drawing.Color.LightBlue;
            this.labelRunningStatic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRunningStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRunningStatic.Location = new System.Drawing.Point(467, 246);
            this.labelRunningStatic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRunningStatic.Name = "labelRunningStatic";
            this.labelRunningStatic.Size = new System.Drawing.Size(133, 61);
            this.labelRunningStatic.TabIndex = 1;
            this.labelRunningStatic.Text = "Поймай меня!";
            this.labelRunningStatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRunningInfo
            // 
            this.labelRunningInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRunningInfo.Location = new System.Drawing.Point(61, 28);
            this.labelRunningInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRunningInfo.Name = "labelRunningInfo";
            this.labelRunningInfo.Size = new System.Drawing.Size(539, 105);
            this.labelRunningInfo.TabIndex = 0;
            this.labelRunningInfo.Text = "Игра \"Убегающий статик\"\r\n\r\nПопробуйте навести курсор мыши на синий прямоугольник." +
    " Он будет убегать от курсора!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Домашнее задание 9";
            this.tabControl1.ResumeLayout(false);
            this.tabPageGuess.ResumeLayout(false);
            this.tabPageRunning.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGuess;
        private System.Windows.Forms.Button buttonStartGuess;
        private System.Windows.Forms.Label labelGuessInfo;
        private System.Windows.Forms.TabPage tabPageRunning;
        private System.Windows.Forms.Label labelRunningStatic;
        private System.Windows.Forms.Label labelRunningInfo;
    }
}