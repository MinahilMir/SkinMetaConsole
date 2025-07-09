namespace SkinMetaConsole
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SkinMeta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.start_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SkinMeta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 446);
            this.panel1.TabIndex = 0;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.LightCoral;
            this.start_button.FlatAppearance.BorderSize = 0;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(75, 250);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(102, 27);
            this.start_button.TabIndex = 10;
            this.start_button.Text = "START";
            this.start_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your ultimate skincare companion for personalized \nroutines, expert tips, and hea" +
    "lthy, glowing skin.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SkinMeta
            // 
            this.SkinMeta.AutoSize = true;
            this.SkinMeta.BackColor = System.Drawing.Color.MistyRose;
            this.SkinMeta.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkinMeta.Location = new System.Drawing.Point(31, 144);
            this.SkinMeta.Name = "SkinMeta";
            this.SkinMeta.Size = new System.Drawing.Size(226, 62);
            this.SkinMeta.TabIndex = 1;
            this.SkinMeta.Text = "SkinMeta\r\n";
            this.SkinMeta.Click += new System.EventHandler(this.start_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkinMetaConsole.Properties.Resources.Jade_roller_and_gua_sha_stone;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 443);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 442);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SkinMeta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_button;
    }
}

