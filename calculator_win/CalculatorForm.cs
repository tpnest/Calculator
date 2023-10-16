using System;
using System.Windows.Forms;

namespace calculator_win
{
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// 计算结果
        /// </summary>
        private double _resultValue = 0;

        /// <summary>
        /// 操作按钮 + - * /
        /// </summary>
        private string _operatorPerformed = " ";

        /// <summary>
        /// 是否在textBlock中显示下一个数字输入
        /// </summary>
        private bool _performedOp = false;
        
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
            if (textBox_Result.Text == "0" || _performedOp)
                textBox_Result.Clear();

            _performedOp = false;
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
            
            if (_resultValue != 0)
            {
                // 如果没有点击“=”继续输入先计算上一个表达式的结果
                if(!_performedOp)
                {
                    btn_equal.PerformClick();
                }
                _operatorPerformed = button.Text;
                label_Show_Op.Text = _resultValue + " " + _operatorPerformed;
                _performedOp = true;
            }
            else
            {
                _operatorPerformed = button.Text;
                _resultValue = double.Parse(textBox_Result.Text);
                label_Show_Op.Text = _resultValue + " " + _operatorPerformed;
                _performedOp = true;
            }
        }

        /// <summary>
        /// “清除当前输入”按钮，不清除上一个输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_current_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        /// <summary>
        /// 清除所有按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            _resultValue = 0;
            label_Show_Op.Text = " ";
        }

        /// <summary>
        /// “等于”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch (_operatorPerformed)
            {
                case "+":
                    textBox_Result.Text = (_resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (_resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "×":
                    textBox_Result.Text = (_resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "÷":
                    textBox_Result.Text = (_resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    throw new ArgumentException($"未实现的操作符:{_operatorPerformed}");
            }

            _resultValue = double.Parse(textBox_Result.Text);
            label_Show_Op.Text = " ";
        }
    }
}