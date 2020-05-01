using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDLesson.UI
{
    // 計算Form
    public partial class Form1 : Form
    {

        // viewModelをインスタンス化しておき入力した値を保持しておく
        private Form1ViewModel _viewModel = new Form1ViewModel(new DB());

        public Form1()
        {
            InitializeComponent();

            // データデータバインディングしておくことで入力値が変化した時に自動で値の受け渡しを行う
            ATextBox.DataBindings.Add("Text", _viewModel, "ATextBoxText");
            BTextBox.DataBindings.Add("Text", _viewModel, "BTextBoxText");
            ResultLabel.DataBindings.Add("Text", _viewModel, "ResultLabelText");

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {

            _viewModel.CalculationAction();

        }
    }
}
