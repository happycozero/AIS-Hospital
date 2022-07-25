namespace HospitalM
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bExit = new System.Windows.Forms.Button();
            this.bReg = new System.Windows.Forms.Button();
            this.bInfo = new System.Windows.Forms.Button();
            this.bAddInfo = new System.Windows.Forms.Button();
            this.bEditInfo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(12, 388);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(367, 52);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bReg
            // 
            this.bReg.BackColor = System.Drawing.SystemColors.Control;
            this.bReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReg.Location = new System.Drawing.Point(13, 242);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(366, 49);
            this.bReg.TabIndex = 5;
            this.bReg.Text = "Пользователи БД";
            this.bReg.UseVisualStyleBackColor = false;
            this.bReg.Click += new System.EventHandler(this.bReg_Click);
            // 
            // bInfo
            // 
            this.bInfo.BackColor = System.Drawing.SystemColors.Control;
            this.bInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bInfo.Location = new System.Drawing.Point(13, 74);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(366, 52);
            this.bInfo.TabIndex = 6;
            this.bInfo.Text = "Просмотр информации в БД";
            this.bInfo.UseVisualStyleBackColor = false;
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // bAddInfo
            // 
            this.bAddInfo.BackColor = System.Drawing.SystemColors.Control;
            this.bAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddInfo.Location = new System.Drawing.Point(13, 132);
            this.bAddInfo.Name = "bAddInfo";
            this.bAddInfo.Size = new System.Drawing.Size(366, 49);
            this.bAddInfo.TabIndex = 7;
            this.bAddInfo.Text = "Добавление информации в БД";
            this.bAddInfo.UseVisualStyleBackColor = false;
            this.bAddInfo.Click += new System.EventHandler(this.bAddInfo_Click);
            // 
            // bEditInfo
            // 
            this.bEditInfo.BackColor = System.Drawing.SystemColors.Control;
            this.bEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditInfo.Location = new System.Drawing.Point(13, 187);
            this.bEditInfo.Name = "bEditInfo";
            this.bEditInfo.Size = new System.Drawing.Size(366, 49);
            this.bEditInfo.TabIndex = 8;
            this.bEditInfo.Text = "Удаление и редактирование в БД";
            this.bEditInfo.UseVisualStyleBackColor = false;
            this.bEditInfo.Click += new System.EventHandler(this.bEditInfo_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Image = global::HospitalM.Properties.Resources.Screenshot_11;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(328, -3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 27);
            this.label12.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 452);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bEditInfo);
            this.Controls.Add(this.bAddInfo);
            this.Controls.Add(this.bInfo);
            this.Controls.Add(this.bReg);
            this.Controls.Add(this.bExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню | АИС Больница";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bReg;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Button bAddInfo;
        private System.Windows.Forms.Button bEditInfo;
        private System.Windows.Forms.Label label12;
    }
}