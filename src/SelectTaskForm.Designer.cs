namespace KSU_Fall_2023_Hackathon
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
            ShowerButton = new Button();
            BreakfeastButton = new Button();
            DressButton = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(346, 164);
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
            // ShowerButton
            // 
            ShowerButton.Location = new Point(181, 12);
            ShowerButton.Name = "ShowerButton";
            ShowerButton.Size = new Size(128, 128);
            ShowerButton.TabIndex = 2;
            ShowerButton.Text = "Shower";
            ShowerButton.UseVisualStyleBackColor = true;
            ShowerButton.Click += ShowerButton_Click;
            // 
            // BreakfeastButton
            // 
            BreakfeastButton.Location = new Point(12, 164);
            BreakfeastButton.Name = "BreakfeastButton";
            BreakfeastButton.Size = new Size(128, 128);
            BreakfeastButton.TabIndex = 3;
            BreakfeastButton.Text = "Breakfeast";
            BreakfeastButton.UseVisualStyleBackColor = true;
            BreakfeastButton.Click += BreakfeastButton_Click;
            // 
            // DressButton
            // 
            DressButton.Location = new Point(181, 164);
            DressButton.Name = "DressButton";
            DressButton.Size = new Size(128, 128);
            DressButton.TabIndex = 4;
            DressButton.Text = "Get Dressed";
            DressButton.UseVisualStyleBackColor = true;
            DressButton.Click += DressButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(346, 12);
            button3.Name = "button3";
            button3.Size = new Size(128, 128);
            button3.TabIndex = 5;
            button3.Text = "Contacts";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SelectTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(506, 304);
            Controls.Add(button3);
            Controls.Add(DressButton);
            Controls.Add(BreakfeastButton);
            Controls.Add(ShowerButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SelectTaskForm";
            Text = "SelectTaskForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button ShowerButton;
        private Button BreakfeastButton;
        private Button DressButton;
        private Button button3;
    }
}