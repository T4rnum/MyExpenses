
namespace MyExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.sumText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.totalIncomeText = new System.Windows.Forms.Label();
            this.totalExpensesText = new System.Windows.Forms.Label();
            this.MonthBalanceText = new System.Windows.Forms.Label();
            this.totalBalance = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.incomeSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IncomeColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IncomeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.expensesSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(397, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ваш текущий баланс:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(397, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 2;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(59, 115);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(118, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Далее";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.addNewBtn);
            this.tabPage1.Controls.Add(this.nameText);
            this.tabPage1.Controls.Add(this.sumText);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.calculateBtn);
            this.tabPage1.Controls.Add(this.totalIncomeText);
            this.tabPage1.Controls.Add(this.totalExpensesText);
            this.tabPage1.Controls.Add(this.MonthBalanceText);
            this.tabPage1.Controls.Add(this.totalBalance);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Статистика";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreatedDate,
            this.NameStat,
            this.ValueStat});
            this.dataGridView3.Location = new System.Drawing.Point(226, 203);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(453, 178);
            this.dataGridView3.TabIndex = 7;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Дата создания";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 110;
            // 
            // NameStat
            // 
            this.NameStat.HeaderText = "Название";
            this.NameStat.Name = "NameStat";
            this.NameStat.ReadOnly = true;
            this.NameStat.Width = 200;
            // 
            // ValueStat
            // 
            this.ValueStat.HeaderText = "Сумма";
            this.ValueStat.Name = "ValueStat";
            this.ValueStat.ReadOnly = true;
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(27, 258);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewBtn.TabIndex = 6;
            this.addNewBtn.Text = "Добавить";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(90, 203);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(130, 20);
            this.nameText.TabIndex = 5;
            // 
            // sumText
            // 
            this.sumText.Location = new System.Drawing.Point(74, 232);
            this.sumText.Name = "sumText";
            this.sumText.Size = new System.Drawing.Size(146, 20);
            this.sumText.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Сумма:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Чтобы внести какие-то измения баланс единоразово заполните поля ниже";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(24, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Чтобы совершить переход на следующий месяц нажмите кнопку ниже";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateBtn.Location = new System.Drawing.Point(27, 419);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(130, 41);
            this.calculateBtn.TabIndex = 1;
            this.calculateBtn.Text = "Расчитать";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // totalIncomeText
            // 
            this.totalIncomeText.AutoSize = true;
            this.totalIncomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalIncomeText.Location = new System.Drawing.Point(22, 49);
            this.totalIncomeText.Name = "totalIncomeText";
            this.totalIncomeText.Size = new System.Drawing.Size(198, 26);
            this.totalIncomeText.TabIndex = 0;
            this.totalIncomeText.Text = "Доходы за месяц:";
            // 
            // totalExpensesText
            // 
            this.totalExpensesText.AutoSize = true;
            this.totalExpensesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalExpensesText.Location = new System.Drawing.Point(22, 75);
            this.totalExpensesText.Name = "totalExpensesText";
            this.totalExpensesText.Size = new System.Drawing.Size(207, 26);
            this.totalExpensesText.TabIndex = 0;
            this.totalExpensesText.Text = "Расходы за месяц:";
            // 
            // MonthBalanceText
            // 
            this.MonthBalanceText.AutoSize = true;
            this.MonthBalanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthBalanceText.Location = new System.Drawing.Point(22, 127);
            this.MonthBalanceText.Name = "MonthBalanceText";
            this.MonthBalanceText.Size = new System.Drawing.Size(466, 26);
            this.MonthBalanceText.TabIndex = 0;
            this.MonthBalanceText.Text = "В следующем месяце ваш баланс составит:";
            // 
            // totalBalance
            // 
            this.totalBalance.AutoSize = true;
            this.totalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalBalance.Location = new System.Drawing.Point(22, 23);
            this.totalBalance.Name = "totalBalance";
            this.totalBalance.Size = new System.Drawing.Size(234, 26);
            this.totalBalance.TabIndex = 0;
            this.totalBalance.Text = "Ваш текущий баланс:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.incomeSave);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(860, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Доходы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // incomeSave
            // 
            this.incomeSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.incomeSave.Location = new System.Drawing.Point(503, 452);
            this.incomeSave.Name = "incomeSave";
            this.incomeSave.Size = new System.Drawing.Size(170, 30);
            this.incomeSave.TabIndex = 2;
            this.incomeSave.Text = "Внести изменения";
            this.incomeSave.UseVisualStyleBackColor = true;
            this.incomeSave.Click += new System.EventHandler(this.IncomeSave_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(497, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 482);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncomeColumn1,
            this.IncomeColumn2,
            this.IncomeColumn3,
            this.IncomeColumn4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // IncomeColumn1
            // 
            this.IncomeColumn1.HeaderText = "Периодичность";
            this.IncomeColumn1.Items.AddRange(new object[] {
            "Ежедневно",
            "Еженедельно",
            "Ежемесячно",
            "Ежегодно"});
            this.IncomeColumn1.Name = "IncomeColumn1";
            // 
            // IncomeColumn2
            // 
            this.IncomeColumn2.HeaderText = "Название";
            this.IncomeColumn2.Name = "IncomeColumn2";
            this.IncomeColumn2.Width = 200;
            // 
            // IncomeColumn3
            // 
            this.IncomeColumn3.HeaderText = "Сумма";
            this.IncomeColumn3.Name = "IncomeColumn3";
            // 
            // IncomeColumn4
            // 
            this.IncomeColumn4.HeaderText = "Валюта";
            this.IncomeColumn4.Items.AddRange(new object[] {
            "₽",
            "$",
            "€",
            "₴",
            "£",
            "¥",
            "Ұ"});
            this.IncomeColumn4.Name = "IncomeColumn4";
            this.IncomeColumn4.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.expensesSave);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 488);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Расходы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // expensesSave
            // 
            this.expensesSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.expensesSave.Location = new System.Drawing.Point(503, 452);
            this.expensesSave.Name = "expensesSave";
            this.expensesSave.Size = new System.Drawing.Size(170, 30);
            this.expensesSave.TabIndex = 3;
            this.expensesSave.Text = "Внести изменения";
            this.expensesSave.UseVisualStyleBackColor = true;
            this.expensesSave.Click += new System.EventHandler(this.ExpensesSave_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(497, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 482);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn2});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(494, 482);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Периодичность";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "Ежедневно",
            "Еженедельно",
            "Ежемесячно",
            "Ежегодно"});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Валюта";
            this.dataGridViewComboBoxColumn2.Items.AddRange(new object[] {
            "₽",
            "$",
            "€",
            "₴",
            "£",
            "¥",
            "Ұ"});
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 565);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyExpenses";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label totalIncomeText;
        private System.Windows.Forms.Label totalExpensesText;
        private System.Windows.Forms.Label totalBalance;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewComboBoxColumn IncomeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn IncomeColumn4;
        private System.Windows.Forms.Button incomeSave;
        private System.Windows.Forms.Button expensesSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.Label MonthBalanceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox sumText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueStat;
        private System.Windows.Forms.Label label8;
    }
}

