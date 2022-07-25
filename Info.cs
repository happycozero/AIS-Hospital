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
    public partial class Info : MaterialForm
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
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

        // таблица "врачи"
        private void rbMedic_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                OleDbConnection oleDbConn1 = new OleDbConnection(conn);

                DataTable dt1 = new DataTable();

                oleDbConn1.Open();

                OleDbCommand sql1 = new OleDbCommand("SELECT * FROM medic;");

                sql1.Connection = oleDbConn1;

                sql1.ExecuteNonQuery();

                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);

                // колонки таблицы "врачи"
                da1.Fill(dt1);
                dt1.Columns["number"].ColumnName = "Номер";
                dt1.Columns["surname"].ColumnName = "Фамилия";
                dt1.Columns["name_medic"].ColumnName = "Имя";
                dt1.Columns["patronymic"].ColumnName = "Отчество";
                dt1.Columns["work_medic"].ColumnName = "Должность";

                dataGridViewInfo.DataSource = dt1;

                // ширина колонок таблицы "врачи"
                dataGridViewInfo.Columns[0].Visible = false;
                dataGridViewInfo.Columns[1].Width = 75;
                dataGridViewInfo.Columns[2].Width = 135;
                dataGridViewInfo.Columns[3].Width = 120;
                dataGridViewInfo.Columns[4].Width = 150;
                dataGridViewInfo.Columns[5].Width = 200;

                oleDbConn1.Close();

                int count = dataGridViewInfo.Rows.Count - 1;

                //lCount.Text = "Количество врачей: " + count;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        // таблица "пациенты"
        private void rbPatient_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                OleDbConnection oleDbConn1 = new OleDbConnection(conn);

                DataTable dt1 = new DataTable();

                oleDbConn1.Open();

                OleDbCommand sql1 = new OleDbCommand("SELECT * FROM patient;");

                sql1.Connection = oleDbConn1;

                sql1.ExecuteNonQuery();

                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);

                // колонки таблицы "пациенты"
                da1.Fill(dt1);
                dt1.Columns["number"].ColumnName = "Номер";
                dt1.Columns["surname_patient"].ColumnName = "Фамилия";
                dt1.Columns["name_patient"].ColumnName = "Имя";
                dt1.Columns["patronymic_patient"].ColumnName = "Отчество";
                dt1.Columns["date_patient"].ColumnName = "Дата рождения";
                dt1.Columns["work_patient"].ColumnName = "Место работы";

                dataGridViewInfo.DataSource = dt1;

                // ширина колонок таблицы "пациенты"
                dataGridViewInfo.Columns[0].Visible = false;
                dataGridViewInfo.Columns[1].Width = 75;
                dataGridViewInfo.Columns[2].Width = 150;
                dataGridViewInfo.Columns[3].Width = 150;
                dataGridViewInfo.Columns[4].Width = 150;
                dataGridViewInfo.Columns[5].Width = 140;
                dataGridViewInfo.Columns[6].Width = 260;

                oleDbConn1.Close();

                int count = dataGridViewInfo.Rows.Count - 1;

                //lCount.Text = "Количество пациентов: " + count;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        // таблица "талончики"
        private void rbVoucher_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string conn = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=db.mdb;";

                OleDbConnection oleDbConn1 = new OleDbConnection(conn);

                DataTable dt1 = new DataTable();

                oleDbConn1.Open();

                OleDbCommand sql1 = new OleDbCommand("SELECT * FROM voucher;");

                sql1.Connection = oleDbConn1;

                sql1.ExecuteNonQuery();

                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);

                // колонки таблицы "талончики"
                da1.Fill(dt1);
                dt1.Columns["number"].ColumnName = "Номер";
                dt1.Columns["date_voucher"].ColumnName = "Дата";
                dt1.Columns["time_voucher"].ColumnName = "Время";

                dataGridViewInfo.DataSource = dt1;

                // ширина колонок таблицы "талончики"
                dataGridViewInfo.Columns[0].Visible = false;
                dataGridViewInfo.Columns[1].Width = 130;
                dataGridViewInfo.Columns[2].Width = 180;
                dataGridViewInfo.Columns[3].Width = 200;

                oleDbConn1.Close();

                int count = dataGridViewInfo.Rows.Count - 1;

                //lCount.Text = "Количество талончиков: " + count;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Информация");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
