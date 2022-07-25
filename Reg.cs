using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace HospitalM
{
    public partial class Reg : MaterialForm
    {
        public int count = 0;
        public Reg()
        {
            InitializeComponent();

            // ограничение полей для регистрации нового пользователя
            tbLog.MaxLength = 20;
            tbPass.MaxLength = 20;
            tbFIO.MaxLength = 30;

            // подключение к БД
            try
            {
                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                OleDbConnection oleDbConn1 = new OleDbConnection(conn);

                DataTable dt1 = new DataTable();

                oleDbConn1.Open();

                OleDbCommand sql1 = new OleDbCommand("SELECT * FROM users;");

                sql1.Connection = oleDbConn1;

                sql1.ExecuteNonQuery();

                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);

                // колонки таблицы "пользователи"
                da1.Fill(dt1);
                dt1.Columns["user_name"].ColumnName = "ФИО";
                dt1.Columns["login_name"].ColumnName = "Логин";
                dt1.Columns["password"].ColumnName = "Пароль";
                dt1.Columns["admin"].ColumnName = "Администратор";

                dataGridViewUsers.DataSource = dt1;

                // ширина колонок таблицы "пользователи"
                dataGridViewUsers.Columns[0].Visible = false;
                dataGridViewUsers.Columns[1].Width = 210;
                dataGridViewUsers.Columns[2].Width = 210;
                dataGridViewUsers.Columns[3].Width = 220;
                dataGridViewUsers.Columns[4].Width = 160;

                oleDbConn1.Close();

                count = dataGridViewUsers.Rows.Count - 1;

                //lCount.Text = "Количество\nпользователей: " + count;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult results = MessageBox.Show("Вы действительно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo);

                if (results == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        // кнопка добавления новго пользователя в БД
        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFIO.Text == "В формате 'Дикарев Р.О.'" || tbLog.Text == "" || tbPass.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Информация об ошибке");
                }

                else
                {
                    string[] temps = tbFIO.Text.Split('.');

                    if (temps.Length < 3)
                    {
                        MessageBox.Show("Введите ФИО в формате 'Дикарев Р.О.'", "Информация об ошибке");
                    }
                    // проверка поля на права
                    else
                    {
                        string admin = "-";

                        if (cmAdmin.Text == "Администратор")
                        {
                            admin = "+";
                        }

                        string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                        OleDbConnection oleDbConn = new OleDbConnection(conn);

                        oleDbConn.Open();

                        OleDbCommand sql = new OleDbCommand("INSERT INTO users (`user_name`, `login_name`, `password`, `admin`) VALUES ( '" + tbFIO.Text + "' " + ", '" + tbLog.Text + "', '" + tbPass.Text + "', '" + admin + "');");

                        sql.Connection = oleDbConn;

                        sql.ExecuteNonQuery();

                        oleDbConn.Close();

                        bClear_Click(sender, e);
                        UpdateGrid();
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        private void bNewPass_Click(object sender, EventArgs e)
        {
            int N = 20;
            Random random = new Random();
            string pass = "";

            // генерирование пароля
            for (int i = 0; i < N; i++)
            {
                int temp = random.Next(33, 127);
                pass += (char)temp;
            }

            tbPass.Text = pass;
        }

        private void tbFIO_Enter(object sender, EventArgs e)
        {
            if (tbFIO.Text == "В формате 'Дикарев Р.О.'")
            {
                tbFIO.Text = "";
                tbFIO.ForeColor = Color.Black;
            }
        }

        private void tbFIO_Leave(object sender, EventArgs e)
        {
            if (tbFIO.Text == "")
            {
                tbFIO.Text = "В формате 'Дикарев Р.О.'";
                tbFIO.ForeColor = Color.Gray;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbFIO.Text = "В формате 'Дикарев Р.О.'";
            tbFIO.ForeColor = Color.Gray;
            tbLog.Text = "";
            tbPass.Text = "";
            cmAdmin.Text = "";
        }

        private void tbFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar >= 'А' && e.KeyChar <= 'Я' ||  e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == '.') 
            {
                return;
            }

            else
            {
                 e.Handled = true;
            }
        }

        private void tbLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == '.')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void UpdateGrid()
        {
            try
            {
                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                OleDbConnection oleDbConn1 = new OleDbConnection(conn);

                DataTable dt1 = new DataTable();

                oleDbConn1.Open();

                OleDbCommand sql1 = new OleDbCommand("SELECT * FROM users;");

                sql1.Connection = oleDbConn1;

                sql1.ExecuteNonQuery();

                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);

                // колонки таблицы "пользователи"
                da1.Fill(dt1);
                dt1.Columns["user_name"].ColumnName = "ФИО";
                dt1.Columns["login_name"].ColumnName = "Логин";
                dt1.Columns["password"].ColumnName = "Пароль";
                dt1.Columns["admin"].ColumnName = "Администратор";

                dataGridViewUsers.DataSource = dt1;

                // ширина колонок таблицы "пользователи"
                dataGridViewUsers.Columns[0].Visible = false;
                dataGridViewUsers.Columns[1].Width = 210;
                dataGridViewUsers.Columns[2].Width = 210;
                dataGridViewUsers.Columns[3].Width = 220;
                dataGridViewUsers.Columns[4].Width = 160;

                oleDbConn1.Close();

                count = dataGridViewUsers.Rows.Count - 1;

                //lCount.Text = "Количество\nпользователей: " + count;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }
    }
}
