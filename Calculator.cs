namespace forms_calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string[] OPERATORS = { "+", "-", "x", "÷" };
        string[] NUMBERS = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "." };

        public List<string> CalculationList = new();
        public string ScreenText = "";
        private void Calculator_Load(object sender, EventArgs e)
        {
            Textbox_Screen.Text = "Default Text";
        }
        private void Button_AC_Click(object sender, EventArgs e)
        {
            CalculationList.Clear();
            Textbox_Screen.Text = "";
        }

        public void Button_Number(object sender, EventArgs e)
        {
            string ButtonValue = ((Button)sender).Text;
            try
            {
                string LastValue = CalculationList[CalculationList.Count - 1];
                if (NUMBERS.Any(LastValue.Contains))
                {
                    CalculationList[CalculationList.Count - 1] = LastValue + ButtonValue;
                    ScreenDraw(CalculationList);
                    return;
                }
                Textbox_Debug.Text = ButtonValue;
                ScreenAdd(ButtonValue);
                ScreenDraw(CalculationList);
            }
            catch
            {
                Textbox_Debug.Text = ButtonValue;
                ScreenAdd(ButtonValue);
                ScreenDraw(CalculationList);
                return;
            }
        }
        public void ScreenAdd(string value)
        {
            CalculationList.Add(value);
        }
        public void ScreenDraw(List<string> CalculationList)
        {
            ScreenText = "";
            foreach (string Calculation in CalculationList)
            {
                //if (OPERATORS.Any(Calculation.Contains))
                //{
                //    ScreenText = "";
                //}
                ScreenText += Calculation;
            }
            Textbox_Screen.Text = ScreenText;
        }

        private void Button_Operator(object sender, EventArgs e)
        {
            string ButtonValue = ((Button)sender).Text;
            Textbox_Debug.Text = ButtonValue;
            ScreenAdd(ButtonValue);
            ScreenDraw(CalculationList);

        }

        private void Button_Del_Click(object sender, EventArgs e)
        {
            try
            {
                string LastValue = CalculationList[CalculationList.Count - 1];
                if (LastValue.Length > 1)
                {
                    CalculationList[CalculationList.Count - 1] = LastValue.TrimEnd(LastValue[LastValue.Length - 1]);
                    ScreenDraw(CalculationList);
                    return;
                }
                else
                {
                    CalculationList.RemoveAt(CalculationList.Count - 1);
                    ScreenDraw(CalculationList);
                    return;
                }
                Textbox_Debug.Text = "Delete";
            }
            catch
            {
                Textbox_Debug.Text = "Delete: Couldn\'t";
                return;
            }

        }

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            decimal Answer;
            foreach(string item in CalculationList)
            {
                if (NUMBERS.Any(item.Contains))
                {
                    if (Answer.ToString() = "")
                    {
                        Answer = System.Convert.ToDecimal(item);
                    }
                    else
                    {
                        //Answer
                    }
                }
            }
            Textbox_Screen.Text = Answer.ToString();
        }
    }
}