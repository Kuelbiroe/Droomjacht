namespace Droomjacht.Rekenen
{
    partial class RekenScherm
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
            this.tekenWolk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tekenWolk
            // 
            this.tekenWolk.BackColor = System.Drawing.Color.Transparent;
            this.tekenWolk.BackgroundImage = global::Droomjacht.Properties.Resources.Knop_;
            this.tekenWolk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tekenWolk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tekenWolk.FlatAppearance.BorderSize = 0;
            this.tekenWolk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tekenWolk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tekenWolk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tekenWolk.Font = new System.Drawing.Font("Verdana", 65F, System.Drawing.FontStyle.Bold);
            this.tekenWolk.Location = new System.Drawing.Point(105, 254);
            this.tekenWolk.Margin = new System.Windows.Forms.Padding(2);
            this.tekenWolk.Name = "tekenWolk";
            this.tekenWolk.Size = new System.Drawing.Size(269, 173);
            this.tekenWolk.TabIndex = 13;
            this.tekenWolk.TabStop = false;
            this.tekenWolk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tekenWolk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tekenWolk.UseMnemonic = false;
            this.tekenWolk.UseVisualStyleBackColor = false;
            this.tekenWolk.Click += new System.EventHandler(this.tekenWolk_Click);
            // 
            // RekenScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 801);
            this.Controls.Add(this.tekenWolk);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "RekenScherm";
            this.Text = "RekenScherm";
            this.Controls.SetChildIndex(this.tekenWolk, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tekenWolk;
    }
}