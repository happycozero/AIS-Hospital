namespace HospitalM
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.rbMedic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.rbPatient = new System.Windows.Forms.RadioButton();
            this.rbVoucher = new System.Windows.Forms.RadioButton();
            this.lCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInfo.Location = new System.Drawing.Point(193, 76);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(964, 405);
            this.dataGridViewInfo.TabIndex = 0;
            this.dataGridViewInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInfo_CellContentClick);
            // 
            // rbMedic
            // 
            this.rbMedic.AutoSize = true;
            this.rbMedic.BackColor = System.Drawing.Color.Transparent;
            this.rbMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbMedic.Location = new System.Drawing.Point(12, 202);
            this.rbMedic.Name = "rbMedic";
            this.rbMedic.Size = new System.Drawing.Size(82, 28);
            this.rbMedic.TabIndex = 1;
            this.rbMedic.TabStop = true;
            this.rbMedic.Text = "Врачи";
            this.rbMedic.UseVisualStyleBackColor = false;
            this.rbMedic.CheckedChanged += new System.EventHandler(this.rbMedic_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(8, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите таблицу для просмотра:";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(12, 440);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(138, 41);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // rbPatient
            // 
            this.rbPatient.AutoSize = true;
            this.rbPatient.BackColor = System.Drawing.Color.Transparent;
            this.rbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbPatient.Location = new System.Drawing.Point(12, 236);
            this.rbPatient.Name = "rbPatient";
            this.rbPatient.Size = new System.Drawing.Size(118, 28);
            this.rbPatient.TabIndex = 4;
            this.rbPatient.TabStop = true;
            this.rbPatient.Text = "Пациенты";
            this.rbPatient.UseVisualStyleBackColor = false;
            this.rbPatient.CheckedChanged += new System.EventHandler(this.rbPatient_CheckedChanged);
            // 
            // rbVoucher
            // 
            this.rbVoucher.AutoSize = true;
            this.rbVoucher.BackColor = System.Drawing.Color.Transparent;
            this.rbVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbVoucher.Location = new System.Drawing.Point(12, 270);
            this.rbVoucher.Name = "rbVoucher";
            this.rbVoucher.Size = new System.Drawing.Size(123, 28);
            this.rbVoucher.TabIndex = 5;
            this.rbVoucher.TabStop = true;
            this.rbVoucher.Text = "Талончики";
            this.rbVoucher.UseVisualStyleBackColor = false;
            this.rbVoucher.CheckedChanged += new System.EventHandler(this.rbVoucher_CheckedChanged);
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lCount.Location = new System.Drawing.Point(205, 431);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(0, 24);
            this.lCount.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Image = global::HospitalM.Properties.Resources.Screenshot_11;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(1046, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 27);
            this.label12.TabIndex = 10;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 498);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.rbVoucher);
            this.Controls.Add(this.rbPatient);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbMedic);
            this.Controls.Add(this.dataGridViewInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр БД | АИС Больница";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Info_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.RadioButton rbMedic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.RadioButton rbPatient;
        private System.Windows.Forms.RadioButton rbVoucher;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label label12;
    }
}