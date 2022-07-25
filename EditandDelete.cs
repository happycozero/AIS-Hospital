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
    public partial class EditandDelete : MaterialForm
    {
        public int TabPageNum = 1;
        public EditandDelete()
        {
            InitializeComponent();

            Time.Format = DateTimePickerFormat.Custom;
            Time.CustomFormat = "HH:mm";
            Time.ShowUpDown = true;

            // ограничения на ввод врачи
            tbNum.MaxLength = 4;
            tbFam.MaxLength = 30;
            tbName.MaxLength = 30;
            tbOtch.MaxLength = 30;

            // ограничения на ввод пациенты
            tbNums.MaxLength = 4;
            textSurnamePatient.MaxLength = 30;
            textNamePatient.MaxLength = 30;
            textPatronymicPatient.MaxLength = 30;

            // ограничения на ввод талончики
            tbNumber.MaxLength = 4;
            DateTime date = DateTime.Today;
            string[] date1 = date.ToString("d").Split('.');
            int Day = Convert.ToInt32(date1[0]);
            int Month = Convert.ToInt32(date1[1]);
            int Year = Convert.ToInt32(date1[2]);
            Date.MaxDate = new DateTime(Year, Month + 1, Day);
            Date.MinDate = new DateTime(Year, Month, Day + 1);

            if (TabPageNum == 1)
            {
                try
                {
                    comboChoiseMedic.Items.Clear();

                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                    OleDbConnection oleDbConn = new OleDbConnection(conn);

                    oleDbConn.Open();

                    OleDbCommand sql = new OleDbCommand("SELECT * FROM medic;")
                    {
                        Connection = oleDbConn
                    };

                    sql.ExecuteNonQuery();

                    OleDbDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        string N = reader[3].ToString();
                        string O = reader[4].ToString();
                        string medic = reader[2] + " " + N[0] + "." + O[0] + ".";
                        comboChoiseMedic.Items.Add(medic);
                    }
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
                }
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void TbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void TbFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void TbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                TabPageNum = 1;

                try
                {
                    comboChoiseMedic.Items.Clear();

                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                    OleDbConnection oleDbConn = new OleDbConnection(conn);

                    oleDbConn.Open();

                    OleDbCommand sql = new OleDbCommand("SELECT * FROM medic;")
                    {
                        Connection = oleDbConn
                    };

                    sql.ExecuteNonQuery();

                    OleDbDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        string N = reader[3].ToString();
                        string O = reader[4].ToString();
                        string medic = reader[2] + " " + N[0] + "." + O[0] + ".";
                        comboChoiseMedic.Items.Add(medic);
                    }
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
                }
            }

            if (tabControl1.SelectedTab == tabPage2)
            {
                TabPageNum = 2;

                try
                {
                    comboChoisePatient.Items.Clear();

                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                    OleDbConnection oleDbConn = new OleDbConnection(conn);

                    oleDbConn.Open();

                    OleDbCommand sql = new OleDbCommand("SELECT * FROM patient;")
                    {
                        Connection = oleDbConn
                    };

                    sql.ExecuteNonQuery();

                    OleDbDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        string sub = reader[3].ToString();
                        comboChoisePatient.Items.Add(sub);
                    }
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
                }
            }

            if (tabControl1.SelectedTab == tabPage3)
            {
                TabPageNum = 3;

                try
                {
                    comboChoiseVoucher.Items.Clear();

                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                    OleDbConnection oleDbConn = new OleDbConnection(conn);

                    oleDbConn.Open();

                    OleDbCommand sql = new OleDbCommand("SELECT * FROM voucher;")
                    {
                        Connection = oleDbConn
                    };

                    sql.ExecuteNonQuery();

                    OleDbDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        string pair = "Номер пациента: " + reader[1];
                        comboChoiseVoucher.Items.Add(pair);
                    }
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
                }

            }
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            if (tbNum.Text == "" || tbFam.Text == "" || tbName.Text == "" || tbOtch.Text == "" || comboWorkMedic.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля!", "Информация");
            }

            else
            {
                try
                {
                    string prep = comboChoiseMedic.Text;
                    string[] temp = prep.Split(' ');

                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                    OleDbConnection oleDbConn = new OleDbConnection(conn);

                    oleDbConn.Open();

                    OleDbCommand sql = new OleDbCommand("UPDATE medic SET surname = '" + tbFam.Text + "', name_medic = '" + tbName.Text + "', patronymic = '" + tbOtch.Text + "', work_medic = '" + comboWorkMedic.Text + "' WHERE number = " + tbNum.Text)
                    {
                        Connection = oleDbConn
                    };

                    sql.ExecuteNonQuery();

                    oleDbConn.Close();

                    BClear1_Click(sender, e);

                    MessageBox.Show("Информация отредактирована в БД! ", "Информация");

                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
                }
            }
        }

        private void ComboChoiseMedic_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string prep = comboChoiseMedic.Text;
                string[] temp = prep.Split(' ');
                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                OleDbConnection oleDbConn = new OleDbConnection(conn);

                oleDbConn.Open();

                OleDbCommand sql = new OleDbCommand("SELECT * FROM medic WHERE surname = '" + temp[0] + "';")
                {
                    Connection = oleDbConn
                };

                sql.ExecuteNonQuery();

                OleDbDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    tbNum.Text = reader[1].ToString();
                    tbFam.Text = reader[2].ToString();
                    tbName.Text = reader[3].ToString();
                    tbOtch.Text = reader[4].ToString();
                    comboWorkMedic.Text = reader[5].ToString();
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        private void CmSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                OleDbConnection oleDbConn = new OleDbConnection(conn);

                oleDbConn.Open();

                OleDbCommand sql = new OleDbCommand("SELECT * FROM patient WHERE surname_patient = '" + comboChoisePatient.Text + "';")
                {
                    Connection = oleDbConn
                };

                sql.ExecuteNonQuery();

                OleDbDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    tbNums.Text = reader[1].ToString();
                    textSurnamePatient.Text = reader[2].ToString();
                    textNamePatient.Text = reader[3].ToString();
                    textPatronymicPatient.Text = reader[4].ToString();
                    DatePatient.Value = Convert.ToDateTime(reader[5].ToString());
                    comboWorkPatient.Text = reader[6].ToString();
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        private void ComboChoiseVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] temp = comboChoiseVoucher.Text.Split(' ');

                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                OleDbConnection oleDbConn = new OleDbConnection(conn);

                oleDbConn.Open();

                OleDbCommand sql = new OleDbCommand("SELECT * FROM voucher WHERE number = " + temp[2] + ";")
                {
                    Connection = oleDbConn
                };

                sql.ExecuteNonQuery();

                OleDbDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    tbNumber.Text = reader[1].ToString();
                    Date.Value = Convert.ToDateTime(reader[2].ToString());
                    Time.Value = Convert.ToDateTime(reader[3].ToString());
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля!", "Информация");
            }

            else
            {
                try
                {

                    string[] temp = Time.ToString().Split(':');
                    string[] temp1 = temp[1].Split(' ');

                    if (Convert.ToInt32(temp1[2]) > 20 || Convert.ToInt32(temp1[2]) < 8)
                    {
                        MessageBox.Show("Ошибка! Выберите интервал времени с 6:00 до 21:00", "Информация об ошибке");
                    }

                    else
                    {
                        Date.CustomFormat = "yyyy-MM-dd";

                        string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                        OleDbConnection oleDbConn = new OleDbConnection(conn);

                        oleDbConn.Open();

                        OleDbCommand sql = new OleDbCommand("UPDATE voucher SET date_voucher = #" + Date.Text + "#, time_voucher = '" + Time.Text + "' WHERE number = " + tbNumber.Text)
                        {
                            Connection = oleDbConn
                        };

                        sql.ExecuteNonQuery();

                        oleDbConn.Close();

                        Date.CustomFormat = "dd-MM-yyyy";

                        MessageBox.Show("Успешно! Информация отредактирована в БД! ", "Информация");

                        Button7_Click(sender, e);
                    }
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
                }
            }
        }

        // очиска полей на форме "врачи"
        private void BClear1_Click(object sender, EventArgs e)
        {
            comboChoiseMedic.Text = "";
            tbNum.Text = "";
            tbFam.Text = "";
            tbName.Text = "";
            tbOtch.Text = "";
            comboWorkMedic.Text = "";
        }

        // очиска полей на форме "пациенты"
        private void Button6_Click(object sender, EventArgs e)
        {
            comboChoisePatient.Text = "";
            tbNums.Text = "";
            textSurnamePatient.Text = "";
            textNamePatient.Text = "";
            textPatronymicPatient.Text = "";
            comboWorkPatient.Text = "";
        }

        // очиска полей на форме "талончики"
        private void Button7_Click(object sender, EventArgs e)
        {
            comboChoiseVoucher.Text = "";
            tbNumber.Text = "";
            Time.Text = "";

            DateTime date = DateTime.Today;
            string[] date1 = date.ToString("d").Split('.');
            int Day = Convert.ToInt32(date1[0]);
            int Month = Convert.ToInt32(date1[1]);
            int Year = Convert.ToInt32(date1[2]);
            Date.Value = new DateTime(Year, Month, Day + 1);
        }

        // кнопка удаления информации о врачах в БД
        private void BDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboChoiseMedic.Text == "")
                {
                    MessageBox.Show("Сначала выберите запись!", "Информация об ошибке");
                }

                else
                {
                    DialogResult results = MessageBox.Show("Вы действительно хотите удалить выбранную Вами запись?", "Удаление информации", MessageBoxButtons.YesNo);

                    if (results == DialogResult.Yes)
                    {

                        string prep = comboChoiseMedic.Text;
                        string[] temp = prep.Split(' ');

                        string con = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                        OleDbConnection oleDbConn = new OleDbConnection(con);

                        oleDbConn.Open();

                        OleDbCommand sql = new OleDbCommand("DELETE * FROM medic WHERE surname = '" + temp[0] + "';")
                        {
                            Connection = oleDbConn
                        };

                        sql.ExecuteNonQuery();

                        oleDbConn.Close();

                        BClear1_Click(sender, e);
                        comboChoiseMedic.Items.Remove(comboChoiseMedic.SelectedItem.ToString());

                        MessageBox.Show("Запись была успешна удалена!", "Информация");
                    }

                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        // кнопка удаления информации о пациентах в БД
        private void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboChoisePatient.Text == "")
                {
                    MessageBox.Show("Сначала выберите запись!", "Информация об ошибке");
                }

                else
                {
                    DialogResult results = MessageBox.Show("Вы действительно хотите удалить выбранную Вами запись?", "Удаление информации", MessageBoxButtons.YesNo);

                    if (results == DialogResult.Yes)
                    {

                        string con = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                        OleDbConnection oleDbConn = new OleDbConnection(con);

                        oleDbConn.Open();

                        OleDbCommand sql = new OleDbCommand("DELETE * FROM patient WHERE surname_patient = '" + comboChoisePatient.Text + "';")
                        {
                            Connection = oleDbConn
                        };

                        sql.ExecuteNonQuery();

                        oleDbConn.Close();

                        Button6_Click(sender, e);

                        comboChoisePatient.Items.Remove(comboChoisePatient.SelectedItem.ToString());

                        MessageBox.Show("Запись была успешна удалена!", "Информация");
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        // кнопка удаления информации о талончиках в БД
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboChoiseVoucher.Text == "")
                {
                    MessageBox.Show("Ошибка! Сначала выберите запись!", "Информация");
                }

                else
                {
                    DialogResult results = MessageBox.Show("Вы действительно хотите удалить выбранную Вами запись?", "Удаление информации", MessageBoxButtons.YesNo);

                    if (results == DialogResult.Yes)
                    {
                        string[] temp = comboChoiseVoucher.Text.Split(' ');

                        string con = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                        OleDbConnection oleDbConn = new OleDbConnection(con);

                        oleDbConn.Open();

                        OleDbCommand sql = new OleDbCommand("DELETE * FROM voucher WHERE  number = " + temp[2] + ";")
                        {
                            Connection = oleDbConn
                        };

                        sql.ExecuteNonQuery();

                        oleDbConn.Close();

                        Button7_Click(sender, e);
                        comboChoiseVoucher.Items.Remove(comboChoiseVoucher.SelectedItem.ToString());

                        MessageBox.Show("Запись была успешна удалена!", "Информация");
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        // кнопка редактирования информации в БД
        private void Button1_Click(object sender, EventArgs e)
        {

            if (tbNums.Text == "" || textSurnamePatient.Text == "" || textNamePatient.Text == "" || textPatronymicPatient.Text == "" || comboWorkPatient.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Информация об ошибке");
            }

            else
            {
                try
                {
                    DatePatient.CustomFormat = "yyyy-MM-dd";

                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                    OleDbConnection oleDbConn = new OleDbConnection(conn);

                    oleDbConn.Open();

                    OleDbCommand sql = new OleDbCommand("UPDATE patient SET surname_patient = '" + textSurnamePatient.Text + "', name_patient = '" + textNamePatient.Text + "', patronymic_patient = '" + textPatronymicPatient.Text + "', date_patient = #" + DatePatient.Text + "#, work_patient = '" + comboWorkPatient.Text + "' WHERE number = " + tbNums.Text)
                    {
                        Connection = oleDbConn
                    };

                    sql.ExecuteNonQuery();

                    oleDbConn.Close();

                    DatePatient.CustomFormat = "dd-MM-yyyy";

                    MessageBox.Show("Информация отредактирована в БД! ", "Информация о редактировании");

                    Button6_Click(sender, e);
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
                }
            }
        }
    }
}