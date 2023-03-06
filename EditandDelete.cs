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

            tbNum.Enabled = false;
            tbNum.TabStop = false;

            tbNums.Enabled = false;
            tbNums.TabStop = false;

            tbNumber.Enabled = false;
            tbNumber.TabStop = false;

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
                    MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void TbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
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

                    OleDbCommand sql = oleDbConn.CreateCommand();
                    sql.CommandText = "SELECT * FROM medic;";

                    OleDbDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        string N = reader.GetString(3);
                        string O = reader.GetString(4);
                        string medic = reader.GetString(2) + " " + N[0] + "." + O[0] + ".";
                        comboChoiseMedic.Items.Add(medic);
                    }

                    reader.Close();
                    oleDbConn.Close();
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    OleDbCommand sql = new OleDbCommand("SELECT * FROM patient;");
                    sql.Connection = oleDbConn;

                    OleDbDataReader reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        string sub = reader[3].ToString();
                        comboChoisePatient.Items.Add(sub);
                    }

                    reader.Close();
                    sql.Dispose();
                    oleDbConn.Close();
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    OleDbCommand sql = new OleDbCommand("SELECT * FROM voucher;", oleDbConn);

                    OleDbDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        string pair = "Номер пациента: " + reader[1];
                        comboChoiseVoucher.Items.Add(pair);
                    }

                    reader.Close();
                    oleDbConn.Close();
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            if (tbNum.Text == "" || tbFam.Text == "" || tbName.Text == "" || tbOtch.Text == "" || comboWorkMedic.Text == "")
            {
                MessageBox.Show("Ошибка!\n Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    string query = "UPDATE medic SET surname = @surname, name_medic = @name_medic, patronymic = @patronymic, work_medic = @work_medic WHERE number = @number";
                    OleDbCommand sql = new OleDbCommand(query, oleDbConn);
                    sql.Parameters.AddWithValue("@surname", tbFam.Text);
                    sql.Parameters.AddWithValue("@name_medic", tbName.Text);
                    sql.Parameters.AddWithValue("@patronymic", tbOtch.Text);
                    sql.Parameters.AddWithValue("@work_medic", comboWorkMedic.Text);
                    sql.Parameters.AddWithValue("@number", tbNum.Text);

                    sql.ExecuteNonQuery();

                    oleDbConn.Close();

                    BClear1_Click(sender, e);

                    MessageBox.Show("Информация отредактирована в БД! ", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                OleDbCommand sql = new OleDbCommand("SELECT * FROM medic WHERE surname = @surname;")
                {
                    Connection = oleDbConn
                };

                sql.Parameters.AddWithValue("@surname", temp[0]);
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
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string conn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                OleDbConnection oleDbConn = new OleDbConnection(conn);
                oleDbConn.Open();

                OleDbCommand sql = new OleDbCommand("SELECT * FROM patient WHERE surname_patient='" + comboChoisePatient.Text + "';");
                sql.Connection = oleDbConn;

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

                oleDbConn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrEmpty(comboChoiseMedic.Text))
                {
                    MessageBox.Show("Сначала выберите запись!", "Информация об ошибке");
                    return;
                }

                DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную Вами запись?", "Удаление информации", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string[] temp = comboChoiseMedic.Text.Split(' ');

                    string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                    using (OleDbConnection oleDbConn = new OleDbConnection(conn))
                    {
                        oleDbConn.Open();

                        using (OleDbCommand sql = new OleDbCommand("DELETE * FROM medic WHERE surname = '" + temp[0] + "';", oleDbConn))
                        {
                            sql.ExecuteNonQuery();
                        }
                    }

                    BClear1_Click(sender, e);
                    comboChoiseMedic.Items.Remove(comboChoiseMedic.SelectedItem.ToString());

                    MessageBox.Show("Запись была успешна удалена!", "Информация");
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        OleDbCommand sql = new OleDbCommand("DELETE * FROM patient WHERE surname_patient = '" + comboChoisePatient.Text + "';", oleDbConn);
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
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // кнопка удаления информации о талончиках в БД
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboChoiseVoucher.Text == "")
                {
                    MessageBox.Show("Ошибка!\n Сначала выберите запись.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult results = MessageBox.Show("Вы действительно хотите удалить выбранную Вами запись?", "Удаление информации", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (results != DialogResult.Yes) return;

                string[] temp = comboChoiseVoucher.Text.Split(' ');

                string con = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                using (OleDbConnection oleDbConn = new OleDbConnection(con))
                {
                    oleDbConn.Open();

                    using (OleDbCommand sql = new OleDbCommand("DELETE * FROM voucher WHERE number = " + temp[2] + ";"))
                    {
                        sql.Connection = oleDbConn;
                        sql.ExecuteNonQuery();
                    }
                }

                Button7_Click(sender, e);
                comboChoiseVoucher.Items.Remove(comboChoiseVoucher.SelectedItem.ToString());

                MessageBox.Show("Запись была успешна удалена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // кнопка редактирования информации в БД
        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNums.Text) || string.IsNullOrEmpty(textSurnamePatient.Text) || string.IsNullOrEmpty(textNamePatient.Text) || 
                string.IsNullOrEmpty(textPatronymicPatient.Text) || string.IsNullOrEmpty(comboWorkPatient.Text))
            {
                MessageBox.Show("Ошибка! Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    DatePatient.CustomFormat = "yyyy-MM-dd";

                    string conn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                    using (OleDbConnection oleDbConn = new OleDbConnection(conn))
                    {
                        oleDbConn.Open();

                        using (OleDbCommand sql = new OleDbCommand("UPDATE patient SET surname_patient = @surname, name_patient = @name, patronymic_patient = @patronymic, date_patient = @date, work_patient = @work WHERE number = @number", oleDbConn))
                        {
                            sql.Parameters.AddWithValue("@surname", textSurnamePatient.Text);
                            sql.Parameters.AddWithValue("@name", textNamePatient.Text);
                            sql.Parameters.AddWithValue("@patronymic", textPatronymicPatient.Text);
                            sql.Parameters.AddWithValue("@date", DatePatient.Value.Date);
                            sql.Parameters.AddWithValue("@work", comboWorkPatient.Text);
                            sql.Parameters.AddWithValue("@number", tbNums.Text);

                            sql.ExecuteNonQuery();
                        }
                    }

                    DatePatient.CustomFormat = "dd-MM-yyyy";

                    MessageBox.Show("Информация отредактирована в БД.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Button6_Click(sender, e);
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void TbOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textPatronymicPatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textSurnamePatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textNamePatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}