﻿namespace обработчик_результатов
{
    partial class Loginform
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
            this.Вход = new System.Windows.Forms.Label();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Вход
            // 
            this.Вход.AutoSize = true;
            this.Вход.Font = new System.Drawing.Font("Segoe Print", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вход.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Вход.Location = new System.Drawing.Point(206, 117);
            this.Вход.Name = "Вход";
            this.Вход.Size = new System.Drawing.Size(135, 75);
            this.Вход.TabIndex = 2;
            this.Вход.Text = "Вход";
            // 
            // loginbox
            // 
            this.loginbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.loginbox.Location = new System.Drawing.Point(185, 266);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(219, 34);
            this.loginbox.TabIndex = 3;
            this.loginbox.Tag = "";
            this.loginbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginbox_KeyDown);
            // 
            // passbox
            // 
            this.passbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passbox.Location = new System.Drawing.Point(185, 364);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(219, 34);
            this.passbox.TabIndex = 4;
            this.passbox.UseSystemPasswordChar = true;
            this.passbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passbox_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::обработчик_результатов.Properties.Resources.openeye;
            this.pictureBox3.Location = new System.Drawing.Point(410, 361);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::обработчик_результатов.Properties.Resources.user2;
            this.pictureBox2.Location = new System.Drawing.Point(71, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::обработчик_результатов.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(76, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logbutton
            // 
            this.logbutton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.logbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logbutton.FlatAppearance.BorderSize = 0;
            this.logbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.logbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.logbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logbutton.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logbutton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.logbutton.Location = new System.Drawing.Point(219, 456);
            this.logbutton.Name = "logbutton";
            this.logbutton.Size = new System.Drawing.Size(133, 49);
            this.logbutton.TabIndex = 6;
            this.logbutton.Text = "войти";
            this.logbutton.UseVisualStyleBackColor = false;
            this.logbutton.Click += new System.EventHandler(this.logbutton_Click);
            this.logbutton.Enter += new System.EventHandler(this.logbutton_Enter);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(532, 603);
            this.Controls.Add(this.logbutton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.Вход);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Loginform";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Вход;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button logbutton;
    }
}

