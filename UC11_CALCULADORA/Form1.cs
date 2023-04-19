using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_CALCULADORA
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonn0_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonn9_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "9";
        }

        private void buttonn8_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "6";
        }

        private void buttonn5_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "5";
        }

        private void buttonn4_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRESULTADO.Text += "1";
        }

        private void buttonSOMA_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxRESULTADO.Text);
            textBoxRESULTADO.Text = "";
            operacao = "soma";
            labelOPERACAO.Text = "+";

        }

        private void buttonIGUAL_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxRESULTADO.Text);
            if (operacao == "soma")
            {
                textBoxRESULTADO.Text = Convert.ToString(valor1 + valor2);  
            }
        }
    }
}
