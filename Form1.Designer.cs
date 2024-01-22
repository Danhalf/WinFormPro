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
            label_info = new Label();
            greatings_input = new TextBox();
            SuspendLayout();
            // 
            // add_data_button
            // 
            add_data_button.Location = new Point(357, 316);
            add_data_button.Name = "add_data_button";
            add_data_button.Size = new Size(100, 23);
            add_data_button.TabIndex = 0;
            add_data_button.Text = "Add data";
            add_data_button.UseVisualStyleBackColor = true;
            add_data_button.Click += add_data_button_Click;
            // 
            // label_info
            // 
            label_info.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_info.Location = new Point(357, 373);
            label_info.Name = "label_info";
            label_info.Size = new Size(100, 24);
            label_info.TabIndex = 1;
            label_info.TextAlign = ContentAlignment.MiddleCenter;
            label_info.Click += label_info_Click;
            // 
            // greatings_input
            // 
            greatings_input.Location = new Point(306, 160);
            greatings_input.Name = "greatings_input";
            greatings_input.Size = new Size(206, 23);
            greatings_input.TabIndex = 2;
            greatings_input.WordWrap = false;
            greatings_input.TextChanged += greatings_input_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 510);
            Controls.Add(greatings_input);
            Controls.Add(label_info);
            Controls.Add(add_data_button);
            Name = "Form1";
            Text = "WinFormPro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_data_button;
        private Label label_info;
        private TextBox greatings_input;
    }
}
