
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
            this.kisz_term_btn = new System.Windows.Forms.Button();
            this.new_kisz_btn = new System.Windows.Forms.Button();
            this.rendeles_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edit_passwd_btn
            // 
            this.edit_passwd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_passwd_btn.Location = new System.Drawing.Point(2, 3);
            this.edit_passwd_btn.Name = "edit_passwd_btn";
            this.edit_passwd_btn.Size = new System.Drawing.Size(148, 65);
            this.edit_passwd_btn.TabIndex = 0;
            this.edit_passwd_btn.Text = "Jelszó módosítás";
            this.edit_passwd_btn.UseVisualStyleBackColor = true;
            this.edit_passwd_btn.Click += new System.EventHandler(this.edit_passwd_btn_Click);
            // 
            // kisz_term_btn
            // 
            this.kisz_term_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kisz_term_btn.Location = new System.Drawing.Point(2, 84);
            this.kisz_term_btn.Name = "kisz_term_btn";
            this.kisz_term_btn.Size = new System.Drawing.Size(176, 65);
            this.kisz_term_btn.TabIndex = 1;
            this.kisz_term_btn.Text = "Kiszerelés és termék kezelés";
            this.kisz_term_btn.UseVisualStyleBackColor = true;
            this.kisz_term_btn.Visible = false;
            this.kisz_term_btn.Click += new System.EventHandler(this.kisz_term_btn_Click);
            // 
            // new_kisz_btn
            // 
            this.new_kisz_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_kisz_btn.Location = new System.Drawing.Point(184, 84);
            this.new_kisz_btn.Name = "new_kisz_btn";
            this.new_kisz_btn.Size = new System.Drawing.Size(176, 65);
            this.new_kisz_btn.TabIndex = 2;
            this.new_kisz_btn.Text = "Új kiszerelés hozzáadás";
            this.new_kisz_btn.UseVisualStyleBackColor = true;
            this.new_kisz_btn.Visible = false;
            this.new_kisz_btn.Click += new System.EventHandler(this.new_kisz_btn_Click);
            // 
            // rendeles_btn
            // 
            this.rendeles_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rendeles_btn.Location = new System.Drawing.Point(156, 3);
            this.rendeles_btn.Name = "rendeles_btn";
            this.rendeles_btn.Size = new System.Drawing.Size(204, 65);
            this.rendeles_btn.TabIndex = 3;
            this.rendeles_btn.Text = "Rendelés";
            this.rendeles_btn.UseVisualStyleBackColor = true;
            this.rendeles_btn.Click += new System.EventHandler(this.rendeles_btn_Click);
            // 
            // Profil_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 150);
            this.Controls.Add(this.rendeles_btn);
            this.Controls.Add(this.new_kisz_btn);
            this.Controls.Add(this.kisz_term_btn);
            this.Controls.Add(this.edit_passwd_btn);
            this.Name = "Profil_page";
            this.Text = "Profil_page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profil_page_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button edit_passwd_btn;
        private System.Windows.Forms.Button kisz_term_btn;
        private System.Windows.Forms.Button new_kisz_btn;
        private System.Windows.Forms.Button rendeles_btn;
    }
}