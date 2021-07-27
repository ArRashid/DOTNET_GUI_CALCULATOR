using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string no1;
        string no2 ="";
        bool isfastno = true;
        char opa;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + ".";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 100;
            if (no1 != null){ a = no1.IndexOf('.'); }
            if (no2 != null){ b = no2.IndexOf('.'); }

            if (no2 == null || no2 == "") { no2 = "0"; if (opa != '+' ||opa != '-' ||opa != '*' ||opa != '/'  ) { opa = '+'; } }

            if (a == -1 && b == -1)
            {
                long num1 = Convert.ToInt64(no1);
                long num2 = Convert.ToInt64(no2);
                if (opa == '+') { double rslt = Convert.ToDouble(num1 + num2); dis.Text = Convert.ToString(rslt); no1 = Convert.ToString(rslt); no2 = null; isfastno = true; }
                else if (opa == '-') { double rslt = Convert.ToDouble(num1 - num2); dis.Text = Convert.ToString(rslt); no1 = Convert.ToString(rslt); no2 = null; isfastno = true; }
                else if (opa == 'x') { double rslt = Convert.ToDouble(num1 * num2); dis.Text = Convert.ToString(rslt); no1 = Convert.ToString(rslt); no2 = null; isfastno = true; }
                else if (opa == '/') { double rslt = Convert.ToDouble(no1) / Convert.ToDouble(no2); dis.Text = Convert.ToString(rslt); no1 = Convert.ToString(rslt); no2 = null; isfastno = true; }
                else { dis.Text = "Error"; }
            }
            else {
                double num1 = Convert.ToDouble(no1);
                double num2 = Convert.ToDouble(no2);
                if (opa == '+') { double rslt = num1 + num2; dis.Text = Convert.ToString(rslt); no1 = Convert.ToString(rslt); no2 = null; isfastno = true; }
                else if (opa == '-') { double rslt = num1 - num2; dis.Text = Convert.ToString(rslt); no1 = Convert.ToString(rslt); no2 = null; isfastno = true; }
                else if (opa == 'x') { double rslt = num1 * num2; dis.Text = Convert.ToString(rslt); no1 = Convert.ToString(rslt); no2 = null; isfastno = true; }
                else if (opa == '/') { double rslt = num1 / num2; dis.Text = Convert.ToString(rslt); no1 = Convert.ToString(rslt); no2 = null; isfastno = true; }
                else { dis.Text = "Error"; }
            }

            


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "5";
            if (isfastno)
            {
                if (no1 == null) { no1 = "5"; }
                else { no1 = no1 + "5"; }
            }

            else
            {
                if (no2 == null) { no2 = "5"; }
                else { no2 = no2 + "5"; }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "8";

            if (isfastno)
            {
                if (no1 == null) { no1 = "8"; }
                else { no1 = no1 + "8"; }
            }

            else
            {
                if (no2 == null) { no2 = "8"; }
                else { no2 = no2 + "8"; }
            }



        }

        private void btn2_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "2";

            if (isfastno)
            {
                if (no1 == null) { no1 = "2"; }
                else { no1 = no1 + "2"; }
            }

            else
            {
                if (no2 == null) { no2 = "2"; }
                else { no2 = no2 + "2"; }
            }
          


        }

        private void btn0_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "0";

            if (isfastno)
            {
                if (no1 == null){ no1 = "0";}
                else{no1 = no1 + "0";}
            }

           else{
                if (no2 == null){no2 = "0";}
                else{no2 = no2 + "0";}
            }
            
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            
            dis.Text = dis.Text + "+";
            isfastno = false;
            opa = '+';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "-";
            isfastno = false;
            opa = '-';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "x";
            isfastno = false;
            opa = 'x';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "/";
        }

        private void btn9_click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "9";
            if (isfastno)
            {
                if (no1 == null) { no1 = "9"; }
                else { no1 = no1 + "9"; }
            }

            else
            {
                if (no2 == null) { no2 = "9"; }
                else { no2 = no2 + "9"; }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "7";
            if (isfastno)
            {
                if (no1 == null) { no1 = "7"; }
                else { no1 = no1 + "7"; }
            }

            else
            {
                if (no2 == null) { no2 = "7"; }
                else { no2 = no2 + "7"; }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "6";
            if (isfastno)
            {
                if (no1 == null) { no1 = "6"; }
                else { no1 = no1 + "6"; }
            }

            else
            {
                if (no2 == null) { no2 = "6"; }
                else { no2 = no2 + "6"; }
            }
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "4";
            if (isfastno)
            {
                if (no1 == null) { no1 = "4"; }
                else { no1 = no1 + "4"; }
            }

            else
            {
                if (no2 == null) { no2 = "4"; }
                else { no2 = no2 + "4"; }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "3";
            if (isfastno)
            {
                if (no1 == null) { no1 = "3"; }
                else { no1 = no1 + "3"; }
            }

            else
            {
                if (no2 == null) { no2 = "3"; }
                else { no2 = no2 + "3"; }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "1";

            if (isfastno)
            {
                if (no1 == null ) { no1 = "1"; }
                else { no1 = no1 + "1"; }
            }

            else
            {
                if (no2 == null ) { no2 = "1"; }
                else { no2 = no2 + "1"; }
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
          dis.Text = dis.Text + ".";
            if (isfastno)
            {
                if (no1 == null) { no1 = "."; }
                else { no1 = no1 + "."; }
            }

            else
            {
                if (no2 == null) { no2 = "."; }
                else { no2 = no2 + "."; }
            }
        }

        private void btndiv_click(object sender, EventArgs e)
        {
            dis.Text = dis.Text + "/";
            isfastno = false;
            opa = '/';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rest_Click(object sender, EventArgs e)
        {
            dis.Text = null;
            opa = '^';
            no1 = null;
            no2 = null;
            isfastno = true;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (dis.Text == "" || dis.Text == null) {
                dis.Text = null;
                opa = '^';
                no1 = null;
                no2 = null;
                isfastno = true;
            }

            else if (dis.Text.Length == no1.Length)
            {  if (no1 != "" && no1 != null) { no1 = no1.Remove(no1.Length - 1, 1); }
            }
            else if (dis.Text.Length == (no1.Length + 1)) { opa ='^'; isfastno = true; }
            else { MessageBox.Show("Only no3222"); if (no2 != "" && no2 != null) { no2 = no2.Remove(no2.Length - 1, 1); } }


            //display clear mathod
            if (dis.Text != "")
            {
                string delc = dis.Text.Remove(dis.Text.Length - 1, 1);
                dis.Text = delc;
            }

        }
    }
}
