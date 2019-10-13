namespace Droomjacht.Beginscherm
{
    partial class Beginscherm
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
            this.tekstballon.Location = new System.Drawing.Point(509, 278);
            this.tekstballon.Margin = new System.Windows.Forms.Padding(2);
            this.tekstballon.Name = "tekstballon";
            this.tekstballon.Size = new System.Drawing.Size(428, 299);
            this.tekstballon.TabIndex = 10;
            this.tekstballon.TabStop = false;
            this.tekstballon.Text = "Hoi!";
            this.tekstballon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tekstballon.UseMnemonic = false;
            this.tekstballon.UseVisualStyleBackColor = false;
            // 
            // Beginscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 715);
            this.Controls.Add(this.tekstballon);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Beginscherm";
            this.Text = "Beginscherm";
            this.Controls.SetChildIndex(this.tekstballon, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tekstballon;
    }
}