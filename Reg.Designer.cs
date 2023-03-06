namespace HospitalM
{
    partial class Reg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.bExit = new System.Windows.Forms.Button();
            this.lLog = new System.Windows.Forms.Label();
            this.lPass = new System.Windows.Forms.Label();
            this.lFIO = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.bNewPass = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.cmAdmin = new System.Windows.Forms.ComboBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.lCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(12, 544);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(263, 55);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.BackColor = System.Drawing.Color.Transparent;
            this.lLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLog.Location = new System.Drawing.Point(7, 354);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(77, 25);
            this.lLog.TabIndex = 6;
            this.lLog.Text = "Логин:";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.BackColor = System.Drawing.Color.Transparent;
            this.lPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPass.Location = new System.Drawing.Point(7, 448);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(92, 25);
            this.lPass.TabIndex = 7;
            this.lPass.Text = "Пароль:";
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.BackColor = System.Drawing.Color.Transparent;
            this.lFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFIO.Location = new System.Drawing.Point(293, 354);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(67, 25);
            this.lFIO.TabIndex = 8;
            this.lFIO.Text = "ФИО:";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPass.Location = new System.Drawing.Point(12, 476);
            this.tbPass.Name = "tbPass";
            this.tbPass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbPass.Size = new System.Drawing.Size(263, 29);
            this.tbPass.TabIndex = 10;
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbLog.Location = new System.Drawing.Point(12, 382);
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLog.Size = new System.Drawing.Size(263, 29);
            this.tbLog.TabIndex = 11;
            this.tbLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLog_KeyPress);
            // 
            // bNewPass
            // 
            this.bNewPass.BackColor = System.Drawing.SystemColors.Control;
            this.bNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNewPass.Location = new System.Drawing.Point(298, 544);
            this.bNewPass.Name = "bNewPass";
            this.bNewPass.Size = new System.Drawing.Size(275, 55);
            this.bNewPass.TabIndex = 12;
            this.bNewPass.Text = "Сгенерировать пароль";
            this.bNewPass.UseVisualStyleBackColor = false;
            this.bNewPass.Click += new System.EventHandler(this.BNewPass_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(593, 544);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(263, 55);
            this.bAdd.TabIndex = 13;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // tbFIO
            // 
            this.tbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFIO.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbFIO.Location = new System.Drawing.Point(298, 382);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbFIO.Size = new System.Drawing.Size(275, 29);
            this.tbFIO.TabIndex = 14;
            this.tbFIO.Text = "В формате \'Дикарев Р.О.\'";
            this.tbFIO.Enter += new System.EventHandler(this.TbFIO_Enter);
            this.tbFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFIO_KeyPress);
            this.tbFIO.Leave += new System.EventHandler(this.TbFIO_Leave);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.SystemColors.Control;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(593, 372);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(263, 49);
            this.bClear.TabIndex = 15;
            this.bClear.Text = "Очистить поля";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.BackColor = System.Drawing.Color.Transparent;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatus.Location = new System.Drawing.Point(293, 448);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(166, 25);
            this.lStatus.TabIndex = 16;
            this.lStatus.Text = "Права доступа:";
            // 
            // cmAdmin
            // 
            this.cmAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmAdmin.FormattingEnabled = true;
            this.cmAdmin.Items.AddRange(new object[] {
            "Пользователь",
            "Администратор"});
            this.cmAdmin.Location = new System.Drawing.Point(298, 476);
            this.cmAdmin.Name = "cmAdmin";
            this.cmAdmin.Size = new System.Drawing.Size(275, 28);
            this.cmAdmin.TabIndex = 18;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.Location = new System.Drawing.Point(10, 69);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(846, 271);
            this.dataGridViewUsers.TabIndex = 19;
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lCount.Location = new System.Drawing.Point(313, 458);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(0, 29);
            this.lCount.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Image = global::HospitalM.Properties.Resources.label1;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(794, -3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 27);
            this.label12.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox1.Image = global::HospitalM.Properties.Resources.exit;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(846, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.cmAdmin);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bNewPass);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lFIO);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.lLog);
            this.Controls.Add(this.bExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи | АИС Больница";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lLog;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button bNewPass;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.ComboBox cmAdmin;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}