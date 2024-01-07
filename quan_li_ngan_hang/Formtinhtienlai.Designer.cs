namespace quan_li_ngan_hang
{
    partial class Formtinhtienlai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.btntinhsotienlai = new System.Windows.Forms.Button();
            this.dateTimengaygui = new System.Windows.Forms.DateTimePicker();
            this.dateTimengayrut = new System.Windows.Forms.DateTimePicker();
            this.txtTienLai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày gửi tiền ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày rút tiền ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lãi suất ";
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(169, 73);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(191, 22);
            this.txtsotien.TabIndex = 1;
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Location = new System.Drawing.Point(169, 260);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(191, 22);
            this.txtlaisuat.TabIndex = 1;
            // 
            // btntinhsotienlai
            // 
            this.btntinhsotienlai.Location = new System.Drawing.Point(66, 378);
            this.btntinhsotienlai.Name = "btntinhsotienlai";
            this.btntinhsotienlai.Size = new System.Drawing.Size(176, 42);
            this.btntinhsotienlai.TabIndex = 2;
            this.btntinhsotienlai.Text = "Hiển Thị số tiền lãi ";
            this.btntinhsotienlai.UseVisualStyleBackColor = true;
            this.btntinhsotienlai.Click += new System.EventHandler(this.btntinhsotienlai_Click);
            // 
            // dateTimengaygui
            // 
            this.dateTimengaygui.Location = new System.Drawing.Point(169, 132);
            this.dateTimengaygui.Name = "dateTimengaygui";
            this.dateTimengaygui.Size = new System.Drawing.Size(270, 22);
            this.dateTimengaygui.TabIndex = 3;
            // 
            // dateTimengayrut
            // 
            this.dateTimengayrut.Location = new System.Drawing.Point(169, 194);
            this.dateTimengayrut.Name = "dateTimengayrut";
            this.dateTimengayrut.Size = new System.Drawing.Size(270, 22);
            this.dateTimengayrut.TabIndex = 3;
            // 
            // txtTienLai
            // 
            this.txtTienLai.BackColor = System.Drawing.Color.Red;
            this.txtTienLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienLai.Location = new System.Drawing.Point(172, 313);
            this.txtTienLai.Name = "txtTienLai";
            this.txtTienLai.Size = new System.Drawing.Size(187, 34);
            this.txtTienLai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiền Lãi ";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(284, 378);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 42);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát ";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Formtinhtienlai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTienLai);
            this.Controls.Add(this.dateTimengayrut);
            this.Controls.Add(this.dateTimengaygui);
            this.Controls.Add(this.btntinhsotienlai);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formtinhtienlai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formtinhtienlai";
            this.Load += new System.EventHandler(this.Formtinhtienlai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.Button btntinhsotienlai;
        private System.Windows.Forms.DateTimePicker dateTimengaygui;
        private System.Windows.Forms.DateTimePicker dateTimengayrut;
        private System.Windows.Forms.TextBox txtTienLai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthoat;
    }
}