namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        String option;
        int result;

        private void btn1_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            total_label.Text = total_label.Text + "0";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            total_label.Clear();
            num1 = 0;
            num2 = 0;
            result = 0; 
                
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(total_label.Text);
            total_label.Clear();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(total_label.Text);
            total_label.Clear();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(total_label.Text);
            total_label.Clear();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(total_label.Text);

            if(option == "+")
            {
                result = num1 + num2;   
            }

            if (option == "-") 
            {
                result = num1 - num2;
            }

            if (option == "*") 
            {
                result = num1 * num2;
            }

            total_label.Text = result + "";

        }
    }
}
