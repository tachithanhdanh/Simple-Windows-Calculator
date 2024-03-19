using System.Runtime.InteropServices;
using System.Web;

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
        private readonly double[] operand = [Double.MaxValue, Double.MaxValue];
        private double result = Double.MaxValue;
        private string specialOperation = "";

        private enum ErrorCode
        {
            None,
            DivideByZero,
            NegativeSquareRoot
        }
        private readonly string[] errorText =
        {
            "No Error",
            "Cannot divide by zero",
            "Invalid input"
        };

        private const string precisionFormat = "##############0.##############";




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Hide blinking cursor from textboxes

        private void MainDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(textMainDisplay.Handle);
        }

        private bool clearFirstTime = false;
        private void ButtonNumbers_Click(object sender, EventArgs e)
        {
            EnableOperationKeys(sender, e);
            Button button = (Button)sender;
            //textMainDisplay.Text += button.Text;
            //MessageBox.Show($"Button {button.Text} clicked", caption: "Number clicked");
            if (textMainDisplay.Text == result.ToString(precisionFormat) && clearFirstTime == false)
            {
                btnClearEntry.PerformClick();
                clearFirstTime = true;
            }

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
            clearFirstTime = false;
            if (double.Parse(textMainDisplay.Text) != 0.0)
            {
                textMainDisplay.Text = (Convert.ToDouble(textMainDisplay.Text) * -1.0).ToString(precisionFormat);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            EnableOperationKeys(sender, e);
            textMainDisplay.Text = "0";
            textFormulaDisplay.Clear();
        }

        private void ButtonClearEntry_Click(object sender, EventArgs e)
        {
            EnableOperationKeys(sender, e);
            if (textFormulaDisplay.Text.Contains("="))
            {
                textFormulaDisplay.Clear();
            }
            textMainDisplay.Text = "0";
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            EnableOperationKeys(sender, e);
            if (textMainDisplay.Text.Length == 1)
            {
                textMainDisplay.Text = "0";
            }
            else
            {
                textMainDisplay.Text = textMainDisplay.Text.Remove(textMainDisplay.Text.Length - 1);
                StandardizeMainDisplay(sender, e);
            }
        }

        private ErrorCode ApplyBasicOperation()
        {
            // Neu ma cai chuoi tren FormulaDisplay khong rong
            if (textFormulaDisplay.Text.Contains("+"))
            {
                operand[0] += operand[1];
            }
            else if (textFormulaDisplay.Text.Contains("-")) // dấu trừ trong đây là ký tự đặc biệt, nên chú ý
            {
                operand[0] -= operand[1];
            }
            else if (textFormulaDisplay.Text.Contains("×"))
            {
                operand[0] *= operand[1];
            }
            else if (textFormulaDisplay.Text.Contains("÷"))
            {
                if (operand[1] == 0)
                {
                    //MessageBox.Show("Check var");
                    return ErrorCode.DivideByZero;
                }
                operand[0] /= operand[1];
            }
            else
            {
                operand[0] = operand[1];
            }
            return ErrorCode.None;
        }

        private void ButtonBasicOperation_Click(object sender, EventArgs e)
        {
            clearFirstTime = false;
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
                operand[1] = mainDisplayValue;
                if (ApplyBasicOperation() == ErrorCode.DivideByZero)
                {
                    HandleInvalidInput(ErrorCode.DivideByZero);
                    return;
                }
                textMainDisplay.Text = operand[0].ToString(precisionFormat);
            }
            else
            {
                // truong hop textFormulaDisplay rong
                operand[0] = mainDisplayValue;
            }
            textFormulaDisplay.Text = operand[0].ToString(precisionFormat) + " " + button.Text;
            textMainDisplay.Text = "0";
        }

        private void ButtonSpecialOperation_Click(object sender, EventArgs e)
        {
            clearFirstTime = false;
            Button button = (Button)sender;
            //MessageBox.Show(button.Text + " clicked");
            String operationName = button.Name;
            double mainDisplayValue = Double.Parse(textMainDisplay.Text);
            switch (operationName)
            {
                case "btnSquare":
                    textMainDisplay.Text = (mainDisplayValue * mainDisplayValue).ToString(precisionFormat);
                    specialOperation = "sqr";
                    break;
                case "btnSquareRoot":
                    if (mainDisplayValue < 0)
                    {
                        HandleInvalidInput(ErrorCode.NegativeSquareRoot);
                        return;
                    }
                    textMainDisplay.Text = Math.Sqrt(mainDisplayValue).ToString(precisionFormat);
                    specialOperation = "√";
                    break;
                case "btnInverse":
                    if (mainDisplayValue == 0)
                    {
                        HandleInvalidInput(ErrorCode.DivideByZero);
                        return;
                    }
                    textMainDisplay.Text = (1.0 / mainDisplayValue).ToString(precisionFormat);
                    specialOperation = "1/";
                    break;
                case "btnPercent":
                    if (operand[0] != Double.MaxValue)
                    {
                        textMainDisplay.Text = (operand[0] * mainDisplayValue / 100.0).ToString(precisionFormat);
                    }
                    else
                    {
                        textMainDisplay.Text = "0";
                    }
                    specialOperation = "%";
                    break;
                default:
                    break;
            }
            result = mainDisplayValue;
            btnEqual.PerformClick();
        }



        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            EnableOperationKeys(sender, e);
            if (textMainDisplay.Text != result.ToString(precisionFormat) || textMainDisplay.Text == "0")
            {
                operand[1] = Double.Parse(textMainDisplay.Text);
                // Nếu mà textFormulaDisplay khác rỗng và nó không có dấu bằng thì coi như
                // biểu thức đó chưa thực hiện xong
                if (textFormulaDisplay.Text != String.Empty && !textFormulaDisplay.Text.Contains('='))
                {
                    ErrorCode error = ApplyBasicOperation();
                    if (error != ErrorCode.None)
                    {
                        HandleInvalidInput(error);
                        return;
                    }
                    //MessageBox.Show($"Operand 0 now is {operand[0]}");
                    if (specialOperation != String.Empty)
                    {
                        if (specialOperation.Equals("%"))
                        {
                            double displayValue = operand[0] != Double.MaxValue ? operand[0] : 0.0;
                            textFormulaDisplay.Text += $" ({displayValue}) × {result}% = ";
                        }
                        else
                        {
                            textFormulaDisplay.Text += " " + specialOperation + "(" + result.ToString(precisionFormat) + ") =";
                        }
                    }
                    else
                    {
                        textFormulaDisplay.Text += " " + operand[1].ToString(precisionFormat) + " =";
                    }
                    result = operand[0];
                    textMainDisplay.Text = result.ToString(precisionFormat);
                    specialOperation = "";
                }
                else if (specialOperation != String.Empty)
                {
                    // Truong hop nay xay ra khi tren bieu thuc da co dau bang san
                    // va nguoi dung nhấn phím chức năng đặc biệt
                    textFormulaDisplay.Clear();
                    if (specialOperation.Equals("%"))
                    {
                        double displayValue = operand[0] != Double.MaxValue ? operand[0] : 0.0;
                        textFormulaDisplay.Text = $"({displayValue}) × {result}% = ";
                    }
                    else
                    {
                        textFormulaDisplay.Text = $"{specialOperation}({result}) = ";
                    }
                    specialOperation = "";
                    result = operand[1];
                }
            }
        }

        private void ResetCalculationValues()
        {
            operand[0] = operand[1] = result = Double.MaxValue;
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

        private void HandleInvalidInput(ErrorCode errorCode)
        {
            ResetCalculationValues();
            DisableOperationKeys();
            textMainDisplay.Text = errorText[(int)errorCode];
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

        private void StandardizeMainDisplay(object sender, EventArgs e)
        {
            if (Double.TryParse(textMainDisplay.Text, out double standardValue))
            {
                textMainDisplay.Text = standardValue.ToString(precisionFormat);
            }
            else
            {
                textMainDisplay.Text = "0";
            }
        }

        // Remember to enable KeyPreview
        // https://stackoverflow.com/a/3172762/23524865
        private void SimpleCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.D0:
                case (char)Keys.NumPad0:
                    btnNum0.PerformClick();
                    break;
                case (char)Keys.D1:
                case (char)Keys.NumPad1:
                    btnNum1.PerformClick();
                    break;
                case (char)Keys.D2:
                case (char)Keys.NumPad2:
                    btnNum2.PerformClick();
                    break;
                case (char)Keys.D3:
                case (char)Keys.NumPad3:
                    btnNum3.PerformClick();
                    break;
                case (char)Keys.D4:
                case (char)Keys.NumPad4:
                    btnNum4.PerformClick();
                    break;
                case (char)Keys.D5:
                case (char)Keys.NumPad5:
                    btnNum5.PerformClick();
                    break;
                case (char)Keys.D6:
                case (char)Keys.NumPad6:
                    btnNum6.PerformClick();
                    break;
                case (char)Keys.D7:
                case (char)Keys.NumPad7:
                    btnNum7.PerformClick();
                    break;
                case (char)Keys.D8:
                case (char)Keys.NumPad8:
                    btnNum8.PerformClick();
                    break;
                case (char)Keys.D9:
                case (char)Keys.NumPad9:
                    btnNum9.PerformClick();
                    break;
                case (char)Keys.Back:
                    btnBack.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void SimpleCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                btnAdd.PerformClick();
            }
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                btnSubtract.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply || (e.Shift && e.KeyCode == Keys.D8))
            {
                btnMultiply.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
            {
                btnDivide.PerformClick();
            }
            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                btnDot.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnClearEntry.PerformClick();
            }
        }

        // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.processcmdkey
        // Sử dụng phím này để bắt phím Enter trước khi xảy ra sự kiện nhấn phím vì phím Enter có thể
        // bị nuốt bởi Control trên màn hình trước khi Forms bắt được phím
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && this.ActiveControl != null)
            {
                if (this.ActiveControl.Handle != this.btnEqual.Handle)
                {
                    this.btnEqual.Select();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
