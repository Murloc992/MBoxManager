using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class TextInputForm : Form
    {
        public TextInputForm()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
