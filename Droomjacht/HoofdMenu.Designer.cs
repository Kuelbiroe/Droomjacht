using System.Drawing;

namespace Droomjacht
{
    public partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.RekenKnop = new System.Windows.Forms.Button();
            this.abcKnop = new System.Windows.Forms.Button();
            this.geleKnop = new System.Windows.Forms.Button();
            this.rodeKnop = new System.Windows.Forms.Button();
            this.groeneKnop = new System.Windows.Forms.Button();
            this.oranjeKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RekenKnop
            // 
            this.RekenKnop.BackColor = System.Drawing.Color.Transparent;
            this.RekenKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RekenKnop.BackgroundImage")));
            this.RekenKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RekenKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RekenKnop.FlatAppearance.BorderSize = 0;
            this.RekenKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RekenKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RekenKnop.Location = new System.Drawing.Point(11, 11);
            this.RekenKnop.Margin = new System.Windows.Forms.Padding(2);
            this.RekenKnop.Name = "RekenKnop";
            this.RekenKnop.Size = new System.Drawing.Size(208, 137);
            this.RekenKnop.TabIndex = 2;
            this.RekenKnop.TabStop = false;
            this.RekenKnop.Text = "123";
            this.RekenKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.RekenKnop.UseMnemonic = false;
            this.RekenKnop.UseVisualStyleBackColor = false;
            this.RekenKnop.Click += new System.EventHandler(this.RekenKnop_Click);
            // 
            // abcKnop
            // 
            this.abcKnop.BackColor = System.Drawing.Color.Transparent;
            this.abcKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("abcKnop.BackgroundImage")));
            this.abcKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.abcKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.abcKnop.FlatAppearance.BorderSize = 0;
            this.abcKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abcKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abcKnop.Location = new System.Drawing.Point(223, 69);
            this.abcKnop.Margin = new System.Windows.Forms.Padding(2);
            this.abcKnop.Name = "abcKnop";
            this.abcKnop.Size = new System.Drawing.Size(210, 131);
            this.abcKnop.TabIndex = 3;
            this.abcKnop.TabStop = false;
            this.abcKnop.Text = "abc";
            this.abcKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.abcKnop.UseMnemonic = false;
            this.abcKnop.UseVisualStyleBackColor = false;
            this.abcKnop.Click += new System.EventHandler(this.abcKnop_Click);
            // 
            // geleKnop
            // 
            this.geleKnop.BackColor = System.Drawing.Color.Transparent;
            this.geleKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geleKnop.BackgroundImage")));
            this.geleKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.geleKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.geleKnop.FlatAppearance.BorderSize = 0;
            this.geleKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geleKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geleKnop.Location = new System.Drawing.Point(646, 65);
            this.geleKnop.Margin = new System.Windows.Forms.Padding(2);
            this.geleKnop.Name = "geleKnop";
            this.geleKnop.Size = new System.Drawing.Size(209, 135);
            this.geleKnop.TabIndex = 4;
            this.geleKnop.TabStop = false;
            this.geleKnop.Text = "programmeren";
            this.geleKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.geleKnop.UseMnemonic = false;
            this.geleKnop.UseVisualStyleBackColor = false;
            this.geleKnop.Click += new System.EventHandler(this.geleKnop_Click);
            // 
            // rodeKnop
            // 
            this.rodeKnop.BackColor = System.Drawing.Color.Transparent;
            this.rodeKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rodeKnop.BackgroundImage")));
            this.rodeKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rodeKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rodeKnop.FlatAppearance.BorderSize = 0;
            this.rodeKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rodeKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rodeKnop.Location = new System.Drawing.Point(1075, 69);
            this.rodeKnop.Margin = new System.Windows.Forms.Padding(2);
            this.rodeKnop.Name = "rodeKnop";
            this.rodeKnop.Size = new System.Drawing.Size(211, 133);
            this.rodeKnop.TabIndex = 5;
            this.rodeKnop.TabStop = false;
            this.rodeKnop.Text = "veranderen";
            this.rodeKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rodeKnop.UseMnemonic = false;
            this.rodeKnop.UseVisualStyleBackColor = false;
            this.rodeKnop.Click += new System.EventHandler(this.rodeKnop_Click);
            // 
            // groeneKnop
            // 
            this.groeneKnop.BackColor = System.Drawing.Color.Transparent;
            this.groeneKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groeneKnop.BackgroundImage")));
            this.groeneKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groeneKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groeneKnop.FlatAppearance.BorderSize = 0;
            this.groeneKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groeneKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groeneKnop.Location = new System.Drawing.Point(437, 4);
            this.groeneKnop.Margin = new System.Windows.Forms.Padding(2);
            this.groeneKnop.Name = "groeneKnop";
            this.groeneKnop.Size = new System.Drawing.Size(206, 137);
            this.groeneKnop.TabIndex = 6;
            this.groeneKnop.TabStop = false;
            this.groeneKnop.Text = "muziek";
            this.groeneKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.groeneKnop.UseMnemonic = false;
            this.groeneKnop.UseVisualStyleBackColor = false;
            this.groeneKnop.Click += new System.EventHandler(this.groeneKnop_Click);
            // 
            // oranjeKnop
            // 
            this.oranjeKnop.BackColor = System.Drawing.Color.Transparent;
            this.oranjeKnop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oranjeKnop.BackgroundImage")));
            this.oranjeKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.oranjeKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.oranjeKnop.FlatAppearance.BorderSize = 0;
            this.oranjeKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oranjeKnop.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oranjeKnop.Location = new System.Drawing.Point(859, 4);
            this.oranjeKnop.Margin = new System.Windows.Forms.Padding(2);
            this.oranjeKnop.Name = "oranjeKnop";
            this.oranjeKnop.Size = new System.Drawing.Size(210, 137);
            this.oranjeKnop.TabIndex = 7;
            this.oranjeKnop.TabStop = false;
            this.oranjeKnop.Text = "berichten";
            this.oranjeKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.oranjeKnop.UseMnemonic = false;
            this.oranjeKnop.UseVisualStyleBackColor = false;
            this.oranjeKnop.Click += new System.EventHandler(this.oranjeKnop_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 634);
            this.Controls.Add(this.oranjeKnop);
            this.Controls.Add(this.groeneKnop);
            this.Controls.Add(this.rodeKnop);
            this.Controls.Add(this.geleKnop);
            this.Controls.Add(this.abcKnop);
            this.Controls.Add(this.RekenKnop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dromenjacht";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RekenKnop;
        private System.Windows.Forms.Button abcKnop;
        private System.Windows.Forms.Button geleKnop;
        private System.Windows.Forms.Button rodeKnop;
        private System.Windows.Forms.Button groeneKnop;
        private System.Windows.Forms.Button oranjeKnop;
    }
}

