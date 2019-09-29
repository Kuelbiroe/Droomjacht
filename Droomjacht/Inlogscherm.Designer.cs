namespace Droomjacht
{
    partial class Inlogscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inlogscherm));
            this.JannaKnop = new System.Windows.Forms.Button();
            this.RubenKnop = new System.Windows.Forms.Button();
            this.nieuweUserKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JannaKnop
            // 
            this.JannaKnop.BackColor = System.Drawing.Color.Transparent;
            this.JannaKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JannaKnop.BackgroundImage")));
            this.JannaKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.JannaKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.JannaKnop.FlatAppearance.BorderSize = 0;
            this.JannaKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JannaKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JannaKnop.Location = new System.Drawing.Point(289, 198);
            this.JannaKnop.Margin = new System.Windows.Forms.Padding(2);
            this.JannaKnop.Name = "JannaKnop";
            this.JannaKnop.Size = new System.Drawing.Size(208, 137);
            this.JannaKnop.TabIndex = 3;
            this.JannaKnop.TabStop = false;
            this.JannaKnop.Text = "Janna";
            this.JannaKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.JannaKnop.UseMnemonic = false;
            this.JannaKnop.UseVisualStyleBackColor = false;
            this.JannaKnop.Click += new System.EventHandler(this.JannaKnop_Click);
            // 
            // RubenKnop
            // 
            this.RubenKnop.BackColor = System.Drawing.Color.Transparent;
            this.RubenKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RubenKnop.BackgroundImage")));
            this.RubenKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RubenKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RubenKnop.FlatAppearance.BorderSize = 0;
            this.RubenKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RubenKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RubenKnop.Location = new System.Drawing.Point(289, 339);
            this.RubenKnop.Margin = new System.Windows.Forms.Padding(2);
            this.RubenKnop.Name = "RubenKnop";
            this.RubenKnop.Size = new System.Drawing.Size(210, 131);
            this.RubenKnop.TabIndex = 4;
            this.RubenKnop.TabStop = false;
            this.RubenKnop.Text = "Ruben";
            this.RubenKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.RubenKnop.UseMnemonic = false;
            this.RubenKnop.UseVisualStyleBackColor = false;
            this.RubenKnop.Click += new System.EventHandler(this.RubenKnop_Click);
            // 
            // nieuweUserKnop
            // 
            this.nieuweUserKnop.BackColor = System.Drawing.Color.Transparent;
            this.nieuweUserKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nieuweUserKnop.BackgroundImage")));
            this.nieuweUserKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nieuweUserKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nieuweUserKnop.FlatAppearance.BorderSize = 0;
            this.nieuweUserKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nieuweUserKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nieuweUserKnop.Location = new System.Drawing.Point(289, 474);
            this.nieuweUserKnop.Margin = new System.Windows.Forms.Padding(2);
            this.nieuweUserKnop.Name = "nieuweUserKnop";
            this.nieuweUserKnop.Size = new System.Drawing.Size(206, 137);
            this.nieuweUserKnop.TabIndex = 7;
            this.nieuweUserKnop.TabStop = false;
            this.nieuweUserKnop.Text = "+";
            this.nieuweUserKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.nieuweUserKnop.UseMnemonic = false;
            this.nieuweUserKnop.UseVisualStyleBackColor = false;
            this.nieuweUserKnop.Click += new System.EventHandler(this.nieuweUserKnop_Click);
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 634);
            this.Controls.Add(this.nieuweUserKnop);
            this.Controls.Add(this.RubenKnop);
            this.Controls.Add(this.JannaKnop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inlogscherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Droomjacht";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JannaKnop;
        private System.Windows.Forms.Button RubenKnop;
        private System.Windows.Forms.Button nieuweUserKnop;
    }
}