namespace HospitalM
{
    partial class Auth
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.lLog = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bEntrance = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MinimizeToTray = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeToTray)).BeginInit();
            this.SuspendLayout();
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.BackColor = System.Drawing.Color.Transparent;
            this.lLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLog.Location = new System.Drawing.Point(121, 82);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(77, 25);
            this.lLog.TabIndex = 0;
            this.lLog.Text = "Логин:";
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.Location = new System.Drawing.Point(43, 210);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPass.Size = new System.Drawing.Size(234, 29);
            this.tbPass.TabIndex = 1;
            // 
            // bEntrance
            // 
            this.bEntrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEntrance.ForeColor = System.Drawing.Color.Black;
            this.bEntrance.Location = new System.Drawing.Point(43, 276);
            this.bEntrance.Name = "bEntrance";
            this.bEntrance.Size = new System.Drawing.Size(234, 52);
            this.bEntrance.TabIndex = 2;
            this.bEntrance.Text = "Войти";
            this.bEntrance.UseVisualStyleBackColor = false;
            this.bEntrance.Click += new System.EventHandler(this.BEntrance_Click);
            // 
            // Login
            // 
            this.Login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.FormattingEnabled = true;
            this.Login.Location = new System.Drawing.Point(43, 110);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(234, 28);
            this.Login.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пароль:";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Exit.Image = global::HospitalM.Properties.Resources.exit;
            this.Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit.Location = new System.Drawing.Point(293, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 25);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 12;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HospitalM.Properties.Resources.label1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // MinimizeToTray
            // 
            this.MinimizeToTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MinimizeToTray.Image = global::HospitalM.Properties.Resources.resize;
            this.MinimizeToTray.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinimizeToTray.Location = new System.Drawing.Point(263, 0);
            this.MinimizeToTray.Name = "MinimizeToTray";
            this.MinimizeToTray.Size = new System.Drawing.Size(24, 25);
            this.MinimizeToTray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeToTray.TabIndex = 16;
            this.MinimizeToTray.TabStop = false;
            this.MinimizeToTray.Click += new System.EventHandler(this.MinimizeToTray_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 368);
            this.Controls.Add(this.MinimizeToTray);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEntrance);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация | АИС Больница";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeToTray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLog;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bEntrance;
        private System.Windows.Forms.ComboBox Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox MinimizeToTray;
    }
}

