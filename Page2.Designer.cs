
namespace Creation1
{
    partial class Page2
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
            this.Page1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Page1Button
            // 
            this.Page1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Page1Button.Location = new System.Drawing.Point(261, 0);
            this.Page1Button.Name = "Page1Button";
            this.Page1Button.Size = new System.Drawing.Size(57, 23);
            this.Page1Button.TabIndex = 14;
            this.Page1Button.Text = "Page1";
            this.Page1Button.UseVisualStyleBackColor = true;
            this.Page1Button.Click += new System.EventHandler(this.Page1Button_Click);
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(317, 335);
            this.Controls.Add(this.Page1Button);
            this.MaximumSize = new System.Drawing.Size(333, 374);
            this.MinimumSize = new System.Drawing.Size(333, 374);
            this.Name = "Page2";
            this.Text = "Page2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Page1Button;
    }
}