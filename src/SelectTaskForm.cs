using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KSU_Fall_2023_Hackathon
{
    public partial class SelectTaskForm : Form
    {
        private MainForm parentForm;

        public SelectTaskForm(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void other_button_Click(object sender, EventArgs e)
        {
            GetInputForm getInputForm = new GetInputForm(parentForm);
            getInputForm.ShowDialog();
            this.Close();
        }

        private void brush_teeth_button_Click(object sender, EventArgs e)
        {
            parentForm.AddSpecialLabel("Brush Teeth");
            this.Close();
        }

        private void ShowerButton_Click(object sender, EventArgs e)
        {
            parentForm.AddSpecialLabel("Shower");
            this.Close();
        }

        private void BreakfeastButton_Click(object sender, EventArgs e)
        {
            parentForm.AddSpecialLabel("Breakfeast");
            this.Close();
        }

        private void DressButton_Click(object sender, EventArgs e)
        {
            parentForm.AddSpecialLabel("Get Dressed");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parentForm.AddSpecialLabel("Contacts");
            this.Close();
        }
    }
}
