using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace HospitalM
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();

            // разграничение прав, некоторые кнопки в учетной записи "пользователь" убираются.
            if (Auth.Admin == "-")
            {
                bReg.Visible = false;
                bEditInfo.Visible = false;
                bAddInfo.Visible = false;

                bExit.Location = new Point(12, 150);
                this.Height = 250;
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из учетной записи?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Auth form1 = new Auth();
                form1.Show();
            }
        }

        // кнопка перехода на форму регистрации нового пользователя в БД
        private void BReg_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Hide();
        }

        // кнопка перехода на форму просмотра информации в БД
        private void BInfo_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
            this.Hide();
        }

        // кнопка перехода на форму добавления информации в БД
        private void BAddInfo_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        // кнопка перехода на форму редактирования и удаления информации в БД
        private void BEditInfo_Click(object sender, EventArgs e)
        {
            EditandDelete edit = new EditandDelete();
            edit.Show();
            this.Hide();
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
