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
    public partial class ProgrammerCalculator : Form
    {
        #region Variables 

        //Declare Variables

        //BaseNumber variables 
        private int newValue;
        private string primaryValue;
        private int currentlValue;
        public int basePoint;
        private string radioSwitch;
        private int currentBase;
        private double newBasePoint;
        private int newDecimalVal;
        private string newPrimaryValue;
        private int baseCount;
        
        //UnitConversion Variables 
        private string unitType;

        //NumberFunction Variables
        private int valueOne;
        private int valueTwo; 
        private string function;
        private int finalValue;

        #endregion 
        #region InitialStartUp

        public ProgrammerCalculator()
        {
            //Set Defaults

            InitializeComponent();

            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;

            radioSwitch = "Decimal";
            textBox1.ReadOnly = true;
            this.Width = 281;
            unitConversionToolStripMenuItem.Enabled = false;


        }

        #endregion 

        #region Numberbuttons

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "A";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "B";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "C";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "D";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "E";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "F";
        }
        #endregion 

        #region BaseNumber ConversionAlgorithms

        //BINARY ALGORITHMS 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //Set defualts
            //0-9
            button2.Enabled = false; 
            button3.Enabled = false; 
            button4.Enabled = false; 
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;

            newValue = 0;
            baseCount = 0;
            currentBase = 0;
            newValue = 0;
            currentlValue = 0;
            primaryValue = "";
            currentBase = 0;

            //Convert to DecimalValues (Standardisation)
 
            if (radioSwitch != "Decimal" & radioSwitch != "Binary") 
            {
                if (radioSwitch != "Hex")
                {
                    //Set NewPrimaryValue to null to avoid carrying over unwanted values
                    newPrimaryValue = "";

                    //Reverse the text using an array function

                    primaryValue = textBox1.Text;

                    int[] split = new int[primaryValue.Length];
                    int count = 0;
                    for (int i = 0; i < primaryValue.Length; i++)
                    {
                        string num = primaryValue.Substring(i, count + 1);
                        split[i] = int.Parse(num);
                    }

                    foreach (int item in split.Reverse())
                    {
                        newPrimaryValue += item;
                    }
                    count = 0;

                    //Times the values by the basenumber
                    foreach (int item in split)
                    {
                        newBasePoint = Math.Pow(basePoint, count);
                        newDecimalVal = Int32.Parse(newPrimaryValue.Substring(count, baseCount + 1));
                        newValue = newDecimalVal * (Int32)newBasePoint;
                        currentBase = currentBase + newValue;
                        count = count + 1;
                    }
                }
                else
                {
                    primaryValue = textBox1.Text;
                    try
                    {
                    currentBase = int.Parse(primaryValue, System.Globalization.NumberStyles.HexNumber);
                    } 
                    catch
                    {
                        //Continue
                    }
                }
                textBox1.Text = currentBase.ToString();
                
            } 

            //Convert Decimal to Binary (Algorithm)

            if (textBox1.Text != "" & radioSwitch != "Binary")
            {
                primaryValue = textBox1.Text;
                currentlValue = Int32.Parse(primaryValue);
                textBox1.Text = "";

                while (currentlValue != 0)
                {
                    newValue = currentlValue % 2;
                    textBox1.Text = newValue.ToString() + textBox1.Text;
                    currentlValue = currentlValue / 2;
                }
            }
           
            //Stop the algorithm from repeating and set the basepoint
            basePoint = 2;
            radioSwitch = "Binary";
        }

        
        //DECIMAL ALGORITHMS 
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            button2.Enabled = Enabled;
            button3.Enabled = Enabled;
            button4.Enabled = Enabled;
            button5.Enabled = Enabled;
            button6.Enabled = Enabled;
            button7.Enabled = Enabled;
            button8.Enabled = Enabled;
            button9.Enabled = Enabled;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;

            if (textBox1.Text != "" & radioSwitch != "Decimal")
            {

                if (radioSwitch != "Hex")
                {
                    //Set NewPrimaryValue to null to avoid carrying over unwanted values
                    newPrimaryValue = "";

                    //Reverse the text using an array function

                    primaryValue = textBox1.Text;

                    int[] split = new int[primaryValue.Length];
                    int count = 0;
                    for (int i = 0; i < primaryValue.Length; i++)
                    {
                        string num = primaryValue.Substring(i, count + 1);
                        split[i] = int.Parse(num);
                    }

                    foreach (int item in split.Reverse())
                    {
                        newPrimaryValue += item;
                    }
                    count = 0;

                    //Times the values by the basenumber
                    foreach (int item in split)
                    {
                        newBasePoint = Math.Pow(basePoint, count);
                        newDecimalVal = Int32.Parse(newPrimaryValue.Substring(count, baseCount + 1));
                        newValue = newDecimalVal * (Int32)newBasePoint;
                        currentBase = currentBase + newValue;
                        count = count + 1;
                    }
                }
                else
                {
                    primaryValue = textBox1.Text;
                    currentBase = int.Parse(primaryValue, System.Globalization.NumberStyles.HexNumber);
                }

                textBox1.Text = currentBase.ToString();
                radioSwitch = "Decimal";              
            }
        }

        //OCTAL ALGORITHMS
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = false;
            button3.Enabled = true;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            
            newValue = 0;
            baseCount = 0;
            currentBase = 0;
            newValue = 0;
            currentlValue = 0;
            primaryValue = "";
            currentBase = 0;


            if (radioSwitch != "Decimal" & radioSwitch != "Octal")
            {
                if (radioSwitch != "Hex")
                {
                    //Set NewPrimaryValue to null to avoid carrying over unwanted values
                    newPrimaryValue = "";

                    //Reverse the text using an array function

                    primaryValue = textBox1.Text;

                    int[] split = new int[primaryValue.Length];
                    int count = 0;
                    for (int i = 0; i < primaryValue.Length; i++)
                    {
                        string num = primaryValue.Substring(i, count + 1);
                        split[i] = int.Parse(num);
                    }

                    foreach (int item in split.Reverse())
                    {
                        newPrimaryValue += item;
                    }
                    count = 0;

                    //Times the values by the basenumber
                    foreach (int item in split)
                    {
                        newBasePoint = Math.Pow(basePoint, count);
                        newDecimalVal = Int32.Parse(newPrimaryValue.Substring(count, baseCount + 1));
                        newValue = newDecimalVal * (Int32)newBasePoint;
                        currentBase = currentBase + newValue;
                        count = count + 1;
                    }
                }
                else if (radioSwitch == "Hex" & radioSwitch != "Octal")
                {
                    primaryValue = textBox1.Text;
                    try
                    {
                        currentBase = int.Parse(primaryValue, System.Globalization.NumberStyles.HexNumber);
                    }
                    catch
                    {
                        //Continue
                    }
                }
                textBox1.Text = currentBase.ToString();

            } 
            if (textBox1.Text != "" & radioSwitch != "Octal")
            {
                primaryValue = textBox1.Text;
                currentlValue = Int32.Parse(primaryValue);
                textBox1.Text = "";

                while (currentlValue != 0)
                {
                    newValue = currentlValue % 8;
                    textBox1.Text = newValue.ToString() + textBox1.Text;
                    currentlValue = currentlValue / 8;
                }
            }
            //Stop the algorithm from repeating and set the basepoint
            basePoint = 8;
            radioSwitch = "Octal";
        }

        //HEXIDECIMAL ALGORITHMS 
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button2.Enabled = Enabled;
            button3.Enabled = Enabled;
            button4.Enabled = Enabled;
            button5.Enabled = Enabled;
            button6.Enabled = Enabled;
            button7.Enabled = Enabled;
            button8.Enabled = Enabled;
            button9.Enabled = Enabled;

            if (radioSwitch != "Hex" & radioSwitch != "Decimal")
            {
                //Set NewPrimaryValue to null to avoid carrying over unwanted values
                    newPrimaryValue = "";


                    //Reverse the text using an array function

                    primaryValue = textBox1.Text;

                    int[] split = new int[primaryValue.Length];
                    int count = 0;
                    for (int i = 0; i < primaryValue.Length; i++)
                    {
                        string num = primaryValue.Substring(i, count + 1);
                        split[i] = int.Parse(num);
                    }

                    foreach (int item in split.Reverse())
                    {
                        newPrimaryValue += item;
                    }
                    count = 0;

                    //Times the values by the basenumber
                    foreach (int item in split)
                    {
                        newBasePoint = Math.Pow(basePoint, count);
                        newDecimalVal = Int32.Parse(newPrimaryValue.Substring(count, baseCount + 1));
                        newValue = newDecimalVal * (Int32)newBasePoint;
                        currentBase = currentBase + newValue;
                        count = count + 1;
                    }
                    textBox1.Text = currentBase.ToString();
            }
            if (textBox1.Text != "" & radioSwitch != "Hex")
            {
                primaryValue = textBox1.Text;
                currentlValue = Int32.Parse(primaryValue);
                textBox1.Text = "";

                while (currentlValue != 0)
                {
                    newValue = currentlValue % 16;

                    //Convert letters to thier respective numeric value
                    switch (newValue)
                    {
                        case 15:
                            textBox1.Text = "F" + textBox1.Text;
                            break;
                        case 14:
                            textBox1.Text = "E" + textBox1.Text;
                            break;
                        case 13:
                            textBox1.Text = "D" + textBox1.Text;
                            break;
                        case 12:
                            textBox1.Text = "C" + textBox1.Text;
                            break;
                        case 11:
                            textBox1.Text = "B" + textBox1.Text;
                            break;
                        case 10:
                            textBox1.Text = "A" + textBox1.Text;
                            break;
                        default:
                            textBox1.Text = newValue.ToString() + textBox1.Text;
                            break;
                    }
                    currentlValue = currentlValue / 16;
                }
            }

            //Stop the algorithm from repeating and set the basepoint
            basePoint = 16;
            radioSwitch = "Hex";
        }
#endregion 
        #region menuStrip

        //Return to Main 
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainform = new Form1();
            mainform.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About__Calculator about = new About__Calculator();
            about.Show();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 281;
            unitConversionToolStripMenuItem1.Enabled = true;
            unitConversionToolStripMenuItem.Enabled = false;
        }

        //SHOT UNIT CONVERSION WINDOW

        private void unitConversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 479;
            unitConversionToolStripMenuItem.Enabled = true;
            unitConversionToolStripMenuItem1.Enabled = false;
        }


        #endregion 

        #region FunctionButtons 

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                primaryValue = textBox1.Text;
                textBox1.Text = primaryValue.Remove(primaryValue.Length - 1, 1);
                primaryValue = "";
            }
            catch
            {
                //Continue;
            }
           
        }

        //EQUALS BUTTON 

        private void button15_Click(object sender, EventArgs e)
        {
            valueTwo = Int32.Parse(textBox1.Text);

            if (function == "Plus")
            {
                textBox1.Text = "";
                finalValue = valueOne + valueTwo;
                textBox1.Text = finalValue.ToString();
            }

        }

        //Addition 

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioSwitch == "Decimal")
            {
                valueOne = Int32.Parse(textBox1.Text);
                function = "Plus";
                textBox1.Text = "";
            }

        }

        //CLEAR BUTTONS 
        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            primaryValue = "";
            newPrimaryValue = "";
        }

        #endregion 
        #region UnitConversionComboBox

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitType = comboBox1.Text;

            if (comboBox1.Text == "Power")
            {
                //Set Defaults 
                comboBox2.Text = "killowatt";
                comboBox3.Text = "killowatt";

                comboBox2.Items.Add("BTU/minute");
                comboBox2.Items.Add("Foot-Pound/minute");
                comboBox2.Items.Add("Horse power");
                comboBox2.Items.Add("Killowatt");
                comboBox2.Items.Add("Watt");

                comboBox3.Items.Add("BTU/minute");
                comboBox3.Items.Add("Foot-Pound/minute");
                comboBox3.Items.Add("Horse power");
                comboBox3.Items.Add("Killowatt");
                comboBox3.Items.Add("Watt");

            }
        }

#endregion
 
        #region unitConversion Functions 

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        #endregion 

        #region GraphicsAndAnimations 

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {

        }

        #endregion 
    }
}
