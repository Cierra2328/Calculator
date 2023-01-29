namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long leftNumber;
        int operation;
        int ADD = 1;
        int SUBTRACT = 2;
        int DIVIDE = 4;
        int MULTIPLY = 3;
        int numberLength;
        private long IntConversion(string input) //converts number from string to int
        {
            long number = Convert.ToInt64(input);
            return number;
        }
        private long GetNumber(int Length, string input) //gets the right number
        {
            string rightNumber = input.Substring(Length + 1);
            long rightNum = Convert.ToInt64(rightNumber);
            return rightNum;
        }
        private bool EmptyString(string text) //did the user enter anything?
        {
            bool result;
            if(text.Length == 0)
            {
                result = false; //meaning nothing was entered
            }
            else
            {
                result = true;
            }
            return result;
        }
        private long Solve(int operation, long leftNum, long rightNum) //math operations
        {
            long answer;
            if(operation == ADD)
            {
                answer = leftNum + rightNum;
            }
            else if(operation == SUBTRACT)
            {
                answer = leftNum - rightNum;
            }
            else if(operation == MULTIPLY)
            {
                answer = leftNum * rightNum;
            }
            else
            {
                answer = leftNum / rightNum;
            }

            return answer;
        }

        private void AddBtn_Click(object sender, EventArgs e) //add button click event 
        {
            bool input = EmptyString(InputLbl.Text); //checking if the user entered anything
            if (input && !InputLbl.Text.Contains("=")) //if ^ yes and we haven't already solved the equation
            {
                leftNumber = IntConversion(InputLbl.Text);
                numberLength = InputLbl.Text.Length;
                InputLbl.Text += "+";
                operation = 1;
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e) //enter button click event
        {
            bool result = EmptyString(InputLbl.Text);
            if (InputLbl.Text.Contains("=") || result == false) //if a solved equation is in the window or the string is empty 
            {
                InputLbl.Text += ""; //reset label to nothing
            }
            else
            {
                //convert number and solve the problem
                long rightNumber = GetNumber(numberLength, InputLbl.Text); 
                long answer = Solve(operation, leftNumber, rightNumber);
                InputLbl.Text += "=" + Convert.ToString(answer);
                
                
            }
            
        }

        private void ClearBtn_Click(object sender, EventArgs e) //clear the input label
        {
            numberLength = 0;
            InputLbl.Text = "";
            operation = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //each of the following is a click event for each number, it just puts the number 
        //in the input label unless the input label contains a solved equation, if it 
        //does, then it resets the label and then enters the number
        private void OneBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += OneBtn.Text;
            }
            else
            {
                InputLbl.Text += OneBtn.Text;
            }
        }

        private void TwoBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += TwoBtn.Text;
            }
            else
            {
                InputLbl.Text += TwoBtn.Text;
            }
        }

        private void ThreeBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += ThreeBtn.Text;
            }
            else
            {
                InputLbl.Text += ThreeBtn.Text;
            }
        }

        private void FourBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += FourBtn.Text;
            }
            else
            {
                InputLbl.Text += FourBtn.Text;
            }
        }

        private void FiveBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += FiveBtn.Text;
            }
            else
            {
                InputLbl.Text += FiveBtn.Text;
            }
        }

        private void SixBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += SixBtn.Text;
            }
            else
            {
                InputLbl.Text += SixBtn.Text;
            }
        }

        private void SevenBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += SevenBtn.Text;
            }
            else
            {
                InputLbl.Text += SevenBtn.Text;
            }
        }

        private void EightBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += EightBtn.Text;
            }
            else
            {
                InputLbl.Text += EightBtn.Text;
            }
        }

        private void NineBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += NineBtn.Text;
            }
            else
            {
                InputLbl.Text += NineBtn.Text;
            }
        }

        private void ZeroBtn_Click_1(object sender, EventArgs e)
        {
            if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += ZeroBtn.Text;
            }
            else
            {
                InputLbl.Text += ZeroBtn.Text;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e) //ext button
        {
            this.Close();
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            if(InputLbl.Text == "")
            {
                InputLbl.Text += "-";
            }
            else if (InputLbl.Text.Contains("="))
            {
                InputLbl.Text = "";
                InputLbl.Text += "-";
            }
            else if(operation != 0)
            {
                InputLbl.Text += "-";
            }
            else
            {
                leftNumber = IntConversion(InputLbl.Text);
                numberLength = InputLbl.Text.Length;
                InputLbl.Text += "-";
                operation = 2;
            }
           
        }
        //each of these is a click event for a math operation, it first checks
        //that the string isn't empty, then converts the number entered into the label
        //to an integer and saves it as the 'numberLength'. We use that length later to
        //determine what the right number is 
        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            bool input = EmptyString(InputLbl.Text);
            if (input && !InputLbl.Text.Contains("="))
            {
                leftNumber = IntConversion(InputLbl.Text);
                numberLength = InputLbl.Text.Length;
                InputLbl.Text += "*";
                operation = 3;
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            bool input = EmptyString(InputLbl.Text);
            if (input && !InputLbl.Text.Contains("="))
            {
                leftNumber = IntConversion(InputLbl.Text);
                numberLength = InputLbl.Text.Length;
                InputLbl.Text += "/";
                operation = 4;
            }
        }
        //This is a click event for the delete button. It removes the last number or operation
        //in the input label. If the delete button deletes an operation, it resets the operation. 
        //If the delete button is clicked and there is nothing in the label, it doesn't do anything.
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
           
            int length = InputLbl.Text.Length;
            if (length > 0 && (InputLbl.Text.Substring(length-1) == "+" || InputLbl.Text.Substring(length-1) == "/" || InputLbl.Text.Substring(length-1) == "*"))
            {
                operation = 0;
                string newInput = InputLbl.Text.Remove(length - 1);
                InputLbl.Text = "";
                InputLbl.Text += newInput;
               
                
            }
            else if (length != 0 )
            {
                
                string newInput = InputLbl.Text.Remove(length - 1);
                InputLbl.Text = newInput;
                
            }
            else
            {
                InputLbl.Text = "";
            }
            
        }
    }
}