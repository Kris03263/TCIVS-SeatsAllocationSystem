using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSeatDistribute
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ClassTB.Text == String.Empty || RowsCountTB.Text == String.Empty)
            {
                MessageBox.Show("Class or Rows cannot be null");
            }
            else
            {
                string classname = ClassTB.Text;
                int n = 0;
                bool suc = int.TryParse(RowsCountTB.Text,out n);
                if (suc)
                {
                    Action ac = new Action(classname, Convert.ToInt32(RowsCountTB.Text));
                    ac.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rows should be number");
                }
            }
        }
    }
}
