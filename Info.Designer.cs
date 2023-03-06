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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.rbMedic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.rbPatient = new System.Windows.Forms.RadioButton();
            this.rbVoucher = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewInfo.Location = new System.Drawing.Point(219, 92);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(932, 367);
            this.dataGridViewInfo.TabIndex = 7;
            // 
            // rbMedic
            // 
            this.rbMedic.AutoSize = true;
            this.rbMedic.BackColor = System.Drawing.Color.Transparent;
            this.rbMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbMedic.Location = new System.Drawing.Point(12, 150);
            this.rbMedic.Name = "rbMedic";
            this.rbMedic.Size = new System.Drawing.Size(82, 28);
            this.rbMedic.TabIndex = 1;
            this.rbMedic.TabStop = true;
            this.rbMedic.Text = "Врачи";
            this.rbMedic.UseVisualStyleBackColor = false;
            this.rbMedic.CheckedChanged += new System.EventHandler(this.RbMedic_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите таблицу для просмотра:";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(12, 418);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(138, 41);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // rbPatient
            // 
            this.rbPatient.AutoSize = true;
            this.rbPatient.BackColor = System.Drawing.Color.Transparent;
            this.rbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbPatient.Location = new System.Drawing.Point(12, 184);
            this.rbPatient.Name = "rbPatient";
            this.rbPatient.Size = new System.Drawing.Size(118, 28);
            this.rbPatient.TabIndex = 4;
            this.rbPatient.TabStop = true;
            this.rbPatient.Text = "Пациенты";
            this.rbPatient.UseVisualStyleBackColor = false;
            this.rbPatient.CheckedChanged += new System.EventHandler(this.RbPatient_CheckedChanged);
            // 
            // rbVoucher
            // 
            this.rbVoucher.AutoSize = true;
            this.rbVoucher.BackColor = System.Drawing.Color.Transparent;
            this.rbVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbVoucher.Location = new System.Drawing.Point(12, 218);
            this.rbVoucher.Name = "rbVoucher";
            this.rbVoucher.Size = new System.Drawing.Size(123, 28);
            this.rbVoucher.TabIndex = 5;
            this.rbVoucher.TabStop = true;
            this.rbVoucher.Text = "Талончики";
            this.rbVoucher.UseVisualStyleBackColor = false;
            this.rbVoucher.CheckedChanged += new System.EventHandler(this.RbVoucher_CheckedChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(1063, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 27);
            this.label12.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox1.Image = global::HospitalM.Properties.Resources.exit;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1139, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbVoucher);
            this.Controls.Add(this.rbPatient);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbMedic);
            this.Controls.Add(this.dataGridViewInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр БД | АИС Больница";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}