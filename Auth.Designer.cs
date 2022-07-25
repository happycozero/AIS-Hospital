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
            this.bExit = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.BackColor = System.Drawing.Color.Transparent;
            this.lLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLog.Location = new System.Drawing.Point(115, 82);
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
            this.bEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEntrance.ForeColor = System.Drawing.Color.Black;
            this.bEntrance.Location = new System.Drawing.Point(43, 276);
            this.bEntrance.Name = "bEntrance";
            this.bEntrance.Size = new System.Drawing.Size(234, 52);
            this.bEntrance.TabIndex = 2;
            this.bEntrance.Text = "Войти";
            this.bEntrance.UseVisualStyleBackColor = false;
            this.bEntrance.Click += new System.EventHandler(this.bEntrance_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(43, 334);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(234, 52);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Login.FormattingEnabled = true;
            this.Login.Location = new System.Drawing.Point(43, 110);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(234, 32);
            this.Login.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пароль:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Image = global::HospitalM.Properties.Resources.Screenshot_11;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(231, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 27);
            this.label12.TabIndex = 9;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 410);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bEntrance);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация | АИС Больница";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLog;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bEntrance;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ComboBox Login;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
    }
}

