namespace KSU_Fall_2023_Hackathon
{
    partial class WetherInfoForm
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
            CurrentTempLabel = new Label();
            MaxTemputureButton = new Label();
            MinTempButton = new Label();
            label1 = new Label();
            precipitationLabel = new Label();
            SuspendLayout();
            // 
            // CurrentTempLabel
            // 
            CurrentTempLabel.AutoSize = true;
            CurrentTempLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentTempLabel.Location = new Point(235, 129);
            CurrentTempLabel.Name = "CurrentTempLabel";
            CurrentTempLabel.Size = new Size(191, 38);
            CurrentTempLabel.TabIndex = 0;
            CurrentTempLabel.Text = "Current Temp:";
            // 
            // MaxTemputureButton
            // 
            MaxTemputureButton.AutoSize = true;
            MaxTemputureButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MaxTemputureButton.Location = new Point(235, 195);
            MaxTemputureButton.Name = "MaxTemputureButton";
            MaxTemputureButton.Size = new Size(216, 38);
            MaxTemputureButton.TabIndex = 1;
            MaxTemputureButton.Text = "Max Temputure:";
            // 
            // MinTempButton
            // 
            MinTempButton.AutoSize = true;
            MinTempButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            MinTempButton.Location = new Point(235, 264);
            MinTempButton.Name = "MinTempButton";
            MinTempButton.Size = new Size(146, 38);
            MinTempButton.TabIndex = 2;
            MinTempButton.Text = "Min Temp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 41);
            label1.Name = "label1";
            label1.Size = new Size(628, 54);
            label1.TabIndex = 3;
            label1.Text = "Remember To Dress Appropriately";
            // 
            // precipitationLabel
            // 
            precipitationLabel.AutoSize = true;
            precipitationLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            precipitationLabel.Location = new Point(235, 332);
            precipitationLabel.Name = "precipitationLabel";
            precipitationLabel.Size = new Size(178, 38);
            precipitationLabel.TabIndex = 4;
            precipitationLabel.Text = "Precipitation:";
            // 
            // WetherInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(precipitationLabel);
            Controls.Add(label1);
            Controls.Add(MinTempButton);
            Controls.Add(MaxTemputureButton);
            Controls.Add(CurrentTempLabel);
            Name = "WetherInfoForm";
            Text = "WetherInfoForm";
            Load += WetherInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CurrentTempLabel;
        private Label MaxTemputureButton;
        private Label MinTempButton;
        private Label label1;
        private Label precipitationLabel;
    }
}