using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ICE9.Program;

namespace ICE9
{
    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[(int)FormType.Next].Show();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Selection].Show();
            this.Hide();
        }
    }
}
