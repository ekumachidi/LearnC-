using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Tut_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        #region Declarations       
        double firstValue = 0.0;        
        bool btnAddClicked = false;
        bool btnSubClicked = false;
        bool btnMultClicked = false;
        bool btnDivClicked = false;
        bool btnModClicked = false;
        bool btnEqClicked = false;
        bool isFirst = true;
        string lastOp;
        #endregion

        #region Numeric Buttons

        /*private void allButtons_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
            {
                Button b = sender as Button;
                Output.Text += b.Text;
            }
            else
            {
                Button b = sender as Button;
                Output.Text += b.Text;
            }
                
            isFirst = false;
        }*/


        private void btn0_Click(object sender, EventArgs e)
        {
            if ( isFirst == true)
            {
                Output.Text = btn0.Text;
            }
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn0.Text : btn0.Text;
            isFirst = false;
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
            {
                Output.Text = btn1.Text; 
            }
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn1.Text : btn1.Text;
            isFirst = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
                Output.Text = btn2.Text;
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn2.Text : btn2.Text;
            isFirst = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
                Output.Text = btn3.Text;
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn3.Text : btn3.Text;
            isFirst = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
                Output.Text = (Output.Text != "0") ? Output.Text + btn4.Text : btn4.Text;
            else
                Output.Text = btn4.Text;
            isFirst = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
                Output.Text = btn5.Text;
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn5.Text : btn5.Text;
            isFirst = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
                Output.Text = btn6.Text;
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn6.Text : btn6.Text;
            isFirst = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
                Output.Text = btn7.Text;
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn7.Text : btn7.Text;
            isFirst = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
                Output.Text = btn8.Text;
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn8.Text : btn8.Text;
            isFirst = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isFirst == true)
                Output.Text = btn9.Text;
            else
                Output.Text = (Output.Text != "0") ? Output.Text + btn9.Text : btn9.Text;
            isFirst = false;
        }
        #endregion

        #region Arithmetic Operators
        private void btnEq_Click(object sender, EventArgs e)
        {
            if (btnAddClicked == true)
            {
                firstValue = firstValue + double.Parse(Output.Text);
            }
            else if (btnSubClicked == true)
            {
                firstValue = firstValue - double.Parse(Output.Text);
            }
            else if (btnMultClicked == true)
            {
                firstValue = firstValue * double.Parse(Output.Text);
            }
            else if (btnDivClicked == true)
            {
                firstValue = firstValue / double.Parse(Output.Text);
            }
            else if (btnModClicked == true)
            {
                firstValue = firstValue % double.Parse(Output.Text);
            }
            Output.Text = firstValue.ToString();
            firstValue = 0.0;
            isFirst = true;
        } 
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operation();            
            
            #region Bool
            btnAddClicked = true;
            btnSubClicked = false;
            btnMultClicked = false;
            btnDivClicked = false;
            isFirst = true;
            #endregion           
        }

        private void Operation()
        {
            if (firstValue == 0)
            {
                firstValue = firstValue + double.Parse(Output.Text);
            }
            else
            {
                if (btnAddClicked == true)
                {
                    firstValue = firstValue + double.Parse(Output.Text);
                }
                else if (btnSubClicked == true)
                {
                    firstValue = firstValue - double.Parse(Output.Text);
                }
                else if (btnMultClicked == true)
                {
                    firstValue = firstValue * double.Parse(Output.Text);
                }
                else if (btnDivClicked == true)
                {
                    firstValue = firstValue / double.Parse(Output.Text);
                }
                else if (btnModClicked == true)
                {
                    firstValue = firstValue % double.Parse(Output.Text);
                }
            }
            Output.Text = firstValue.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            Operation();            
                        
            #region Bool
            btnAddClicked = false;
            btnSubClicked = true;
            btnMultClicked = false;
            btnDivClicked = false;
            btnEqClicked = false; 
            #endregion           
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            #region Bool
            btnAddClicked = false;
            btnSubClicked = false;
            btnMultClicked = true;
            btnDivClicked = false;
            isFirst = true;
            #endregion                        
            Operation();            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            Operation();            

            #region Bool
            btnAddClicked = false;
            btnSubClicked = false;
            btnMultClicked = false;
            btnDivClicked = true;
            isFirst = true;
            #endregion            
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            #region Bool
            btnModClicked = true;
            btnAddClicked = false;
            btnSubClicked = false;
            btnMultClicked = false;
            btnDivClicked = false;
            isFirst = true;
            #endregion
            Operation();             
        }
                
        #endregion

       #region Function Buttons
       private void btnDel_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

       private void btnClr_Click(object sender, EventArgs e)
        {           
            Output.Clear();
            Output.Text = "";            
            firstValue = 0.0;
        }
       #endregion
       
        private void Output_TextChanged(object sender, EventArgs e)
        {            
                
        }      
                
    }
}
