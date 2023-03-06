namespace HospitalM
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.bExit = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DateVoucher = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmPost = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.DatePatient = new System.Windows.Forms.DateTimePicker();
            this.textPatronymicPatient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textNamePatient = new System.Windows.Forms.TextBox();
            this.textSurnamePatient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmFormControl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNums = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.bExit, "bExit");
            this.bExit.Name = "bExit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DateVoucher);
            this.tabPage3.Controls.Add(this.Time);
            this.tabPage3.Controls.Add(this.tbNumber);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DateVoucher
            // 
            resources.ApplyResources(this.DateVoucher, "DateVoucher");
            this.DateVoucher.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateVoucher.Name = "DateVoucher";
            // 
            // Time
            // 
            resources.ApplyResources(this.Time, "Time");
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time.Name = "Time";
            // 
            // tbNumber
            // 
            resources.ApplyResources(this.tbNumber, "tbNumber");
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNum_KeyPress);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmPost);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbNum);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbOtch);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.tbFam);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmPost
            // 
            this.cmPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmPost, "cmPost");
            this.cmPost.FormattingEnabled = true;
            this.cmPost.Items.AddRange(new object[] {
            resources.GetString("cmPost.Items"),
            resources.GetString("cmPost.Items1"),
            resources.GetString("cmPost.Items2"),
            resources.GetString("cmPost.Items3"),
            resources.GetString("cmPost.Items4"),
            resources.GetString("cmPost.Items5"),
            resources.GetString("cmPost.Items6"),
            resources.GetString("cmPost.Items7"),
            resources.GetString("cmPost.Items8"),
            resources.GetString("cmPost.Items9"),
            resources.GetString("cmPost.Items10")});
            this.cmPost.Name = "cmPost";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tbNum
            // 
            resources.ApplyResources(this.tbNum, "tbNum");
            this.tbNum.Name = "tbNum";
            this.tbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNum_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbOtch
            // 
            resources.ApplyResources(this.tbOtch, "tbOtch");
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFam_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFam_KeyPress);
            // 
            // tbFam
            // 
            resources.ApplyResources(this.tbFam, "tbFam");
            this.tbFam.Name = "tbFam";
            this.tbFam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFam_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.DatePatient);
            this.tabPage2.Controls.Add(this.textPatronymicPatient);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textNamePatient);
            this.tabPage2.Controls.Add(this.textSurnamePatient);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cmFormControl);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbNums);
            this.tabPage2.Controls.Add(this.label9);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // DatePatient
            // 
            resources.ApplyResources(this.DatePatient, "DatePatient");
            this.DatePatient.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePatient.Name = "DatePatient";
            // 
            // textPatronymicPatient
            // 
            resources.ApplyResources(this.textPatronymicPatient, "textPatronymicPatient");
            this.textPatronymicPatient.Name = "textPatronymicPatient";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textNamePatient
            // 
            resources.ApplyResources(this.textNamePatient, "textNamePatient");
            this.textNamePatient.Name = "textNamePatient";
            // 
            // textSurnamePatient
            // 
            resources.ApplyResources(this.textSurnamePatient, "textSurnamePatient");
            this.textSurnamePatient.Name = "textSurnamePatient";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // cmFormControl
            // 
            this.cmFormControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmFormControl, "cmFormControl");
            this.cmFormControl.FormattingEnabled = true;
            this.cmFormControl.Items.AddRange(new object[] {
            resources.GetString("cmFormControl.Items"),
            resources.GetString("cmFormControl.Items1"),
            resources.GetString("cmFormControl.Items2"),
            resources.GetString("cmFormControl.Items3"),
            resources.GetString("cmFormControl.Items4"),
            resources.GetString("cmFormControl.Items5"),
            resources.GetString("cmFormControl.Items6"),
            resources.GetString("cmFormControl.Items7"),
            resources.GetString("cmFormControl.Items8"),
            resources.GetString("cmFormControl.Items9"),
            resources.GetString("cmFormControl.Items10")});
            this.cmFormControl.Name = "cmFormControl";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tbNums
            // 
            resources.ApplyResources(this.tbNums, "tbNums");
            this.tbNums.Name = "tbNums";
            this.tbNums.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNum_KeyPress);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.bAdd, "bAdd");
            this.bAdd.Name = "bAdd";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // bClear
            // 
            resources.ApplyResources(this.bClear, "bClear");
            this.bClear.Name = "bClear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox1.Image = global::HospitalM.Properties.Resources.exit;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bExit);
            this.Name = "Add";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DateTimePicker DateVoucher;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmPost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmFormControl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNums;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.DateTimePicker DatePatient;
        private System.Windows.Forms.TextBox textPatronymicPatient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textNamePatient;
        private System.Windows.Forms.TextBox textSurnamePatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}