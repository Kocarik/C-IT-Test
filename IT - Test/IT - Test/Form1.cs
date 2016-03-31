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

        int p;

        public Form1()
        {
            InitializeComponent();
       
        }


        public void firstQuestion()
        {
            String str1 = "arpanet";
            if (textBox1.Text.ToLower().Trim().Equals(str1))
            {
                lbl1OK.Text = "OK";
                lbl1OK.ForeColor = Color.Green;
                p += 1;
            }

            else
            {
                lbl1OK.Text = "EROR";
                lbl1OK.ForeColor = Color.Red;
            }
        }

        public void secondQuestion()
        {
            if (radioButton1.Checked == true)
            {
                lbl2OK.Text = "OK";
                lbl2OK.ForeColor = Color.Green;
                p += 1;
            }

            else
            {
                lbl2OK.Text = "EROR";
                lbl2OK.ForeColor = Color.Red;
            }
        }

        public void threeQuestion()
        {
            if (checkBox1.Checked == true && checkBox4.Checked == true)
            {
                label3OK.Text = "OK";
                label3OK.ForeColor = Color.Green;
                p += 1;
            }

            else
            {
                label3OK.Text = "CHYBA";
                label3OK.ForeColor = Color.Red;
            }
        }

        public void fourQuestion()
        {
            if (radioButton5.Checked == true)
            {
                lbl4OK.Text = "OK";
                lbl4OK.ForeColor = Color.Green;
                p += 1;
            }

            else
            {
                lbl4OK.Text = "EROR";
                lbl4OK.ForeColor = Color.Red;
            }
        }

        public void fiveQuestion()
        {
            if (comboBox1.SelectedItem == "Hviezdicova")
            {
                lbl5OK.Text = "OK";
                lbl5OK.ForeColor = Color.Green;
                p += 1;

            }

            else
            {
                lbl5OK.Text = "EROR";
                lbl5OK.ForeColor = Color.Red;
            }
        }

        public void sixQuestion()
        {
            string datum = datePicker.Value.ToShortDateString();

            if (datum == "01.01.1970")
            {
                lbl6OK.Text = "OK :)";
                lbl6OK.ForeColor = Color.Green;
                p += 1;
            }

            else
            {
                lbl6OK.Text = "Nespravna odpoved";
                lbl6OK.ForeColor = Color.Red;
            }
        }

        public void pointCount()
        {
            lblPoint.Text = "Nazberal si celkom " +p+ " bodov.";          
        }

        private void btnKontrola_Click(object sender, EventArgs e)
        {
            firstQuestion();
            secondQuestion();
            threeQuestion();
            fourQuestion();
            fiveQuestion();
            sixQuestion();
            pointCount();
            p = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = 0;
            lblPoint.Text = "Nazberal si celkom " + p + " bodov.";
            lbl1OK.Text = null;
            lbl2OK.Text = null;
            label3OK.Text = null;
            lbl4OK.Text = null;
            lbl5OK.Text = null;
            lbl6OK.Text = null;
        }


    }

}
