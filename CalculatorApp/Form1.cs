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
            
        }
        string collect = "";
        bool deleteKey;
      
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

       

        private void btnStart_Click(object sender, EventArgs e)
        {          
            txtDisplay.Text = "0";
            collect = "";
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

            string pattern1 = @"([\+\-\*\%\/])";
            string[] result1 = Regex.Split(collect, pattern1);

            // Handling Multiplication, Division and Modulo first
            for(int i = 0; i < result1.Length; i++)
            {
                if (result1[i] == "*")
                {
                    int answer = Multiplication(i, result1);
                    result1 = UpdateExpression(i, result1,  answer);
                    i--;
                }
                else if (result1[i] == "/")
                {
                    int answer = Division(i, result1);

                    if(answer == int.MinValue)
                    {
                        txtAnswer.Text = "Error: Division by Zero";
                        collect = "";
                        return;
                    }
                    result1 = UpdateExpression(i, result1, answer);
                    i--;
                }
                else if (result1[i] == "%")
                {
                    int answer = Remainder(i, result1);
                    result1 = UpdateExpression(i, result1 , answer);
                    i--;
                }
            }

            //Handling Addition and Subtraction
            for(int a = 0; a < result1.Length; a++)
            {
                if (result1[a] == "+")
                {
                    int answer = Addition(a, result1);  
                    result1 = UpdateExpression(a, result1, answer);
                    a--;
                }
                else if (result1[a] == "-")
                {
                    int answer = Subtraction(a, result1);
                    result1 = UpdateExpression(a, result1 , answer);
                    a--;
                }
            }

            //Displaying the answer that will be the only one left at index[0]
            txtAnswer.Text = result1[0];
            collect = "";

   //         int index = 0;

   //         int answer =int.Parse(result1[0]);
   //         int divisionAnswer = 1;
   //         for (int i = 0; i < result1.Length; i++)
   //         {
   //             if (result1[i] == "*") 
   //             {
   //                 index = i;
   //                 answer = Multiplication(index, result1, answer); 
   //             }
   //             else if(result1[i] == "/")
   //             {
   //                 index = i;
   //                 answer = Division(index, result1, answer);


			//		if (answer == 0)
   //                 {						
   //                     i = result1.Length;
   //                     divisionAnswer = answer;
   //                     break;
			//		}

			//	}
   //             else if(result1[i] == "+")
   //             {
   //                 index = i;
   //                 answer = Addition(index, result1, answer);
   //             }
   //             else if(result1[i] == "-")
   //             {
   //                 index = i;
   //                 answer = Subtraction(index, result1, answer);

   //             }
   //             else if (result1[i] == "%")
   //             {
   //                 index = i;
   //                 answer = Remainder(index, result1, answer);
   //             }
   //         }
           
   //         if(divisionAnswer == 0)
   //         {
			//	txtAnswer.Text = "Unknown Error: null";
			//	collect = "";
			//}
   //         else
   //         {
			//	txtAnswer.Text = answer.ToString();
			//	collect = "";
			//}
            
        }
        public string[] UpdateExpression(int index, string[] results, int answer)
        {
            List<string> updatedExpression = new List<string>(results);
            updatedExpression[index - 1] = answer.ToString(); //Places the latest answer in the correct index
            updatedExpression.RemoveAt(index);    // Removes the operator
            updatedExpression.RemoveAt(index);  //Removes the second number used in the calculation
            return updatedExpression.ToArray();
        }
        public int Multiplication(int index, string[] result1)
        {
            int num1 = int.Parse(result1[index - 1]);
            int num2 = int.Parse(result1[index + 1]);
            return num1 * num2;
        }
        public int Division(int index, string[] result1)
        {
            int num1 = int.Parse(result1[index - 1]);
            int num2 = int.Parse(result1[index + 1]);
            if (num2 == 0)
                return int.MinValue;

            return num1 / num2;
			
			//if (num == 0)
   //         {
   //             returnAnswer = 0;
   //             return returnAnswer;
   //         }
   //         else 
   //         {
			//	returnAnswer = answer / num;
			//	return returnAnswer;
			//}
             
        }
        public int Remainder(int index, string[] result1)
        {
            int num1 = int.Parse(result1[index - 1]);
            int num2 = int.Parse(result1[index + 1]);
            return num1 % num2; 
        }
        public int Addition(int index, string[] result1)
        {
            int num1 = int.Parse(result1[index - 1]);   
            int num2 = int.Parse(result1[index + 1]);
            return num1 + num2 ;
        }
        public int Subtraction(int index, string[] result1)
        {
            int num1 = int.Parse(result1[index - 1]);
            int num2 = int.Parse(result1[index + 1]);
            return num1 - num2;
        }
       

      

		
	}
}
