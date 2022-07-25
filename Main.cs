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

        // кнопка выхода из программы
        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Вы действительно хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo);

            if (results == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
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

        // кнопка перехода на форму регистрации нового пользователя в БД
        private void bReg_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Hide();
        }

        // кнопка перехода на форму просмотра информации в БД
        private void bInfo_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
            this.Hide();
        }

        // кнопка перехода на форму добавления информации в БД
        private void bAddInfo_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        // кнопка перехода на форму редактирования и удаления информации в БД
        private void bEditInfo_Click(object sender, EventArgs e)
        {
            EditandDelete edit = new EditandDelete();
            edit.Show();
            this.Hide();
        }
    }
}
