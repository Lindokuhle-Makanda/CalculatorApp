using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }
        string collect = "";
        bool deleteKey;
      

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Stores the key that was pressed
            char keyPressed = e.KeyChar;

            //use Switch case because theres going to be multiple alterntives

            switch (keyPressed)
            {
                case 'C':
                case 'c':
                    btnStart.Focus();
                    break;
                case ')':
                case '(':
                    btnParenthesis.Focus();
                    break;
                case '%':
                    btnModulas.Focus();
                    break;
                case '/':
                    btnDivide.Focus();
                    break;
                case '*':
                case 'x':
                    btnMultiply.Focus();
                    break;
                case '-':
                    btnMinus.Focus();
                    break;
                case '+':
                    btnAddition.Focus();
                    break;
                case '=':
                    btnEquals.Focus();
                    break;
                case '.':
                    btnPeriod.Focus();
                    break;
                case '0':
                    btnZero.Focus();
                    break;
                case '1':
                    btnOne.Focus();
                    break;
                case '2':
                    btnTwo.Focus();
                    break;
                case '3':
                    btnThree.Focus();
                    break;
                case '4':
                    btnFour.Focus();
                    break;
                case '5':
                    btnFive.Focus();
                    break;
                case '6':
                    btnSix.Focus();
                    break;
                case '7':
                    btnSeven.Focus();
                    break;
                case '8':
                    btnEight.Focus();
                    break;
                case '9':
                    btnNine.Focus();
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += ".";
            txtDisplay.Text = collect;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "0";
            txtDisplay.Text = collect;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "1";
            txtDisplay.Text = collect;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "2";
            txtDisplay.Text = collect;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "3";
            txtDisplay.Text = collect;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "4";
            txtDisplay.Text = collect;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "5";
            txtDisplay.Text = collect;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "6";
            txtDisplay.Text = collect;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "7";
            txtDisplay.Text = collect;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "8";
            txtDisplay.Text = collect;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "9";
            txtDisplay.Text = collect;
        }

        private void btnParenthesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "()";
            txtDisplay.Text = collect;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {          
            txtDisplay.Text = "0";
            collect = " ";
            txtAnswer.Text = "0";
        }

        private void btnModulas_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "%";
            txtDisplay.Text = collect;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "/";
            txtDisplay.Text = collect;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "*";
            txtDisplay.Text = collect;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "-";
            txtDisplay.Text = collect;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            collect += "+";
            txtDisplay.Text = collect;
        }

        private void btnDeleteKey_Click(object sender, EventArgs e)
        {
            deleteKey = true;
            //string collect1 = txtDisplay.Text ;
            string a = "";
            for(int i = 0; i < collect.Length - 1; i++)
            {
                char c = collect[i];
                a += $"{c}";
            }
            if (deleteKey)
            {
                collect = a;
                deleteKey = false;
            }
            txtDisplay.Text = collect.ToString();
            a = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string keep = collect;
            txtAnswer.Clear();
            string pattern = @"^\d+ |\D+";
            string[] results;
            results = Regex.Split(collect, pattern);
            int[] digits = new int[results.Length];





            string pattern1 = @"([\+\-\*\%\/])";
            string[] result1 = Regex.Split(collect, pattern1);

            int index = 0;
            int answer =int.Parse(result1[0]);
            for (int i = 0; i < result1.Length; i++)
            {
                if (result1[i] == "*") 
                {
                    index = i;
                    answer = Multiplication(index, result1, answer); 
                }
                else if(result1[i] == "/")
                {
                    index = i;
                    answer = Division(index, result1, answer);
                }
                else if(result1[i] == "+")
                {
                    index = i;
                    answer = Addition(index, result1, answer);
                }
                else if(result1[i] == "-")
                {
                    index = i;
                    answer = Subtraction(index, result1, answer);
                }
                else if (result1[i] == "%")
                {
                    index = i;
                    answer = Remainder(index, result1, answer);
                }
            }
           
            txtAnswer.Text = answer.ToString();
            collect = "";
        }
        public int Multiplication(int index, string[] result1, int answer)
        {
            int num = int.Parse(result1[index + 1]);
            int returnAnswer = answer * num;
            return returnAnswer;
        }
        public int Division(int index, string[] result1, int answer)
        {
            int num = int.Parse(result1[index + 1]);
            int returnAnswer = answer / num;
            return returnAnswer;
        }
        public int Addition(int index, string[] result1, int answer)
        {
            int num = int.Parse(result1[index + 1]);
            int returnAnswer = answer + num;
            return returnAnswer;
        }
        public int Subtraction(int index, string[] result1, int answer)
        {
            int num = int.Parse(result1[index + 1]);
            int returnAnswer = answer - num;
            return returnAnswer;
        }
        public int Remainder(int index, string[] result1, int answer)
        {
            int num = int.Parse(result1[index + 1]);
            int returnAnswer = answer % num;
            return returnAnswer;
        }
    }
}
