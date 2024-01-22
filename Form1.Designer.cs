namespace WinFormPro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            add_data_button = new Button();
            SuspendLayout();
            // 
            // add_data_button
            // 
            add_data_button.Location = new Point(357, 316);
            add_data_button.Name = "add_data_button";
            add_data_button.Size = new Size(75, 23);
            add_data_button.TabIndex = 0;
            add_data_button.Text = "Add data";
            add_data_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 510);
            Controls.Add(add_data_button);
            Name = "Form1";
            Text = "WinFormPro";
            ResumeLayout(false);
        }

        #endregion

        private Button add_data_button;
    }
}
