
namespace fozde_termekek.Profile_page.Profil_Passwd_Mod
{
    partial class Passwd_Mod
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
            this.passmod_btn = new System.Windows.Forms.Button();
            this.new_pass_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.old_pass = new System.Windows.Forms.TextBox();
            this.oldpass_lb = new System.Windows.Forms.Label();
            this.new_pass_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passmod_btn
            // 
            this.passmod_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passmod_btn.Location = new System.Drawing.Point(100, 142);
            this.passmod_btn.Name = "passmod_btn";
            this.passmod_btn.Size = new System.Drawing.Size(122, 62);
            this.passmod_btn.TabIndex = 10;
            this.passmod_btn.Text = "Jelszó módosítás";
            this.passmod_btn.UseVisualStyleBackColor = true;
            this.passmod_btn.Click += new System.EventHandler(this.passmod_btn_Click);
            // 
            // new_pass_1
            // 
            this.new_pass_1.Location = new System.Drawing.Point(101, 83);
            this.new_pass_1.Name = "new_pass_1";
            this.new_pass_1.PasswordChar = '*';
            this.new_pass_1.Size = new System.Drawing.Size(121, 20);
            this.new_pass_1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Új jelszó:";
            // 
            // old_pass
            // 
            this.old_pass.Location = new System.Drawing.Point(101, 45);
            this.old_pass.Name = "old_pass";
            this.old_pass.PasswordChar = '*';
            this.old_pass.Size = new System.Drawing.Size(121, 20);
            this.old_pass.TabIndex = 7;
            // 
            // oldpass_lb
            // 
            this.oldpass_lb.AutoSize = true;
            this.oldpass_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oldpass_lb.Location = new System.Drawing.Point(5, 45);
            this.oldpass_lb.Name = "oldpass_lb";
            this.oldpass_lb.Size = new System.Drawing.Size(90, 20);
            this.oldpass_lb.TabIndex = 6;
            this.oldpass_lb.Text = "Régi jelszó:";
            // 
            // new_pass_2
            // 
            this.new_pass_2.Location = new System.Drawing.Point(101, 116);
            this.new_pass_2.Name = "new_pass_2";
            this.new_pass_2.PasswordChar = '*';
            this.new_pass_2.Size = new System.Drawing.Size(121, 20);
            this.new_pass_2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Új jelszó:";
            // 
            // Passwd_Mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 224);
            this.Controls.Add(this.new_pass_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passmod_btn);
            this.Controls.Add(this.new_pass_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.oldpass_lb);
            this.Name = "Passwd_Mod";
            this.Text = "Passwd_Mod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passmod_btn;
        private System.Windows.Forms.TextBox new_pass_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox old_pass;
        private System.Windows.Forms.Label oldpass_lb;
        private System.Windows.Forms.TextBox new_pass_2;
        private System.Windows.Forms.Label label1;
    }
}