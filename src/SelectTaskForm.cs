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

        public SelectTaskForm()
        {
            InitializeComponent();
        }

        private void other_button_Click(object sender, EventArgs e)
        {
            GetInputForm getInputForm = new GetInputForm();
            getInputForm.ShowDialog();
            this.Close();
        }

        private void brush_teeth_button_Click(object sender, EventArgs e)
        {
        }
    }
}
