
namespace fozde_termekek
{
    partial class login
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
            this.log_name = new System.Windows.Forms.TextBox();
            this.log_passwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // log_name
            // 
            this.log_name.Location = new System.Drawing.Point(103, 29);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(121, 20);
            this.log_name.TabIndex = 2;
            // 
            // log_passwd
            // 
            this.log_passwd.Location = new System.Drawing.Point(103, 67);
            this.log_passwd.Name = "log_passwd";
            this.log_passwd.PasswordChar = '*';
            this.log_passwd.Size = new System.Drawing.Size(121, 20);
            this.log_passwd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó:";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_btn.Location = new System.Drawing.Point(102, 111);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(122, 28);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Bejelentkezés";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 169);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.log_passwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Bejelentkezés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox log_name;
        private System.Windows.Forms.TextBox log_passwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_btn;
    }
}