
namespace Creation1
{
    partial class Form_Validation
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
            this.Username = new System.Windows.Forms.TextBox();
            this.RegnoBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewUsers = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.PopulateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Page2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(70, 40);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(165, 20);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // RegnoBox
            // 
            this.RegnoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegnoBox.Location = new System.Drawing.Point(69, 84);
            this.RegnoBox.Name = "RegnoBox";
            this.RegnoBox.Size = new System.Drawing.Size(165, 20);
            this.RegnoBox.TabIndex = 1;
            this.RegnoBox.TextChanged += new System.EventHandler(this.Regno_TextChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterButton.Location = new System.Drawing.Point(3, 134);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(57, 23);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(128, 118);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 3;
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertButton.Location = new System.Drawing.Point(93, 163);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(106, 23);
            this.InsertButton.TabIndex = 4;
            this.InsertButton.Text = "InsertButton";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Visible = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadButton.Location = new System.Drawing.Point(93, 192);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(106, 23);
            this.ReadButton.TabIndex = 5;
            this.ReadButton.Text = "ReadButton";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Visible = false;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(185, 134);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(58, 23);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "UpdateButton";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(249, 134);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(65, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ViewUsers
            // 
            this.ViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewUsers.Location = new System.Drawing.Point(66, 134);
            this.ViewUsers.Name = "ViewUsers";
            this.ViewUsers.Size = new System.Drawing.Size(49, 23);
            this.ViewUsers.TabIndex = 8;
            this.ViewUsers.Text = "View";
            this.ViewUsers.UseVisualStyleBackColor = true;
            this.ViewUsers.Click += new System.EventHandler(this.ViewUsers_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(1, 221);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(304, 102);
            this.dataGrid.TabIndex = 9;
            // 
            // PopulateButton
            // 
            this.PopulateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PopulateButton.Location = new System.Drawing.Point(121, 134);
            this.PopulateButton.Name = "PopulateButton";
            this.PopulateButton.Size = new System.Drawing.Size(58, 23);
            this.PopulateButton.TabIndex = 10;
            this.PopulateButton.Text = "Populate";
            this.PopulateButton.UseVisualStyleBackColor = true;
            this.PopulateButton.Click += new System.EventHandler(this.PopulateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "regno";
            // 
            // Page2Button
            // 
            this.Page2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Page2Button.Location = new System.Drawing.Point(256, 6);
            this.Page2Button.Name = "Page2Button";
            this.Page2Button.Size = new System.Drawing.Size(57, 23);
            this.Page2Button.TabIndex = 13;
            this.Page2Button.Text = "Page2";
            this.Page2Button.UseVisualStyleBackColor = true;
            this.Page2Button.Click += new System.EventHandler(this.Page2Button_Click);
            // 
            // Form_Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(317, 335);
            this.Controls.Add(this.Page2Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PopulateButton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.ViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RegnoBox);
            this.Controls.Add(this.Username);
            this.MaximumSize = new System.Drawing.Size(333, 374);
            this.MinimumSize = new System.Drawing.Size(333, 374);
            this.Name = "Form_Validation";
            this.Text = "ValidationTest";
            this.Load += new System.EventHandler(this.Form_Validation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox RegnoBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ViewUsers;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button PopulateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Page2Button;
    }
}

