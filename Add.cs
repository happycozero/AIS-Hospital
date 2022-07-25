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
            // инициализирование класса DateTime для работы со временем
            Time.Format = DateTimePickerFormat.Custom;
            Time.CustomFormat = "HH:mm";
            Time.ShowUpDown = true;

            // ограничения на ввод полей для врачей
            tbNum.MaxLength = 4;
            tbFam.MaxLength = 30;
            tbName.MaxLength = 30;
            tbOtch.MaxLength = 30;

            // ограничения на ввод полей для пациентов
            tbNums.MaxLength = 4;
            textSurnamePatient.MaxLength = 30;
            textNamePatient.MaxLength = 30;
            textPatronymicPatient.MaxLength = 30;
      

            // ограничения на ввод полей для "талончиков"
            tbNumber.MaxLength = 4;
            DateTime date = DateTime.Today;
            string[] date1 = date.ToString("d").Split('.');
            int Day = Convert.ToInt32(date1[0]);
            int Month = Convert.ToInt32(date1[1]);
            int Year = Convert.ToInt32(date1[2]);
            DateVoucher.MaxDate = new DateTime(Year, Month + 1, Day);
            DateVoucher.MinDate = new DateTime(Year, Month, Day + 1);
            DatePatient.MaxDate = new DateTime(Year - 16, Month + 1, Day);
            DatePatient.MinDate = new DateTime(Year - 80, Month, Day + 1);
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
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
                if (tbNum.Text == "" || tbFam.Text == "" || tbName.Text == "" || tbOtch.Text == "" || cmPost.Text == "")
                {
                    MessageBox.Show("Ошибка! Заполните все поля!", "Информация об ошибке");
                }

                else 
                {
                    try
                    {
                        string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                        OleDbConnection oleDbConn = new OleDbConnection(conn);

                        oleDbConn.Open();

                        OleDbCommand sql = new OleDbCommand("INSERT INTO medic (`number`, `surname`, `name_medic`, `patronymic`, `work_medic`) VALUES (" + tbNum.Text + ",  '" + tbFam.Text + "', '" + tbName.Text + "', '" + tbOtch.Text + "', '" + cmPost.Text + "');")
                        {
                            Connection = oleDbConn
                        };

                        sql.ExecuteNonQuery();

                        oleDbConn.Close();

                        BClear_Click(sender, e);

                        MessageBox.Show("Информация добавлена в БД!", "Информация об ошибке");

                    }

                    catch (Exception msg)
                    {
                        MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация об ошибке");
                    }
                }
            }

            // переключение таблицы на "пациенты"
            if (TabPageNum == 2)
            {
                if (tbNums.Text == "" || textSurnamePatient.Text == "" || textNamePatient.Text == "" || textPatronymicPatient.Text == "")
                {
                    MessageBox.Show("Ошибка! Заполните все поля!", "Информация об ошибке");
                }

                else
                {
                    try
                    {
                        DatePatient.CustomFormat = "yyyy-MM-dd";

                        string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                        OleDbConnection oleDbConn = new OleDbConnection(conn);

                        oleDbConn.Open();

                        OleDbCommand sql = new OleDbCommand("INSERT INTO patient (`number`, `surname_patient`, `name_patient`, `patronymic_patient`, `date_patient`, `work_patient`) VALUES (" + tbNums.Text + ",  '" + textSurnamePatient.Text + "', '" + textNamePatient.Text + "', '" + textPatronymicPatient.Text + "', #" + DatePatient.Text + "#, '" + cmFormControl.Text + "');")
                        {
                            Connection = oleDbConn
                        };

                        sql.ExecuteNonQuery();

                        oleDbConn.Close();

                        DatePatient.CustomFormat = "dd-MM-yyyy";

                        MessageBox.Show("Успешно! Информация добавлена в БД! ", "Информация об ошибке");

                        BClear_Click(sender, e);



                    }

                    catch (Exception msg)
                    {
                        MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация об ошибке");
                    }
                }
            }

            // переключение таблицы на "пациенты"
            if (TabPageNum == 3)
            {
                if (tbNumber.Text == "")
                {
                    MessageBox.Show("Ошибка! Заполните все поля!", "Информация об ошибке");
                }

                else
                {
                    try
                    {

                        string[] temp = Time.ToString().Split(':');
                        string[] temp1 = temp[1].Split(' ');

                        // создаем ограничение по времени
                        if (Convert.ToInt32(temp1[2]) > 21 || Convert.ToInt32(temp1[2]) < 6)
                        {
                            MessageBox.Show("Ошибка! Выберите интервал времени с 6:00 до 21", "Информация об ошибке");
                        }

                        else
                        {
                            DateVoucher.CustomFormat = "yyyy-MM-dd";

                            string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                            OleDbConnection oleDbConn = new OleDbConnection(conn);

                            oleDbConn.Open();

                            OleDbCommand sql = new OleDbCommand("INSERT INTO voucher (`number`, date_voucher, `time_voucher`) VALUES (" + tbNumber.Text + ", #" + DateVoucher.Text + "#, '" + Time.Text + "');")
                            {
                                Connection = oleDbConn
                            };

                            sql.ExecuteNonQuery();

                            oleDbConn.Close();

                            DateVoucher.CustomFormat = "dd-MM-yyyy";

                            MessageBox.Show("Информация добавлена в БД! ", "Информация об ошибке");

                            BClear_Click(sender, e);
                        }
                    }

                    catch (Exception msg)
                    {
                        MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация об ошибке");
                    }
                }
            }
        }
        
        // проверка на ввод в поле "введите номер" (врачи)
        private void TbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        // проверка на ввод в поле "введите фамилию" (врачи)
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

        // проверка на ввод в поле "введите имя" (врачи)
        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
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

        // проверка на ввод в поле "введите отчество" (врачи)
        private void TbOtch_KeyPress(object sender, KeyPressEventArgs e)
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

        // проверка на ввод в поле "введите фамилию" (пациенты)
        private void TextSurnamePatient_KeyPress(object sender, KeyPressEventArgs e)
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

        // проверка на ввод в поле "введите имя" (пациенты)
        private void TextNamePatient_KeyPress(object sender, KeyPressEventArgs e)
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

        // проверка на ввод в поле "введите отчество" (пациенты)
        private void TextPatronymicPatient_KeyPress(object sender, KeyPressEventArgs e)
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
            // очистка полей для формы пациенты
            if (TabPageNum == 1)
            {
                tbNum.Text = "";
                tbFam.Text = "";
                tbName.Text = ""; 
                tbOtch.Text = ""; 
                cmPost.Text = "";
            }

            // очистка полей для формы врачи
            if (TabPageNum == 2)
            {
                tbNums.Text = "";
                textSurnamePatient.Text = "";
                textNamePatient.Text = "";
                textPatronymicPatient.Text = "";
                cmFormControl.Text = "";
            }

            // очистка полей для формы талончики
            if (TabPageNum == 3)
            {
                tbNumber.Text = "";
                Time.Text = "";
            }
        }
    }
}
