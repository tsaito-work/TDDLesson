using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLesson.UI
{
    // 計算FormのViewModel
    // 複数のViewModelを扱う場合、バインディング用のBaseクラスを用意して継承する
    public class Form1ViewModel : ViewModelBase
    {

        #region "フィールド"
        private IDB _db;

        private string _aTextBoxText = string.Empty;
        private string _bTextBoxText = string.Empty;
        private string _resultLabelText = string.Empty;

        public string ATextBoxText
        {
            get { return _aTextBoxText; }
            set
            {

                // ViewModelBaseでのデータバインディング
                SetProperty(ref _aTextBoxText, value);

                // このクラスにOnPropertyChangedを定義した場合
                //// 入力値が変更されているか確認
                //// されていればOnPropertyChangedを呼び出してデータバインディングを行う
                //if (_aTextBoxText == value)
                //{
                //    return;
                //}

                //_aTextBoxText = value;
                //OnPropertyChanged("ATextBoxText");

            }
        }

        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set
            {
                // ViewModelBaseでのデータバインディング
                SetProperty(ref _bTextBoxText, value);

                //// このクラスにOnPropertyChangedを定義した場合
                //// 入力値が変更されているか確認
                //// されていればOnPropertyChangedを呼び出してデータバインディングを行う
                //if (_bTextBoxText == value)
                //{
                //    return;
                //}

                //_bTextBoxText = value;
                //OnPropertyChanged("BTextBoxText");

            }
        }

        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set
            {

                // ViewModelBaseでのデータバインディング
                SetProperty(ref _resultLabelText, value);

                //// このクラスにOnPropertyChangedを定義した場合
                //// 入力値が変更されているか確認
                //// されていればOnPropertyChangedを呼び出してデータバインディングを行う
                //if (_resultLabelText == value)
                //{
                //    return;
                //}

                //_resultLabelText = value;
                //OnPropertyChanged("ResultLabelText");

            }
        }
        #endregion

        // ViewModelBaseでINotifyPropertyChangedを継承せず直接PropertyChangedを発火させる場合
        // 下記のイベントをこちらで定義することもできる
        // その際アクセサのsetでOnPropertyChangedを呼び出す

        //// INotifyPropertyChangedを使う場合ハンドラーも用意しておく
        //public event PropertyChangedEventHandler PropertyChanged;
        //// 入力値が変更された場合の処理
        //// OnPropertyChangedはフィールドのsetで行うのがセオリーとされている
        //public void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        // テスト用と本番用のDBクラスの値を受けるためにコンストラクタではIDBの値を受け取る
        public Form1ViewModel(IDB db)
        {
            _db = db;
        }

        // 計算処理
        public void CalculationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            // ここではテストコードから受けるDBMockの値と本番のDBクラスのどちらでも受け取る
            int dbValue = _db.GetDBValue();
            ResultLabelText = (Calculation.Sum(a, b) + dbValue).ToString();

        }

    }
}
