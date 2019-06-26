namespace COMP123_S2019_Lesson8A
{
    partial class Lab08Form
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(89, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Lab08";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(14, 97);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(166, 31);
            this.Name.TabIndex = 2;
            this.Name.Text = "Enter Name:";
            this.Name.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(186, 94);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(402, 38);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(186, 148);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(402, 38);
            this.AgeTextBox.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(14, 151);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(142, 31);
            this.Age.TabIndex = 4;
            this.Age.Text = "Enter Age:";
            this.Age.Click += new System.EventHandler(this.label2_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(17, 70);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(24, 13);
            this.info.TabIndex = 6;
            this.info.Text = "info";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(441, 370);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(161, 59);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // Lab08Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.info);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Lab08Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button SubmitButton;
    }
}

