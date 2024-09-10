namespace calculator
{
    public partial class Form1 : Form
    {
        private IClcute calcute;
        public Form1()
        {
            InitializeComponent();

            calcute = new Calcute();
        }

        bool validationInput()
        {
            bool isvalid = true;

            if (number1.Value == 0)
            {
                isvalid = false;
                lblResult.Text = "لطفا عدد اول را وارد کنید";
            }
            else
            {
                if (number2.Value == 0)
                {
                    isvalid = false;
                    lblResult.Text = "لطفا عدد دوم را وارد کنید";
                }
            }

            return isvalid;

        }

        private void sumbtn_Click(object sender, EventArgs e)
        {
            if (validationInput())
            {
                int sum = calcute.sum((int)number1.Value, (int)number2.Value);
                lblResult.Text = sum.ToString();
            }
        }

        private void minusebtn_Click(object sender, EventArgs e)
        {
            number2.Enabled = true;

            if (validationInput())
            {
                int minuse = calcute.minuse((int)number1.Value, (int)number2.Value);
                lblResult.Text = minuse.ToString();
            }
        }

        private void multiplrbtn_Click(object sender, EventArgs e)
        {
            number2.Enabled = true;

            if (validationInput())
            {
                int multiple = calcute.multiple((int)number1.Value, (int)number2.Value);
                lblResult.Text = multiple.ToString();
            }
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            number2.Enabled = true;

            if (validationInput())
            {
                int divide = calcute.divide((int)number1.Value, (int)number2.Value);
                lblResult.Text = divide.ToString();
            }
        }

        private void personbtn_Click(object sender, EventArgs e)
        {
            number2.Enabled = true;

            if (validationInput())
            {
                double person = calcute.person((double)number1.Value, (double)number2.Value);
                lblResult.Text = person.ToString() + "%";
            }
        }

        private void tavan_Click(object sender, EventArgs e)
        {
            number2.Enabled = true;

            if (validationInput())
            {
                double tavan = calcute.tavan((double)number1.Value, (double)number2.Value);
                lblResult.Text = tavan.ToString();
            }
        }

        private void tava2btn_Click(object sender, EventArgs e)
        {
            number2.Enabled = false;

            double tavan2 = calcute.tavan2((double)number1.Value);
            lblResult.Text = tavan2.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
