using System;

namespace Droomjacht
{
    partial class NieuweGebruiker
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
            this.tekstballon = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tekstballon
            // 
            this.tekstballon.BackColor = System.Drawing.Color.Transparent;
            this.tekstballon.BackgroundImage = global::Droomjacht.Properties.Resources.tekstballonAndersom;
            this.tekstballon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tekstballon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tekstballon.FlatAppearance.BorderSize = 0;
            this.tekstballon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tekstballon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tekstballon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tekstballon.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekstballon.Location = new System.Drawing.Point(586, 245);
            this.tekstballon.Margin = new System.Windows.Forms.Padding(2);
            this.tekstballon.Name = "tekstballon";
            this.tekstballon.Size = new System.Drawing.Size(396, 299);
            this.tekstballon.TabIndex = 12;
            this.tekstballon.TabStop = false;
            this.tekstballon.Text = "Hoi! Wat is je naam?\r\n\r\n\r\n";
            this.tekstballon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tekstballon.UseMnemonic = false;
            this.tekstballon.UseVisualStyleBackColor = false;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.BackgroundImage = global::Droomjacht.Properties.Resources.eenhoorn;
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.avatar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.avatar.FlatAppearance.BorderSize = 0;
            this.avatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.avatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.avatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatar.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatar.Location = new System.Drawing.Point(1010, 230);
            this.avatar.Margin = new System.Windows.Forms.Padding(2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(289, 468);
            this.avatar.TabIndex = 13;
            this.avatar.TabStop = false;
            this.avatar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.avatar.UseMnemonic = false;
            this.avatar.UseVisualStyleBackColor = false;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Coral;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(201, 340);
            this.nameBox.MaximumSize = new System.Drawing.Size(300, 150);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 47);
            this.nameBox.TabIndex = 14;
            this.nameBox.Text = "Naam";
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            this.nameBox.Click += new System.EventHandler(this.nameBox_Clicked);
            // 
            // NieuweGebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 889);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.tekstballon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NieuweGebruiker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nieuwe Gebruiker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tekstballon;
        private System.Windows.Forms.Button avatar;
        public System.Windows.Forms.TextBox nameBox;
    }
}