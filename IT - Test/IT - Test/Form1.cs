using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT___Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { String str1 = "arpanet";
            if(textBox1.Text.ToLower().Trim() == str1)
            {
                lbl1OK.Text = "OK";
            }

            else
            {
                lbl1OK.Text = "EROR";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {    

            if(radioButton1.Checked == false)
            {
                lbl2OK.Text = "OK";
            }

            else
            {
                lbl2OK.Text = "EROR";
            }
        }
       

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox4.Checked == false)
            {
                label3OK.Text = "OK";
            }

            else
            {
                label3OK.Text = "CHYBA";
            }
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (radioButton5.Checked == false)
            {
                lbl4OK.Text = "OK";
            }

            else
            {
                lbl4OK.Text = "EROR";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Hviezdicova")
            {
                lbl5OK.Text = "OK";

            }

            else
            {
                lbl5OK.Text = "EROR";
            }
        }

        
        public void kontrolaDatumu()
        {
            string datum = dateTimePicker1.Value.ToShortDateString();

            if (datum == "01.01.1970")
            {
                lbl6OK.Text = "OK";
            }

            else {
                lbl6OK.Text = "OK";
            }
        }
    }
}
