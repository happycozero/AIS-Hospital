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

                OleDbConnection oleDbConn = new OleDbConnection(conn);

                oleDbConn.Open();

                OleDbCommand sql = new OleDbCommand("SELECT * FROM users;");

                sql.Connection = oleDbConn;

                sql.ExecuteNonQuery();

                OleDbDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    string temp = reader[1].ToString();
                    Login.Items.Add(temp);
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        // выход из программы
        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Вы действительно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo);

            if (results == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bEntrance_Click(object sender, EventArgs e)
        {
            try
            {
                string login = Login.Text;
                string password = tbPass.Text;

                // проверка на пустые поля
                if (password == "" || login == "")
                {
                    MessageBox.Show("Ошибка! Заполните все поля!", "Информация");
                }

                // подключение к БД
                else 
                {
                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                    bool flagauth = false;

                    OleDbConnection oleDbConn = new OleDbConnection(conn);

                    oleDbConn.Open();

                    OleDbCommand sql = new OleDbCommand("SELECT * FROM users WHERE user_name = '" + login + "';");

                    sql.Connection = oleDbConn;

                    sql.ExecuteNonQuery();

                    OleDbDataReader reader = sql.ExecuteReader();

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

                    if (flagauth == false)
                    {
                        MessageBox.Show("Вы ввели неверный пароль!", "Информация об ошибке");    
                    }   
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        // при закрытии формы выводится предупреждение
        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
