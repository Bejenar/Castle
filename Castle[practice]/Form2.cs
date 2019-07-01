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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.rooms.Count; i++)
                comboBox1.Items.Add((i+1).ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Form1.RoomArea(Convert.ToInt32(comboBox1.SelectedIndex));
        }
    }
}
