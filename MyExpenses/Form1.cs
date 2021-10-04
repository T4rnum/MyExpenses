using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyExpenses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal balance = 0;
        private decimal totalIncome = 0;
        private decimal totalExpenses = 0;
        private decimal monthBalance = 0;

        private void StartBtn_Click(object sender, EventArgs e)
        {
            bool creditsCheck = decimal.TryParse(textBox1.Text, out balance);
            if (!creditsCheck)
            {
                MessageBox.Show(
                    "Введены неверные данные, попробуйте ещё раз!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                label1.Visible = false;
                textBox1.Visible = false;
                startBtn.Visible = false;
                this.Size = new Size(900, 600);
                this.FormBorderStyle = FormBorderStyle.Sizable;
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                this.MaximizeBox = true;
                monthBalance = balance;
                totalBalance.Text = $"Ваш текущий баланс: {balance:f2} ₽";
                totalIncomeText.Text = $"Доходы за месяц: {totalIncome:f2} ₽";
                totalExpensesText.Text = $"Расходы за месяц: {totalExpenses:f2} ₽";
                MonthBalanceText.Text = $"В следующем месяце ваш баланс составит: {monthBalance:f2} ₽";
            }
        }

        private string CurrencyValue(string searchText)
        {
            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                String Response = wc.DownloadString("http://www.finmarket.ru/currency/rates/");
                String Rate = System.Text.RegularExpressions.Regex.Match(Response, $@"{searchText}([0-9]+,[0-9]+)").Groups[1].Value;
                return Rate;
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show(
                            "Нам не удалось обнаружить подключение к интернету на вашем устройстве :(\nДля того чтобы продолжить полноценно использовать программу, необходимо интернет-соединение!",
                            "Нет подключения к интернету",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                return "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            this.Size = new Size(250, 300);
            this.MaximizeBox = false;
        }

        private void IncomeSave_Click(object sender, EventArgs e)
        {
            totalIncome = 0;
            string[] periodicity = new string[dataGridView1.RowCount];
            string[] name = new string[dataGridView1.RowCount];
            decimal[] sum = new decimal[dataGridView1.RowCount];
            bool[] sumCheck = new bool[dataGridView1.RowCount];
            string[] currency = new string[dataGridView1.RowCount];

            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    sumCheck[i] = decimal.TryParse(dataGridView1[2, i].Value.ToString(), out sum[i]);

                    if (!sumCheck[i])
                    {
                        MessageBox.Show(
                            "Введены неверные данные, попробуйте ещё раз!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                    }

                    periodicity[i] = dataGridView1[0, i].Value.ToString();
                    name[i] = dataGridView1[1, i].Value.ToString();
                    currency[i] = dataGridView1[3, i].Value.ToString();
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(
                    "Введены неверные данные, попробуйте ещё раз!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            for (int i = 0; i < currency.Length - 1; i++)
            {
                switch (currency[i])
                {
                    case "₽":
                        currency[i] = "1"; break;
                    case "$":
                        currency[i] = CurrencyValue(@"/>USD</div><div class=""value"">"); break;
                    case "€":
                        currency[i] = CurrencyValue(@"/>EUR</div><div class=""value"">"); break;
                    case "£":
                        currency[i] = CurrencyValue(@"/>GBP</div><div class=""value"">"); break;
                    case "₴":
                        currency[i] = CurrencyValue("гривна</a></td><td>10</td><td>"); break;
                    case "¥":
                        currency[i] = CurrencyValue("йена</a></td><td>100</td><td>"); break;
                    case "Ұ":
                        currency[i] = CurrencyValue("Жэньминьби</a></td><td>1</td><td>"); break;
                    default:
                        break;
                }

                sum[i] *= decimal.Parse(currency[i]);

                switch (periodicity[i])
                {
                    case "Ежедневно":
                        sum[i] *= 30m; break;
                    case "Еженедельно":
                        sum[i] *= 30m / 7m; break;
                    case "Ежегодно":
                        sum[i] /= 12; break;
                    default:
                        break;
                }

                totalIncome += sum[i];
            }
            monthBalance = balance + totalIncome - totalExpenses;
            totalIncomeText.Text = $"Доходы за месяц: {totalIncome:f2} ₽";
            MonthBalanceText.Text = $"В следующем месяце ваш баланс составит: {monthBalance:f2}";
        }

        private void ExpensesSave_Click(object sender, EventArgs e)
        {
            totalExpenses = 0;
            string[] periodicity = new string[dataGridView2.RowCount];
            string[] name = new string[dataGridView2.RowCount];
            decimal[] sum = new decimal[dataGridView2.RowCount];
            bool[] sumCheck = new bool[dataGridView2.RowCount];
            string[] currency = new string[dataGridView2.RowCount];
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                sumCheck[i] = decimal.TryParse(dataGridView2[2, i].Value.ToString(), out sum[i]);

                if (!sumCheck[i])
                {
                    MessageBox.Show(
                        "Введены неверные данные, попробуйте ещё раз!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }

                try
                {
                    periodicity[i] = dataGridView2[0, i].Value.ToString();
                    name[i] = dataGridView2[1, i].Value.ToString();
                    currency[i] = dataGridView2[3, i].Value.ToString();
                }

                catch (System.NullReferenceException)
                {
                    MessageBox.Show(
                        "Введены неверные данные, попробуйте ещё раз!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
            }

            for (int i = 0; i < currency.Length - 1; i++)
            {
                switch (currency[i])
                {
                    case "₽":
                        currency[i] = "1"; break;
                    case "$":
                        currency[i] = CurrencyValue(@"/>USD</div><div class=""value"">"); break;
                    case "€":
                        currency[i] = CurrencyValue(@"/>EUR</div><div class=""value"">"); break;
                    case "£":
                        currency[i] = CurrencyValue(@"/>GBP</div><div class=""value"">"); break;
                    case "₴":
                        currency[i] = CurrencyValue("гривна</a></td><td>10</td><td>"); break;
                    case "¥":
                        currency[i] = CurrencyValue("йена</a></td><td>100</td><td>"); break;
                    case "Ұ":
                        currency[i] = CurrencyValue("Жэньминьби</a></td><td>1</td><td>"); break;
                    default:
                        break;
                }

                sum[i] *= decimal.Parse(currency[i]);

                switch (periodicity[i])
                {
                    case "Ежедневно":
                        sum[i] *= 30m; break;
                    case "Еженедельно":
                        sum[i] *= 30m / 7m; break;
                    case "Ежегодно":
                        sum[i] /= 12; break;
                    default:
                        break;
                }

                totalExpenses += sum[i];
            }
            monthBalance = balance + totalIncome - totalExpenses;
            totalExpensesText.Text = $"Расходы за месяц: {totalExpenses:f2} ₽";
            MonthBalanceText.Text = $"В следующем месяце ваш баланс составит: {monthBalance:f2}";
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            balance = monthBalance;
            monthBalance = balance + totalIncome - totalExpenses;
            totalBalance.Text = $"Ваш текущий баланс: {balance:f2} ₽";
            MonthBalanceText.Text = $"В следующем месяце ваш баланс составит: {monthBalance:f2} ₽";
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            string date = Convert.ToString(DateTime.Now);
            string name = nameText.Text;
            decimal sum;
            bool sumCheck = decimal.TryParse(sumText.Text, out sum);
            bool checking = false;
            dataGridView3.Rows.Add(date, name, $"{sum} ₽");
            balance += sum;
            monthBalance = balance + totalIncome - totalExpenses;
            totalBalance.Text = $"Ваш текущий баланс: {balance:f2} ₽";
            MonthBalanceText.Text = $"В следующем месяце ваш баланс составит: {monthBalance:f2} ₽";
        }
    }
}
