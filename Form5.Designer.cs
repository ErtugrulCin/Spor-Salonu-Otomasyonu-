namespace BndGreedV3._0WF
{
    partial class Form5
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(273, 551);
            button1.Name = "button1";
            button1.Size = new Size(151, 50);
            button1.TabIndex = 0;
            button1.Text = "SATIN AL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(430, 565);
            button2.Name = "button2";
            button2.Size = new Size(111, 36);
            button2.TabIndex = 1;
            button2.Text = "İLERİ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Equipment__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1153, 697);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}