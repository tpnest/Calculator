using System;
using System.Windows.Forms;

namespace calculator_win
{
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// 计算结果
        /// </summary>
        private double _result = 0;

        /// <summary>
        /// 操作符 + - * /
        /// </summary>
        private string _operator = string.Empty;

        /// <summary>
        /// 是否在textBlock中显示下一个数字输入
        /// </summary>
        private bool _isShowNextNum = false;

        /// <summary>
        /// 最后一个操作符是否是'='
        /// </summary>
        private bool _isEqualBtnClicked = false;
        public CalculatorForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 数字按钮和小数点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NumAndDot_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || _isShowNextNum)
                textBox_Result.Clear();

            _isShowNextNum = false;
            var button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }
            else
            {
                textBox_Result.Text += button.Text;
            }
        }


        /// <summary>
        /// +, -, *, / 操作按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_operator_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            
            if (_result != 0)
            {
                // 如果 没有点击“=”并且最后一个操作符不是等于 继续输入先计算上一个表达式的结果
                if(!_isShowNextNum && !_isEqualBtnClicked)
                {
                    CalculationResults();
                }
                _operator = button.Text;
                label_Show_Op.Text = _result + "" + _operator;
                _isShowNextNum = true;
                _isEqualBtnClicked = false;
            }
            else
            {
                _operator = button.Text;
                _result = double.Parse(textBox_Result.Text);
                label_Show_Op.Text = _result + "" + _operator;
                _isShowNextNum = true;
                _isEqualBtnClicked = false;
            }
        }

        /// <summary>
        /// “清除当前输入”按钮，不清除上一个输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_current_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length == 1)
            {
                textBox_Result.Text = "0";
                return;
            }

            textBox_Result.Text = textBox_Result.Text.Substring(0,textBox_Result.Text.Length -1);
        }

        /// <summary>
        /// 清除所有按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            _result = 0;
            label_Show_Op.Text = string.Empty;
        }

        /// <summary>
        /// “等于”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_equal_Click(object sender, EventArgs e)
        {
            CalculationResults();
            _isEqualBtnClicked = true;
        }


        private void CalculationResults()
        {
            switch (_operator)
            {
                case "+":
                    textBox_Result.Text = (_result + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (_result - double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "×":
                    textBox_Result.Text = (_result * double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "÷":
                    textBox_Result.Text = (_result / double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    throw new ArgumentException($"未实现的操作符:{_operator}");
            }

            _result = double.Parse(textBox_Result.Text);
            label_Show_Op.Text = string.Empty;
        }
    }
}