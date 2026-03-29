using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 個人房貸試算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*txtTotalPrice.Text = "0";
            txtDownPayment.Text = "0";
            txtInterestRate.Text = "0";
            txtLoanTerm.Text = "0";*/
            txtGracePeriod.Text = "0";
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            // 取得並轉換輸入資料(防呆)
            if (!double.TryParse(txtTotalPrice.Text, out double totalPrice))
            {
                MessageBox.Show("請輸入正確的房屋總價數字");
                return;
            }

            if (!double.TryParse(txtDownPayment.Text, out double downPaymentRate))
            {
                MessageBox.Show("請輸入正確的自備款比例");
                return;
            }

            if (!double.TryParse(txtInterestRate.Text, out double annualInterestRate))
            {
                MessageBox.Show("請輸入正確的貸款利率");
                return;
            }

            if (!int.TryParse(txtLoanTerm.Text, out int loanYears))
            {
                MessageBox.Show("請輸入正確的貸款年限");
                return;
            }

            // 寬限期選填驗證
            int graceYears = 0;
            int.TryParse(txtGracePeriod.Text, out graceYears);
            if (graceYears >= loanYears)
            {
                MessageBox.Show("寬限期不可大於或等於貸款年限！");
                return;
            }

            // 核心邏輯計算 
            double totalPriceInFull = totalPrice * 10000; // 萬元轉為元
            double loanAmount = totalPriceInFull * (1 - downPaymentRate / 100);
            double monthlyInterestRate = (annualInterestRate / 100) / 12;
            int totalMonths = loanYears * 12;
            int graceMonths = graceYears * 12;

            double monthlyPayment;
            double totalPayment;

            if (graceMonths > 0)
            {
                // 寬限期內每月僅付利息
                monthlyPayment = loanAmount * monthlyInterestRate;

                // 寬限期後本息平均攤還
                int remainingMonths = totalMonths - graceMonths;
                double monthlyPostGrace = (loanAmount * Math.Pow(1 + monthlyInterestRate, remainingMonths) * monthlyInterestRate)
                                         / (Math.Pow(1 + monthlyInterestRate, remainingMonths) - 1);

                // 總還款 = (寬限期利息 * 月數) + (攤還期月付 * 剩餘月數)
                totalPayment = (monthlyPayment * graceMonths) + (monthlyPostGrace * remainingMonths);
            }
            else
            {
                // 無寬限期，直接計算本息平均攤還
                monthlyPayment = (loanAmount * Math.Pow(1 + monthlyInterestRate, totalMonths) * monthlyInterestRate)
                                 / (Math.Pow(1 + monthlyInterestRate, totalMonths) - 1);
                totalPayment = monthlyPayment * totalMonths;
            }

            double firstInterest = loanAmount * monthlyInterestRate; // 首期利息
            double firstPrincipal = (graceMonths > 0) ? 0 : monthlyPayment - firstInterest; // 首期本金
            double totalInterest = totalPayment - loanAmount; // 總利息支出

            // 格式化輸出結果 (千分位與兩位小數)
            lblResultLoanAmount.Text = loanAmount.ToString("N2");
            lblResultMonthlyPayment.Text = monthlyPayment.ToString("N2");
            lblResultFirstInterest.Text = firstInterest.ToString("N2");
            lblResultFirstPrincipal.Text = firstPrincipal.ToString("N2");
            lblResultTotalInterest.Text = totalInterest.ToString("N2");
            lblResultTotalPayment.Text = totalPayment.ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 清除重新輸入功能 
            txtTotalPrice.Clear();
            txtDownPayment.Clear();
            txtInterestRate.Clear();
            txtLoanTerm.Clear();
            txtGracePeriod.Text = "0";

            lblResultLoanAmount.Text = "0.00";
            lblResultMonthlyPayment.Text = "0.00";
            lblResultFirstInterest.Text = "0.00";
            lblResultFirstPrincipal.Text = "0.00";
            lblResultTotalInterest.Text = "0.00";
            lblResultTotalPayment.Text = "0.00";
        }
    }
}