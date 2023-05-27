using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona2
{

    public partial class Form1 : Form
    {
        string userInput;
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }


        private void button0_Click(object sender, EventArgs e)//knappar så att användaren kan skriva in sifror
        {
            label1.Text += "0";
            userInput += "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            userInput += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            userInput += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            userInput += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            userInput += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            userInput += "5";

        }
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            userInput += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            userInput += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            userInput += "8";

        }
        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            userInput += "9";

        }

        private void button10_Click(object sender, EventArgs e)//Ger användaren svar på dess beräkningar
        {
            try//kollar så att det går att räkna ut användarens input 
            {
                object resultat = dt.Compute(userInput, "");
                if (resultat != null)
                {
                    decimal beräknatResultat;
                    if (decimal.TryParse(resultat.ToString(), out beräknatResultat))
                    {
                        label1.Text = beräknatResultat.ToString();// visar användaren svaret och gör talet till en sting
                        userInput = beräknatResultat.ToString();
                    }
                    else
                    {
                        label1.Text = "Ogiltigt uttryck";
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Fel";
                Console.WriteLine(ex.Message);
            }

        }
        private void button11_Click(object sender, EventArgs e)//knappar för räknesätten
        {
            label1.Text += "*";
            userInput += "*";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "/";
            userInput += "/";

        }
        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
            userInput += "+";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
            userInput += "-";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
            userInput += ".";

        }

        private void label1_Click(object sender, EventArgs e)//tar bor det som står i labeln och ens beräkningar
        {
            label1.Text = "";
            userInput = "";
        }
    }
}
