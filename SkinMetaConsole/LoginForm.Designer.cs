namespace SkinMetaConsole
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button1 = new System.Windows.Forms.Button();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signupCitybox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signupAgebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.signupConfirmPswdbox = new System.Windows.Forms.TextBox();
            this.confirmpswdlabel = new System.Windows.Forms.Label();
            this.signupPswdbox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.signupEmailbox = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.signupNameBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login_button1);
            this.panel1.Controls.Add(this.welcomelabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "To keep connected with us please login with\r\n your personal information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_button1
            // 
            this.login_button1.BackColor = System.Drawing.Color.LightCoral;
            this.login_button1.FlatAppearance.BorderSize = 0;
            this.login_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button1.Location = new System.Drawing.Point(83, 267);
            this.login_button1.Name = "login_button1";
            this.login_button1.Size = new System.Drawing.Size(102, 24);
            this.login_button1.TabIndex = 13;
            this.login_button1.Text = "LOG IN";
            this.login_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.login_button1.UseVisualStyleBackColor = false;
            this.login_button1.Click += new System.EventHandler(this.login_button_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.Location = new System.Drawing.Point(14, 181);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(248, 35);
            this.welcomelabel.TabIndex = 0;
            this.welcomelabel.Text = "WELCOME BACK!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.signupCitybox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.signupAgebox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.signup_button);
            this.panel2.Controls.Add(this.signupConfirmPswdbox);
            this.panel2.Controls.Add(this.confirmpswdlabel);
            this.panel2.Controls.Add(this.signupPswdbox);
            this.panel2.Controls.Add(this.passwordlabel);
            this.panel2.Controls.Add(this.signupEmailbox);
            this.panel2.Controls.Add(this.emaillabel);
            this.panel2.Controls.Add(this.signupNameBox);
            this.panel2.Controls.Add(this.Namelabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(434, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 302);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // signupCitybox
            // 
            this.signupCitybox.BackColor = System.Drawing.Color.FloralWhite;
            this.signupCitybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupCitybox.Location = new System.Drawing.Point(95, 113);
            this.signupCitybox.Name = "signupCitybox";
            this.signupCitybox.Size = new System.Drawing.Size(100, 21);
            this.signupCitybox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "City";
            // 
            // signupAgebox
            // 
            this.signupAgebox.BackColor = System.Drawing.Color.FloralWhite;
            this.signupAgebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupAgebox.Location = new System.Drawing.Point(95, 79);
            this.signupAgebox.Name = "signupAgebox";
            this.signupAgebox.Size = new System.Drawing.Size(100, 21);
            this.signupAgebox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age";
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.LightCoral;
            this.signup_button.FlatAppearance.BorderSize = 0;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(75, 259);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(102, 27);
            this.signup_button.TabIndex = 14;
            this.signup_button.Text = "SIGN UP";
            this.signup_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // signupConfirmPswdbox
            // 
            this.signupConfirmPswdbox.BackColor = System.Drawing.Color.FloralWhite;
            this.signupConfirmPswdbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupConfirmPswdbox.Location = new System.Drawing.Point(95, 213);
            this.signupConfirmPswdbox.Name = "signupConfirmPswdbox";
            this.signupConfirmPswdbox.Size = new System.Drawing.Size(100, 21);
            this.signupConfirmPswdbox.TabIndex = 12;
            // 
            // confirmpswdlabel
            // 
            this.confirmpswdlabel.AutoSize = true;
            this.confirmpswdlabel.Location = new System.Drawing.Point(36, 209);
            this.confirmpswdlabel.Name = "confirmpswdlabel";
            this.confirmpswdlabel.Size = new System.Drawing.Size(53, 26);
            this.confirmpswdlabel.TabIndex = 11;
            this.confirmpswdlabel.Text = "Confirm\r\nPassword";
            this.confirmpswdlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // signupPswdbox
            // 
            this.signupPswdbox.BackColor = System.Drawing.Color.FloralWhite;
            this.signupPswdbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPswdbox.Location = new System.Drawing.Point(95, 179);
            this.signupPswdbox.Name = "signupPswdbox";
            this.signupPswdbox.Size = new System.Drawing.Size(100, 21);
            this.signupPswdbox.TabIndex = 8;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(36, 182);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.passwordlabel.TabIndex = 7;
            this.passwordlabel.Text = "Password";
            // 
            // signupEmailbox
            // 
            this.signupEmailbox.BackColor = System.Drawing.Color.FloralWhite;
            this.signupEmailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupEmailbox.Location = new System.Drawing.Point(95, 145);
            this.signupEmailbox.Name = "signupEmailbox";
            this.signupEmailbox.Size = new System.Drawing.Size(100, 21);
            this.signupEmailbox.TabIndex = 6;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(54, 148);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(32, 13);
            this.emaillabel.TabIndex = 5;
            this.emaillabel.Text = "Email";
            // 
            // signupNameBox
            // 
            this.signupNameBox.BackColor = System.Drawing.Color.FloralWhite;
            this.signupNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupNameBox.Location = new System.Drawing.Point(95, 46);
            this.signupNameBox.Name = "signupNameBox";
            this.signupNameBox.Size = new System.Drawing.Size(100, 21);
            this.signupNameBox.TabIndex = 4;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(54, 49);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create an Account\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "SkinMeta";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signupPswdbox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox signupEmailbox;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox signupNameBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox signupConfirmPswdbox;
        private System.Windows.Forms.Label confirmpswdlabel;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button login_button1;
        private System.Windows.Forms.TextBox signupCitybox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signupAgebox;
        private System.Windows.Forms.Label label5;
    }
}