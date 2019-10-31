namespace Droomjacht.Event
{
    partial class EventInSpel
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.tekstballon.TabIndex = 11;
            this.tekstballon.TabStop = false;
            this.tekstballon.Text = "Hoi!";
            this.tekstballon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tekstballon.UseMnemonic = false;
            this.tekstballon.UseVisualStyleBackColor = false;
            this.tekstballon.Click += new System.EventHandler(this.tekstballon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Droomjacht.Properties.Resources.regenboog;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(671, 419);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EventInSpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 705);
            this.Controls.Add(this.tekstballon);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "EventInSpel";
            this.Text = "EventInSpel";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tekstballon, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tekstballon;
        private System.Windows.Forms.Button button1;
    }
}