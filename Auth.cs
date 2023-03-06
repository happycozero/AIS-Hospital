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
    public partial class Auth : MaterialForm
    {
        public static string Admin = "";
        public Auth()
        {
            InitializeComponent();

            // ограничение на ввод максимальной длины пароля
            tbPass.MaxLength = 20;

            // подключение к бд
            try
            {
                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                using (OleDbConnection oleDbConn = new OleDbConnection(conn))
                {
                    oleDbConn.Open();

                    OleDbCommand sql = new OleDbCommand("SELECT * FROM users;", oleDbConn);

                    using (OleDbDataReader reader = sql.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string temp = reader[1].ToString();
                            Login.Items.Add(temp);
                        }
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // выход из программы
        private void BExit_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Вы действительно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo);

            if (results == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BEntrance_Click(object sender, EventArgs e)
        {
            try
            {
                string login = Login.Text;
                string password = tbPass.Text;

                // проверка на пустые поля
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(login))
                {
                    MessageBox.Show("Ошибка! Заполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // подключение к БД
                else
                {
                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                    bool flagauth = false;

                    using (OleDbConnection oleDbConn = new OleDbConnection(conn))
                    {
                        oleDbConn.Open();

                        using (OleDbCommand sql = new OleDbCommand("SELECT * FROM users WHERE user_name = '" + login + "';", oleDbConn))
                        {
                            using (OleDbDataReader reader = sql.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string pass = reader[3].ToString();

                                    if (pass == password)
                                    {
                                        Admin = reader[4].ToString();
                                        flagauth = true;
                                        Main main = new Main();
                                        main.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                    }

                    if (flagauth == false)
                    {
                        MessageBox.Show("Вы ввели неверный пароль.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
