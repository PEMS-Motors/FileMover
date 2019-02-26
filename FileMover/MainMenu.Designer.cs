namespace FileMover
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Manual_Button = new System.Windows.Forms.Button();
            this.Auto_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(161, 238);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(123, 31);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Manual_Button
            // 
            this.Manual_Button.Location = new System.Drawing.Point(161, 201);
            this.Manual_Button.Name = "Manual_Button";
            this.Manual_Button.Size = new System.Drawing.Size(123, 31);
            this.Manual_Button.TabIndex = 2;
            this.Manual_Button.Text = "Run Manual";
            this.Manual_Button.UseVisualStyleBackColor = true;
            this.Manual_Button.Click += new System.EventHandler(this.Manual_Button_Click);
            // 
            // Auto_Button
            // 
            this.Auto_Button.Location = new System.Drawing.Point(161, 164);
            this.Auto_Button.Name = "Auto_Button";
            this.Auto_Button.Size = new System.Drawing.Size(123, 31);
            this.Auto_Button.TabIndex = 3;
            this.Auto_Button.Text = "Run Auto";
            this.Auto_Button.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 322);
            this.Controls.Add(this.Auto_Button);
            this.Controls.Add(this.Manual_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Manual_Button;
        private System.Windows.Forms.Button Auto_Button;
    }
}

