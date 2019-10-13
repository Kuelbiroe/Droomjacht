using System.Drawing;
using System.Windows.Forms;

namespace Droomjacht.abc
{
    partial class AbcScherm 
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
            this.letterSpelKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // letterSpelKnop
            // 
            this.letterSpelKnop.BackColor = System.Drawing.Color.Transparent;
            this.letterSpelKnop.BackgroundImage = global::Droomjacht.Properties.Resources.knopLetter;
            this.letterSpelKnop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.letterSpelKnop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.letterSpelKnop.FlatAppearance.BorderSize = 0;
            this.letterSpelKnop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.letterSpelKnop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.letterSpelKnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterSpelKnop.Font = new System.Drawing.Font("Verdana", 65F, System.Drawing.FontStyle.Bold);
            this.letterSpelKnop.Location = new System.Drawing.Point(105, 254);
            this.letterSpelKnop.Margin = new System.Windows.Forms.Padding(2);
            this.letterSpelKnop.Name = "letterSpelKnop";
            this.letterSpelKnop.Size = new System.Drawing.Size(269, 168);
            this.letterSpelKnop.TabIndex = 15;
            this.letterSpelKnop.TabStop = false;
            this.letterSpelKnop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.letterSpelKnop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.letterSpelKnop.UseMnemonic = false;
            this.letterSpelKnop.UseVisualStyleBackColor = false;
            this.letterSpelKnop.Click += new System.EventHandler(this.letterSpelKnop_Click);
            // 
            // AbcScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1388, 745);
            this.Controls.Add(this.letterSpelKnop);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AbcScherm";
            this.Controls.SetChildIndex(this.letterSpelKnop, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Button letterSpelKnop;
    }
}