using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SavvyTempV1
{
    public partial class Form1 : Form
    {
        #region Variables 

        private int val1;
        private int val2;
        private int val3;
        private string function;
        private int MultiCast;
        private int chain; 

        #endregion

        

        public Form1()
        {
            InitializeComponent();
        }

        #region NumberButtons 

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        #endregion 
        #region equalsFunction 

        private void button15_Click(object sender, EventArgs e)
        {
            val2 = Int32.Parse(textBox1.Text);

            if (chain == 0)
            {
                chain = 1;

                if (function == "Plus")
                {
                    val3 = val1 + val2;
                }
                else if (function == "Minus")
                {
                    val3 = val1 - val2;
                }
                else if (function == "Times")
                {
                    val3 = val1 * val2;
                }
                else if (function == "Devide")
                {
                    val3 = val1 / val2;
                }
            }
            else if (chain == 1) 
            {
                
               if (function == "Plus")
                {
                    val3 = Int32.Parse(label1.Text) + val2;
                }
                else if (function == "Minus")
                {
                    val3 = Int32.Parse(label1.Text) - val2;
                }
                else if (function == "Times")
                {
                    val3 = Int32.Parse(label1.Text) * val2;
                }
                else if (function == "Devide")
                {
                    val3 = Int32.Parse(label1.Text) / val2;
                }
            
            }
                label1.Text = val3.ToString();
                MultiCast = 0;
            
        }

        #endregion 
        #region operations 

        private void button1_Click(object sender, EventArgs e)
        {
            if (MultiCast == 1)
            {
                val2 = val1 + Int32.Parse(textBox1.Text);
                textBox1.Text = val2.ToString(); 
            } 

            function = "Plus";
            val1 = Int32.Parse(textBox1.Text);
            textBox1.Clear();
            MultiCast = 1; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MultiCast == 1)
            {
                val2 = val1 - Int32.Parse(textBox1.Text);
                textBox1.Text = val2.ToString();
            }

            function = "Minus";
            val1 = Int32.Parse(textBox1.Text);
            textBox1.Clear();
            MultiCast = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MultiCast == 1)
            {
                val2 = val1 * Int32.Parse(textBox1.Text);
                textBox1.Text = val2.ToString();
            }

            function = "Times";
            val1 = Int32.Parse(textBox1.Text);
            textBox1.Clear();
            MultiCast = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MultiCast == 1)
            {
                val2 = val1 / Int32.Parse(textBox1.Text);
                textBox1.Text = val2.ToString();
            }

            function = "Devide";
            val1 = Int32.Parse(textBox1.Text);
            textBox1.Clear();
            MultiCast = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            function = "";
                val1 = 0;
                val2 = 0;
                val3 = 0;
                textBox1.Text = "";
                label1.Text = null;
                MultiCast = 0;
                chain = 0;
        }

        #endregion 
        #region TopDownMenu

        private void programmerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgrammerCalculator myNewForm = new ProgrammerCalculator();
            myNewForm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        #endregion 
    }
}
