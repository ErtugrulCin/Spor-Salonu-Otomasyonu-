﻿namespace BndGreedV3._0WF
{
    partial class Form7
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(481, 551);
            button1.Name = "button1";
            button1.Size = new Size(194, 57);
            button1.TabIndex = 1;
            button1.Text = "DAHA FAZLASI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Support__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1154, 673);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}