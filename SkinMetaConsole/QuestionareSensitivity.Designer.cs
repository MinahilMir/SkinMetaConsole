using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace SkinMetaConsole
{
    partial class QuestionareSensitivity
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.skinsensitivityQ3O4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.skinsensitivityQ3O3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.skinsensitivityQ3O2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.skinsensitivityQ3O1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.skinsensitivityQ2O4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.skinsensitivityQ2O3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.skinsensitivityQ2O1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.skinsensitivityQ2O2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinsensitivityQ1O4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.skinsensitivityQ1O3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.skinsensitivityQ1O2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.skinsensitivityQ1O1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 451);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.skinsensitivityQ3O4);
            this.panel3.Controls.Add(this.skinsensitivityQ3O3);
            this.panel3.Controls.Add(this.skinsensitivityQ3O2);
            this.panel3.Controls.Add(this.skinsensitivityQ3O1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(546, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 267);
            this.panel3.TabIndex = 10;
            // 
            // skinsensitivityQ3O4
            // 
            this.skinsensitivityQ3O4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ3O4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ3O4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ3O4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ3O4.FillColor = System.Drawing.Color.DarkSalmon;
            this.skinsensitivityQ3O4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ3O4.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ3O4.Location = new System.Drawing.Point(116, 168);
            this.skinsensitivityQ3O4.Name = "skinsensitivityQ3O4";
            this.skinsensitivityQ3O4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ3O4.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ3O4.TabIndex = 8;
            this.skinsensitivityQ3O4.Text = "Don\'t Know";
            this.skinsensitivityQ3O4.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // skinsensitivityQ3O3
            // 
            this.skinsensitivityQ3O3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ3O3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ3O3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ3O3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ3O3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(128)))));
            this.skinsensitivityQ3O3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ3O3.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ3O3.Location = new System.Drawing.Point(17, 168);
            this.skinsensitivityQ3O3.Name = "skinsensitivityQ3O3";
            this.skinsensitivityQ3O3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ3O3.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ3O3.TabIndex = 7;
            this.skinsensitivityQ3O3.Text = "Not at all";
            this.skinsensitivityQ3O3.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // skinsensitivityQ3O2
            // 
            this.skinsensitivityQ3O2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ3O2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ3O2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ3O2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ3O2.FillColor = System.Drawing.Color.LightSalmon;
            this.skinsensitivityQ3O2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ3O2.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ3O2.Location = new System.Drawing.Point(116, 70);
            this.skinsensitivityQ3O2.Name = "skinsensitivityQ3O2";
            this.skinsensitivityQ3O2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ3O2.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ3O2.TabIndex = 6;
            this.skinsensitivityQ3O2.Text = "Occasionally";
            this.skinsensitivityQ3O2.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // skinsensitivityQ3O1
            // 
            this.skinsensitivityQ3O1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ3O1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ3O1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ3O1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ3O1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.skinsensitivityQ3O1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ3O1.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ3O1.Location = new System.Drawing.Point(17, 70);
            this.skinsensitivityQ3O1.Name = "skinsensitivityQ3O1";
            this.skinsensitivityQ3O1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ3O1.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ3O1.TabIndex = 5;
            this.skinsensitivityQ3O1.Text = "Yes Very Sensitive";
            this.skinsensitivityQ3O1.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Are you sensitive to \r\nfragranced products?";
            // 
            // panel5
            // 
            this.panel5.AllowDrop = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.skinsensitivityQ2O4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.skinsensitivityQ2O3);
            this.panel5.Controls.Add(this.skinsensitivityQ2O1);
            this.panel5.Controls.Add(this.skinsensitivityQ2O2);
            this.panel5.Location = new System.Drawing.Point(292, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 267);
            this.panel5.TabIndex = 9;
            // 
            // skinsensitivityQ2O4
            // 
            this.skinsensitivityQ2O4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ2O4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ2O4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ2O4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ2O4.FillColor = System.Drawing.Color.DarkSalmon;
            this.skinsensitivityQ2O4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ2O4.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ2O4.Location = new System.Drawing.Point(116, 168);
            this.skinsensitivityQ2O4.Name = "skinsensitivityQ2O4";
            this.skinsensitivityQ2O4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ2O4.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ2O4.TabIndex = 8;
            this.skinsensitivityQ2O4.Text = "Don\'t Know";
            this.skinsensitivityQ2O4.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Do you experience redness, \r\nitching or irritation?\r\n";
            // 
            // skinsensitivityQ2O3
            // 
            this.skinsensitivityQ2O3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ2O3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ2O3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ2O3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ2O3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(128)))));
            this.skinsensitivityQ2O3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ2O3.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ2O3.Location = new System.Drawing.Point(17, 168);
            this.skinsensitivityQ2O3.Name = "skinsensitivityQ2O3";
            this.skinsensitivityQ2O3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ2O3.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ2O3.TabIndex = 7;
            this.skinsensitivityQ2O3.Text = "Rarely";
            this.skinsensitivityQ2O3.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // skinsensitivityQ2O1
            // 
            this.skinsensitivityQ2O1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ2O1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ2O1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ2O1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ2O1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.skinsensitivityQ2O1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ2O1.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ2O1.Location = new System.Drawing.Point(17, 70);
            this.skinsensitivityQ2O1.Name = "skinsensitivityQ2O1";
            this.skinsensitivityQ2O1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ2O1.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ2O1.TabIndex = 5;
            this.skinsensitivityQ2O1.Text = "Yes Often";
            this.skinsensitivityQ2O1.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // skinsensitivityQ2O2
            // 
            this.skinsensitivityQ2O2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ2O2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ2O2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ2O2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ2O2.FillColor = System.Drawing.Color.LightSalmon;
            this.skinsensitivityQ2O2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ2O2.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ2O2.Location = new System.Drawing.Point(116, 70);
            this.skinsensitivityQ2O2.Name = "skinsensitivityQ2O2";
            this.skinsensitivityQ2O2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ2O2.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ2O2.TabIndex = 6;
            this.skinsensitivityQ2O2.Text = "Sometimes";
            this.skinsensitivityQ2O2.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.skinsensitivityQ1O4);
            this.panel2.Controls.Add(this.skinsensitivityQ1O3);
            this.panel2.Controls.Add(this.skinsensitivityQ1O2);
            this.panel2.Controls.Add(this.skinsensitivityQ1O1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(37, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 267);
            this.panel2.TabIndex = 8;
            // 
            // skinsensitivityQ1O4
            // 
            this.skinsensitivityQ1O4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ1O4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ1O4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ1O4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ1O4.FillColor = System.Drawing.Color.DarkSalmon;
            this.skinsensitivityQ1O4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ1O4.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ1O4.Location = new System.Drawing.Point(117, 168);
            this.skinsensitivityQ1O4.Name = "skinsensitivityQ1O4";
            this.skinsensitivityQ1O4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ1O4.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ1O4.TabIndex = 4;
            this.skinsensitivityQ1O4.Text = "Don\'t Know";
            this.skinsensitivityQ1O4.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // skinsensitivityQ1O3
            // 
            this.skinsensitivityQ1O3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ1O3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ1O3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ1O3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ1O3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(128)))));
            this.skinsensitivityQ1O3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ1O3.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ1O3.Location = new System.Drawing.Point(18, 168);
            this.skinsensitivityQ1O3.Name = "skinsensitivityQ1O3";
            this.skinsensitivityQ1O3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ1O3.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ1O3.TabIndex = 3;
            this.skinsensitivityQ1O3.Text = "No Reaction";
            this.skinsensitivityQ1O3.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // skinsensitivityQ1O2
            // 
            this.skinsensitivityQ1O2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ1O2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ1O2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ1O2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ1O2.FillColor = System.Drawing.Color.LightSalmon;
            this.skinsensitivityQ1O2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ1O2.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ1O2.Location = new System.Drawing.Point(117, 70);
            this.skinsensitivityQ1O2.Name = "skinsensitivityQ1O2";
            this.skinsensitivityQ1O2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ1O2.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ1O2.TabIndex = 2;
            this.skinsensitivityQ1O2.Text = "Mild Irritation";
            this.skinsensitivityQ1O2.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // skinsensitivityQ1O1
            // 
            this.skinsensitivityQ1O1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ1O1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.skinsensitivityQ1O1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.skinsensitivityQ1O1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.skinsensitivityQ1O1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.skinsensitivityQ1O1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.skinsensitivityQ1O1.ForeColor = System.Drawing.Color.White;
            this.skinsensitivityQ1O1.Location = new System.Drawing.Point(18, 70);
            this.skinsensitivityQ1O1.Name = "skinsensitivityQ1O1";
            this.skinsensitivityQ1O1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.skinsensitivityQ1O1.Size = new System.Drawing.Size(84, 84);
            this.skinsensitivityQ1O1.TabIndex = 1;
            this.skinsensitivityQ1O1.Text = "Yes Strong Reaction";
            this.skinsensitivityQ1O1.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Does your skin react to\r\nnew products?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Let us help you find the best product for you...\r\n";
            // 
            // QuestionareSensitivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionareSensitivity";
            this.Text = "QuestionareSensitivity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ3O4;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ3O3;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ3O2;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ3O1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ2O4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ2O3;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ2O1;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ2O2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ1O4;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ1O3;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ1O2;
        private Guna.UI2.WinForms.Guna2CircleButton skinsensitivityQ1O1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public void SensitivityForm()
        {
            InitializeComponent();
        }
        private Dictionary<int, int> userAnswers = new Dictionary<int, int>();

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            // Cast to the correct control type
            Guna.UI2.WinForms.Guna2CircleButton btn = sender as Guna.UI2.WinForms.Guna2CircleButton;
            if (btn == null) return;
            string selectedAnswer = btn.Text; // Get text from button

            // Determine the question ID based on the button name
            int questionId = 0;
            // Extract question number from button name (e.g., skintypeQ1O1 -> Question 1)
            string buttonName = btn.Name;
            if (buttonName.Contains("Q1")) questionId = 4;
            else if (buttonName.Contains("Q2")) questionId = 5;
            else if (buttonName.Contains("Q3")) questionId = 6;

            // Get answer ID from database or map based on selection
            int answerId = GetAnswerId(questionId, selectedAnswer);

            // Get the user ID from the database using the stored email
            int userId = GetUserIdFromDatabase(CurrentUser.Email);
            if (userId == 0)
            {
                MessageBox.Show("Error: Unable to identify the current user. Please log in again.",
                                "User Identification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fixed category ID for skin type
            int categoryId = 2;

            // Store answer in the dictionary
            userAnswers[questionId] = answerId;

            // Check if all three answers are provided
            if (userAnswers.Count == 3)
            {
                // Save all answers before moving to the next form
                foreach (var entry in userAnswers)
                {
                    SaveAnswer(userId, entry.Key, entry.Value, categoryId);
                }

                // Navigate to the next form *only after storing all answers*
                //this.Invoke((MethodInvoker)delegate
                //{
                //    this.Hide();
                //    QuetionareAcne skinAcne = new QuetionareAcne();
                //    skinAcne.Show();
                //});
            }
        }
        // Helper method to get answer ID based on question and selected text
        private int GetAnswerId(int questionId, string answerText)
        {
            // Trim whitespace and standardize for comparison
            string cleanedAnswer = answerText.Trim();

            // Debug information to see what's being received
            Console.WriteLine($"Looking for match: Q{questionId}, Answer: '{cleanedAnswer}'");

            if (questionId == 4) // "How would you describe your Skin Type?"
            {
                if (cleanedAnswer.Equals("Yes Strong Reaction", StringComparison.OrdinalIgnoreCase)) return 13;
                if (cleanedAnswer.Equals("Mild Irritation", StringComparison.OrdinalIgnoreCase)) return 14;
                if (cleanedAnswer.Equals("No Reaction", StringComparison.OrdinalIgnoreCase)) return 15;
                if (cleanedAnswer.Equals("Don't Know", StringComparison.OrdinalIgnoreCase)) return 16;
            }
            else if (questionId == 5) // "How would you describe your skin texture?"
            {
                if (cleanedAnswer.Equals("Yes Often", StringComparison.OrdinalIgnoreCase)) return 17;
                if (cleanedAnswer.Equals("Sometimes", StringComparison.OrdinalIgnoreCase)) return 18;
                if (cleanedAnswer.Equals("Rarely", StringComparison.OrdinalIgnoreCase)) return 19;
                if (cleanedAnswer.Equals("Don't Know", StringComparison.OrdinalIgnoreCase)) return 20;
            }
            else if (questionId == 6) // "How does your skin feel after washing?"
            {
                if (cleanedAnswer.Equals("Yes Very Sensitive", StringComparison.OrdinalIgnoreCase)) return 21;
                if (cleanedAnswer.Equals("Occasionally", StringComparison.OrdinalIgnoreCase)) return 22;
                if (cleanedAnswer.Equals("Not at all", StringComparison.OrdinalIgnoreCase)) return 23;
                if (cleanedAnswer.Equals("Don't Know", StringComparison.OrdinalIgnoreCase)) return 24;
            }

            // Show the exact text received to help debug
            MessageBox.Show($"No matching answer ID found for question {questionId} and answer '{cleanedAnswer}' (length: {cleanedAnswer.Length})",
                "Answer Mapping Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }

        // Save answer to database
        private void SaveAnswer(int userId, int questionId, int answerId, int categoryId)
        {
            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO UserResponses (UserID, QuestionID, AnswerID, CategoryID) " +
                                  "VALUES (@uid, @qid, @aid, @catid)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uid", userId);
                        cmd.Parameters.AddWithValue("@qid", questionId);
                        cmd.Parameters.AddWithValue("@aid", answerId);
                        cmd.Parameters.AddWithValue("@catid", categoryId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Add this method to retrieve the user ID from the database
        private int GetUserIdFromDatabase(string email)
        {
            int userId = 0;

            try
            {
                using (SqlConnection con = DatabaseHelper.GetConnection())
                {
                    con.Open();
                    string query = "SELECT UserID FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Change this line to match the parameter name in the query exactly
                        cmd.Parameters.AddWithValue("@Email", email);
                        // Or if you keep your original approach:
                        // cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = Email;



                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving user ID: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return userId;
        }
    }
}