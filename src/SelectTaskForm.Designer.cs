﻿namespace KSU_Fall_2023_Hackathon
{
    partial class SelectTaskForm
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
            button1.Location = new Point(12, 164);
            button1.Name = "button1";
            button1.Size = new Size(128, 128);
            button1.TabIndex = 0;
            button1.Text = "Other";
            button1.UseVisualStyleBackColor = true;
            button1.Click += other_button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(128, 128);
            button2.TabIndex = 1;
            button2.Text = "Brush Teeth";
            button2.UseVisualStyleBackColor = true;
            button2.Click += brush_teeth_button_Click;
            // 
            // SelectTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 304);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SelectTaskForm";
            Text = "SelectTaskForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}