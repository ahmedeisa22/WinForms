using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormProject
{
  
    public partial class frmPizza : Form
    {
        private decimal TotalPrice;
        private decimal SizePrice;
        private decimal TopplingPrice;
        private decimal CrustPrice;

        List<string> Toppings = new List<string>() { "Extra Chesse", "Tomatoes" };
        public frmPizza()
        {
            InitializeComponent();
            TotalPrice = 30;
            SizePrice = 10;
            TopplingPrice = 10;
            CrustPrice= 10;
            label10.Text= $"${TotalPrice.ToString()}";


        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Small";
            SizePrice = 10;
            UpdatePrice();

        }
        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Medium";
            SizePrice = 15;
            UpdatePrice();

        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Large";
            SizePrice = 20;
            UpdatePrice();

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Eat In";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Take Out";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                TopplingPrice += 5;
              
                Toppings.Add(checkBox1.Text);
            }
            else
            {
                TopplingPrice += -5;
                if(Toppings.Count > 0){
                    foreach (var item in Toppings)
                    {
                        if (item == checkBox1.Text)
                        {
                            Toppings.Remove(item);
                            break;
                        }
                    }
                }
                
                
                if(Toppings.Count <= 0)
                {
                    Toppings.Add("Nothing");
                }
         
            }
            label4.Text = getToppingStr(Toppings);
            UpdatePrice();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                TopplingPrice += 5;

                Toppings.Add(checkBox2.Text);
            }
            else
            {
                TopplingPrice += -5;
                if (Toppings.Count > 0)
                {
                    foreach (var item in Toppings)
                    {
                        if (item == checkBox2.Text)
                        {
                            Toppings.Remove(item);
                            break;
                        }
                    }
                }
                if (Toppings.Count <= 0)
                {
                    Toppings.Add("Nothing");
                }

            }
            label4.Text = getToppingStr(Toppings);
            UpdatePrice();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {

                TopplingPrice += 5;

                Toppings.Add(checkBox3.Text);
            }
            else
            {
                TopplingPrice += -5;
                if (Toppings.Count > 0)
                {
                    foreach (var item in Toppings)
                    {
                        if (item == checkBox3.Text)
                        {
                            Toppings.Remove(item);
                            break;
                        }
                    }
                }
                if (Toppings.Count <= 0)
                {
                    Toppings.Add("Nothing");
                }

            }
            label4.Text = getToppingStr(Toppings);

            UpdatePrice();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {

                TopplingPrice += 5;

                Toppings.Add(checkBox4.Text);
            }
            else
            {
                TopplingPrice += -5;
                if (Toppings.Count > 0)
                {
                    foreach (var item in Toppings)
                    {
                        if (item == checkBox4.Text)
                        {
                            Toppings.Remove(item);
                            break;
                        }
                    }
                }
                if (Toppings.Count <= 0)
                {
                    Toppings.Add("Nothing");
                }

            }
            label4.Text = getToppingStr(Toppings);

            UpdatePrice();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {

                TopplingPrice += 5;

                Toppings.Add(checkBox5.Text);
            }
            else
            {
                TopplingPrice += -5;
                if (Toppings.Count > 0)
                {
                    foreach (var item in Toppings)
                    {
                        if (item == checkBox5.Text)
                        {
                            Toppings.Remove(item);
                            break;
                        }
                    }
                }
                if (Toppings.Count <= 0)
                {
                    Toppings.Add("Nothing");
                }

            }
            label4.Text = getToppingStr(Toppings);

            UpdatePrice();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                TopplingPrice += 5;

                Toppings.Add(checkBox6.Text);
            }
            else
            {
                TopplingPrice += -5;
                if (Toppings.Count > 0)
                {
                    foreach (var item in Toppings)
                    {
                        if (item == checkBox6.Text)
                        {
                            Toppings.Remove(item);
                            break;
                        }
                    }
                }
                if (Toppings.Count <= 0)
                {
                    Toppings.Add("Nothing");
                }

            }
            label4.Text = getToppingStr(Toppings);

            UpdatePrice();
        }
        string getToppingStr(List<string> toppingsList)
        {
            string res = "";
            if(toppingsList.Count > 1 && toppingsList.Contains("Nothing"))
                toppingsList.Remove("Nothing");
            
            foreach (var item in toppingsList)
                res += item + ",";
            
            return res;
        }
   
        void UpdatePrice()
        {
          
            TotalPrice = (SizePrice + TopplingPrice + CrustPrice);

            label10.Text = "$"+TotalPrice.ToString();

        }
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Thin Crust";
            CrustPrice = 10;
            UpdatePrice();
        }
        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Thick Crust";
            CrustPrice = 20;
            UpdatePrice();

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Confirm Order?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                groupBox1.Enabled = groupBox2.Enabled= gbSize.Enabled = gbCrust.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = groupBox2.Enabled = gbSize.Enabled = gbCrust.Enabled = true;
        }
    }
}
