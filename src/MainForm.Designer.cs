namespace KSU_Fall_2023_Hackathon
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            CurrentTimeLabel = new Label();
            ClockTimer = new System.Windows.Forms.Timer(components);
            CurrentDateLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(632, 377);
            button1.Name = "button1";
            button1.Size = new Size(156, 61);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentTimeLabel.Location = new Point(579, 58);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(137, 28);
            CurrentTimeLabel.TabIndex = 1;
            CurrentTimeLabel.Text = "Current TIme:";
            // 
            // ClockTimer
            // 
            ClockTimer.Interval = 1000;
            ClockTimer.Tick += ClockTimer_Tick;
            // 
            // CurrentDateLabel
            // 
            CurrentDateLabel.AutoSize = true;
            CurrentDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CurrentDateLabel.Location = new Point(579, 117);
            CurrentDateLabel.Name = "CurrentDateLabel";
            CurrentDateLabel.Size = new Size(133, 28);
            CurrentDateLabel.TabIndex = 2;
            CurrentDateLabel.Text = "Current Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(872, 450);
            Controls.Add(CurrentDateLabel);
            Controls.Add(CurrentTimeLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += saveFile;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label CurrentTimeLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private Label CurrentDateLabel;
    }
}