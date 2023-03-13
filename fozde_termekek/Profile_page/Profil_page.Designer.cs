
namespace fozde_termekek.Profile_page
{
    partial class Profil_page
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
            this.edit_passwd_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edit_passwd_btn
            // 
            this.edit_passwd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_passwd_btn.Location = new System.Drawing.Point(30, 33);
            this.edit_passwd_btn.Name = "edit_passwd_btn";
            this.edit_passwd_btn.Size = new System.Drawing.Size(148, 65);
            this.edit_passwd_btn.TabIndex = 0;
            this.edit_passwd_btn.Text = "Jelszó módosítás";
            this.edit_passwd_btn.UseVisualStyleBackColor = true;
            this.edit_passwd_btn.Click += new System.EventHandler(this.edit_passwd_btn_Click);
            // 
            // Profil_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit_passwd_btn);
            this.Name = "Profil_page";
            this.Text = "Profil_page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profil_page_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button edit_passwd_btn;
    }
}