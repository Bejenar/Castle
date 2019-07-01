using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castle_practice_
{
    public partial class BinaryConvertor : Form
    {
        public BinaryConvertor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text =  Program.BinaryConvert(Convert.ToInt32(b.Text));
        }

        private void BinaryConvertor_Load(object sender, EventArgs e)
        {

        }
    }
}
