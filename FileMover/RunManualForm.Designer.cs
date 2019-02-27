namespace FileMover
{
    partial class RunManualForm
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
            this.Name_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_Button
            // 
            this.Name_Button.Location = new System.Drawing.Point(338, 357);
            this.Name_Button.Name = "Name_Button";
            this.Name_Button.Size = new System.Drawing.Size(75, 23);
            this.Name_Button.TabIndex = 0;
            this.Name_Button.Text = "Run";
            this.Name_Button.UseVisualStyleBackColor = true;
            this.Name_Button.Click += new System.EventHandler(this.Name_Button_Click);
            // 
            // RunManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Name_Button);
            this.Name = "RunManualForm";
            this.Text = "RunManualForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Name_Button;
    }
}