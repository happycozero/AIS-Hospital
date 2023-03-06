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
            dataGridViewUsers.ReadOnly = true;

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

                OleDbCommand sql1 = new OleDbCommand("SELECT * FROM users;")
                {
                    Connection = oleDbConn1
                };

                sql1.ExecuteNonQuery();

                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);

                // колонки таблицы "пользователи"
                da1.Fill(dt1);
                dt1.Columns["user_name"].ColumnName = "ФИО";
                dt1.Columns["login_name"].ColumnName = "Логин";
                dt1.Columns["password"].ColumnName = "Пароль";
                dt1.Columns["admin"].ColumnName = "Доступ";

                dataGridViewUsers.DataSource = dt1;

                // ширина колонок таблицы "пользователи"
                dataGridViewUsers.Columns[0].Visible = false;
                dataGridViewUsers.Columns[1].Width = 210;
                dataGridViewUsers.Columns[2].Width = 210;
                dataGridViewUsers.Columns[3].Width = 216;
                dataGridViewUsers.Columns[4].Width = 167;

                oleDbConn1.Close();

                count = dataGridViewUsers.Rows.Count - 1;

                //lCount.Text = "Количество\nпользователей: " + count;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        // кнопка добавления новго пользователя в БД
        private void BAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFIO.Text == "" || tbLog.Text == "" || tbPass.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string[] temps = tbFIO.Text.Split('.');
                    if (temps.Length < 3)
                    {
                        MessageBox.Show("Введите ФИО в формате 'Иванов И.И.'", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string admin = "-";
                        if (cmAdmin.Text == "Администратор")
                        {
                            admin = "+";
                        }

                        using (OleDbConnection oleDbConn = new OleDbConnection("Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;"))
                        {
                            oleDbConn.Open();

                            using (OleDbCommand sql = new OleDbCommand("INSERT INTO users (`user_name`, `login_name`, `password`, `admin`) VALUES (@userName, @loginName, @password, @admin)", oleDbConn))
                            {
                                sql.Parameters.AddWithValue("@userName", tbFIO.Text);
                                sql.Parameters.AddWithValue("@loginName", tbLog.Text);
                                sql.Parameters.AddWithValue("@password", tbPass.Text);
                                sql.Parameters.AddWithValue("@admin", admin);
                                sql.ExecuteNonQuery();
                            }
                        }

                        BClear_Click(sender, e);
                        UpdateGrid();
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BNewPass_Click(object sender, EventArgs e)
        {
            int N = 20;
            Random random = new Random();
            string pass = new string(Enumerable.Range(0, N).Select(_ => (char)random.Next(33, 127)).ToArray());
            tbPass.Text = pass;
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            tbFIO.Text = "";
            tbLog.Text = "";
            tbPass.Text = "";
            cmAdmin.Text = "";
        }

        private void TbFIO_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TbLog_KeyPress(object sender, KeyPressEventArgs e)
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
                string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb;";
                OleDbConnection oleDbConn1 = new OleDbConnection(conn);
                DataTable dt1 = new DataTable();

                oleDbConn1.Open();
                OleDbCommand sql1 = oleDbConn1.CreateCommand();
                sql1.CommandText = "SELECT * FROM users;";
                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);

                da1.Fill(dt1);

                dt1.Columns["user_name"].ColumnName = "ФИО";
                dt1.Columns["login_name"].ColumnName = "Логин";
                dt1.Columns["password"].ColumnName = "Пароль";
                dt1.Columns["admin"].ColumnName = "Администратор";

                dataGridViewUsers.DataSource = dt1;
                dataGridViewUsers.Columns[0].Visible = false;
                dataGridViewUsers.Columns[1].Width = 210;
                dataGridViewUsers.Columns[2].Width = 210;
                dataGridViewUsers.Columns[3].Width = 220;
                dataGridViewUsers.Columns[4].Width = 160;

                oleDbConn1.Close();

                count = dataGridViewUsers.Rows.Count - 1;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите продолжить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void MinimizeToTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
