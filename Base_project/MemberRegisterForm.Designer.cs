namespace Base_project
{
    partial class MemberRegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_domain = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_email = new System.Windows.Forms.TextBox();
            this.tbox_pw = new System.Windows.Forms.TextBox();
            this.tbox_id = new System.Windows.Forms.TextBox();
            this.tbox_snum = new System.Windows.Forms.TextBox();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox_domain);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbox_email);
            this.groupBox1.Controls.Add(this.tbox_pw);
            this.groupBox1.Controls.Add(this.tbox_id);
            this.groupBox1.Controls.Add(this.tbox_snum);
            this.groupBox1.Controls.Add(this.tbox_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원가입";
            // 
            // cbox_domain
            // 
            this.cbox_domain.FormattingEnabled = true;
            this.cbox_domain.Location = new System.Drawing.Point(225, 194);
            this.cbox_domain.Name = "cbox_domain";
            this.cbox_domain.Size = new System.Drawing.Size(113, 20);
            this.cbox_domain.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "@";
            // 
            // tbox_email
            // 
            this.tbox_email.Location = new System.Drawing.Point(104, 194);
            this.tbox_email.Name = "tbox_email";
            this.tbox_email.Size = new System.Drawing.Size(91, 21);
            this.tbox_email.TabIndex = 9;
            // 
            // tbox_pw
            // 
            this.tbox_pw.Location = new System.Drawing.Point(104, 157);
            this.tbox_pw.Name = "tbox_pw";
            this.tbox_pw.Size = new System.Drawing.Size(234, 21);
            this.tbox_pw.TabIndex = 8;
            // 
            // tbox_id
            // 
            this.tbox_id.Location = new System.Drawing.Point(104, 120);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.Size = new System.Drawing.Size(234, 21);
            this.tbox_id.TabIndex = 7;
            // 
            // tbox_snum
            // 
            this.tbox_snum.Location = new System.Drawing.Point(104, 83);
            this.tbox_snum.Name = "tbox_snum";
            this.tbox_snum.Size = new System.Drawing.Size(234, 21);
            this.tbox_snum.TabIndex = 6;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(104, 46);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(234, 21);
            this.tbox_name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "이메일 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "비밀번호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "아이디 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "학번 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(52, 267);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(299, 31);
            this.btn_reg.TabIndex = 1;
            this.btn_reg.Text = "가입하기";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // MemberRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(392, 324);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MemberRegisterForm";
            this.Text = "MemberRegisterForm";
            this.Load += new System.EventHandler(this.MemberRegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_domain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_email;
        private System.Windows.Forms.TextBox tbox_pw;
        private System.Windows.Forms.TextBox tbox_id;
        private System.Windows.Forms.TextBox tbox_snum;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Button btn_reg;
    }
}