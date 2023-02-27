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
    public partial class frmNewForm : Form
    {
        public frmNewForm()
        {
            InitializeComponent();
        }

        private void btnShowForm_Click(object sender, EventArgs e)
        {
            Form form1 = new form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new form1();
            form1.ShowDialog();
        }

        private void btnMessageBoxForm_Click(object sender, EventArgs e)
        {
            Form form1 = new frmMessageBox();
            form1.ShowDialog();
        }
    }
}
