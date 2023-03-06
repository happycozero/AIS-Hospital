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
    public partial class Add : MaterialForm
    {
        public int TabPageNum = 1;
        public Add()
        {
            InitializeComponent();

            Time.ForeColor = Color.Gray;
            Time.Format = DateTimePickerFormat.Custom;
            Time.CustomFormat = "HH:mm";
            Time.ShowUpDown = true;

            tbNum.MaxLength = 4;
            tbFam.MaxLength = tbName.MaxLength = tbOtch.MaxLength = 30;

            tbNums.MaxLength = 4;
            textSurnamePatient.MaxLength = textNamePatient.MaxLength = textPatronymicPatient.MaxLength = 30;

            tbNumber.MaxLength = 4;
            var date = DateTime.Today;
            DateVoucher.MaxDate = new DateTime(date.Year, date.Month + 1, date.Day);
            DateVoucher.MinDate = new DateTime(date.Year, date.Month, date.Day + 1);
            DatePatient.MaxDate = new DateTime(date.Year - 16, date.Month + 1, date.Day);
            DatePatient.MinDate = new DateTime(date.Year - 80, date.Month, date.Day + 1);
        }

        // возвращение на предыдущую форму
        private void BExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        // кнопка добавления информации в БД
        private void BAdd_Click(object sender, EventArgs e)
        {
            if (TabPageNum == 1)
            {
                if (string.IsNullOrEmpty(tbNum.Text) || string.IsNullOrEmpty(tbFam.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbOtch.Text) || string.IsNullOrEmpty(cmPost.Text))
                {
                    MessageBox.Show("Ошибка!\nЗаполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";
                        using (OleDbConnection oleDbConn = new OleDbConnection(conn))
                        {
                            oleDbConn.Open();

                            using (OleDbCommand sql = new OleDbCommand("INSERT INTO medic (`number`, `surname`, `name_medic`, `patronymic`, `work_medic`) VALUES (" + tbNum.Text + ",  '"
                                + tbFam.Text + "', '" + tbName.Text + "', '" + tbOtch.Text + "', '" + cmPost.Text + "');", oleDbConn))
                            {
                                sql.ExecuteNonQuery();
                            }
                        }

                        BClear_Click(sender, e);

                        MessageBox.Show("Информация добавлена в БД.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Возникла ошибка!\n" + ex.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            // переключение таблицы на "пациенты"
            if (TabPageNum == 2)
            {
                if (tbNums.Text == "" || textSurnamePatient.Text == "" || textNamePatient.Text == "" || textPatronymicPatient.Text == "")
                {
                    MessageBox.Show("Ошибка!\nЗаполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        DatePatient.CustomFormat = "yyyy-MM-dd";

                        string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                        using (OleDbConnection oleDbConn = new OleDbConnection(conn))
                        {
                            oleDbConn.Open();

                            using (OleDbCommand sql = new OleDbCommand("INSERT INTO patient (`number`, `surname_patient`, `name_patient`, `patronymic_patient`, `date_patient`, `work_patient`) VALUES (" + tbNums.Text + ",  '"
                                + textSurnamePatient.Text + "', '" + textNamePatient.Text + "', '" + textPatronymicPatient.Text + "', #" + DatePatient.Text + "#, '" + cmFormControl.Text + "');"))
                            {
                                sql.Connection = oleDbConn;
                                sql.ExecuteNonQuery();
                            }
                        }

                        DatePatient.CustomFormat = "dd-MM-yyyy";

                        MessageBox.Show("Успешно!\n Информация добавлена в БД.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BClear_Click(sender, e);

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            // переключение таблицы на "пациенты"
            if (TabPageNum == 3)
            {
                if (tbNumber.Text == "")
                {
                    MessageBox.Show("Ошибка!\nЗаполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        string[] temp = Time.ToString().Split(':');
                        string[] temp1 = temp[1].Split(' ');

                        // создаем ограничение по времени
                        int time = Convert.ToInt32(temp1[2]);
                        if (time > 21 || time < 6)
                        {
                            MessageBox.Show("Выберите интервал времени с 6:00 до 21", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            DateVoucher.CustomFormat = "yyyy-MM-dd";

                            string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                            using (OleDbConnection oleDbConn = new OleDbConnection(conn))
                            {
                                oleDbConn.Open();

                                using (OleDbCommand sql = new OleDbCommand("INSERT INTO voucher (`number`, date_voucher, `time_voucher`) VALUES (" + tbNumber.Text + ", #" + DateVoucher.Text + "#, '" + Time.Text + "');", oleDbConn))
                                {
                                    sql.ExecuteNonQuery();
                                }
                            }

                            DateVoucher.CustomFormat = "dd-MM-yyyy";

                            MessageBox.Show("Информация добавлена в БД.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            BClear_Click(sender, e);
                        }
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("Возникла ошибка!\n" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        // проверка на ввод в поле "введите номер" (врачи)
        private void TbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        // проверка на ввод в поле "введите фамилию" (врачи)
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

        // проверка на ввод в поле "введите имя" (врачи)
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

        // проверка на ввод в поле "введите отчество" (врачи)
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

        // проверка на ввод в поле "введите фамилию" (пациенты)
        private void TextSurnamePatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        // проверка на ввод в поле "введите имя" (пациенты)
        private void TextNamePatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        // проверка на ввод в поле "введите отчество" (пациенты)
        private void TextPatronymicPatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        // проверка на ввод в поле "введите номер" (талончики)
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

        // выбор раздела в "tabcontrol"
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                TabPageNum = 1;
            }

            if (tabControl1.SelectedTab == tabPage2)
            {
                TabPageNum = 2;
            }

            if (tabControl1.SelectedTab == tabPage3)
            {
                TabPageNum = 3;
            }
        }
        
        // кнопка очищения полей
        private void BClear_Click(object sender, EventArgs e)
        {
            switch (TabPageNum)
            {
                case 1:
                    tbNum.Text = "";
                    tbFam.Text = "";
                    tbName.Text = "";
                    tbOtch.Text = "";
                    cmPost.Text = "";
                    break;
                case 2:
                    tbNums.Text = "";
                    textSurnamePatient.Text = "";
                    textNamePatient.Text = "";
                    textPatronymicPatient.Text = "";
                    cmFormControl.Text = "";
                    break;
                case 3:
                    tbNumber.Text = "";
                    Time.Text = "";
                    break;
                default:
                    break;
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
