using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace Simple_Windows_Calculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        private const double NULL_DOUBLE_VALUE = 1E15;
        private const char NULL_OPERATOR = '\0';
        private double[] operand = new double[2] { NULL_DOUBLE_VALUE, NULL_DOUBLE_VALUE };
        private double result = NULL_DOUBLE_VALUE;
        private char calledOperator;
        private readonly string DivideByZeroText = "Cannot divide by zero";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Hide blinking cursor from textboxes

        private void MainDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(textMainDisplay.Handle);
        }

        private void ButtonNumbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //textMainDisplay.Text += button.Text;
            //MessageBox.Show($"Button {button.Text} clicked", caption: "Number clicked");
            if (textMainDisplay.TextLength < 13 + Convert.ToInt32(textMainDisplay.Text.Contains(btnDot.Text)) + Convert.ToInt32(textMainDisplay.Text.Contains("-")))
            {
                if (textMainDisplay.Text.Equals("0"))
                {
                    textMainDisplay.Text = button.Text;
                }
                else
                {
                    textMainDisplay.Text += button.Text;
                }
            }
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            Button btnDot = (Button)sender;
            //MessageBox.Show("Button Dot clicked");
            if (textMainDisplay.Text.Contains(btnDot.Text) == false)
            {
                textMainDisplay.Text += btnDot.Text;
            }
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.Parse(textMainDisplay.Text) != 0.0)
            {
                textMainDisplay.Text = Convert.ToString(Convert.ToDouble(textMainDisplay.Text) * -1.0);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textMainDisplay.Text = "0";
            textFormulaDisplay.Clear();
        }

        private void ButtonClearEntry_Click(object sender, EventArgs e)
        {
            if (textFormulaDisplay.Text.Contains("="))
            {
                textFormulaDisplay.Clear();
            }
            textMainDisplay.Text = "0";
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (textMainDisplay.Text.Length == 1)
            {
                textMainDisplay.Text = "0";
            } else
            {
                textMainDisplay.Text = textMainDisplay.Text.Remove(textMainDisplay.Text.Length - 1);
            }
        }

        private void ButtonBasicOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //MessageBox.Show(button.Text + " clicked");
            // Cai ket qua dang hien thi tren MainDisplay trung khop voi ket qua luu trong bien tam
            // Hai kết quả giống nhau, đẩy nó lên trên cái FormulaDisplay
            double mainDisplayValue = Double.Parse(textMainDisplay.Text);
            if (mainDisplayValue == result)
            {
                operand[0] = result;
            }
            else if (textFormulaDisplay.Text != String.Empty)
            {
                // Neu ma cai chuoi tren FormulaDisplay khong rong
                if (textFormulaDisplay.Text.Contains("+"))
                {
                    operand[0] += mainDisplayValue;
                } 
                else if (textFormulaDisplay.Text.Contains("–")) // dấu trừ trong đây là ký tự đặc biệt, nên chú ý
                {
                    operand[0] -= mainDisplayValue;
                } 
                else if (textFormulaDisplay.Text.Contains("×"))
                {
                    operand[0] *= mainDisplayValue;
                }
                else if (textFormulaDisplay.Text.Contains("÷"))
                {
                    if (mainDisplayValue == 0)
                    {
                        DivideByZero();
                        return;
                    }
                    operand[0] /= mainDisplayValue;
                }
            }
            else
            {
                // truong hop textFormulaDisplay rong
                operand[0] = mainDisplayValue;
            }
            textFormulaDisplay.Text = operand[0].ToString() + " " + button.Text;
            textMainDisplay.Text = "0";
        }

        private void ResetCalculationValues()
        {
            operand[0] = operand[1] = result = NULL_DOUBLE_VALUE;
            calledOperator = NULL_OPERATOR;
        }

        private void DisableOperationKeys()
        {
            btnAdd.Enabled = false;
            btnSubtract.Enabled = false;
            btnMultiply.Enabled = false;
            btnDivide.Enabled = false;
            btnPercent.Enabled = false;
            btnInverse.Enabled = false;
            btnSquare.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPlusMinus.Enabled = false;
            btnDot.Enabled = false;
        }

        private void DivideByZero()
        {
            ResetCalculationValues();
            DisableOperationKeys();
            textMainDisplay.Text = DivideByZeroText;
            textFormulaDisplay.Clear();
        }

        private void EnableOperationKeys(object sender, EventArgs e)
        {
            if (btnAdd.Enabled)
            {
                return;
            }
            btnAdd.Enabled = true;
            btnSubtract.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;
            btnPercent.Enabled = true;
            btnInverse.Enabled = true;
            btnSquare.Enabled = true;
            btnSquareRoot.Enabled = true;
            btnPlusMinus.Enabled = true;
            btnDot.Enabled = true;
            textMainDisplay.Text = "0";
        }
    }
}
