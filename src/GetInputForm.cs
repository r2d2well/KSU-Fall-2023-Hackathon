using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSU_Fall_2023_Hackathon
{
    public partial class GetInputForm : Form
    {
        MainForm parentForm;
        public GetInputForm(MainForm form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void ReturnValue(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                parentForm.AddSpecialLabel(textBox1.Text);
            }
            this.Hide();
        }
    }
}
