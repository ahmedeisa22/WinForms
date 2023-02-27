using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormProject
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey this is message","This is title");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure ?", "Confirm!", MessageBoxButtons.OKCancel,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("User chosse ok!");
            }
            else
            {
                MessageBox.Show("User chosse Cancel!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmCheckBox = new frmCheckRadioGroup();
            frmCheckBox.ShowDialog();
        }
    }
}
