using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_Form
{
    public partial class OutputForm : Form
    {
        string output;

        public OutputForm(string output)
        {
            this.output = output;
            InitializeComponent();
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            output_label.Text = output;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
