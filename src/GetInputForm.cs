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
        public GetInputForm()
        {
            InitializeComponent();
        }

        private void ReturnValue(object sender, EventArgs e)
        {
            Form1.name = textBox1.Text;
            this.Hide();
        }
    }
}
