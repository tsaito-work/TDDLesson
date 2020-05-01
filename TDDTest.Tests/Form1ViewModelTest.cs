using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TDDLesson.UI;

namespace TDDTest.Tests
{
    [TestClass]
    public class Form1ViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            // NuGetパッケージマネージャーからMoqをインストールして初期化する
            var mock = new Mock<IDB>();
            // DBから返却される想定の値を設定する
            // この場合GetDBValueが呼ばれたら100をReturnするという想定をSetupする
            // これによりviewModel側のDBの値を受けるGetDBValueの呼び出しで100が返却される
            mock.Setup(x => x.GetDBValue()).Returns(100);
            // mock.Objectに実際のインスタンスが格納される
            var viewModel = new Form1ViewModel(mock.Object);

            // DBMockクラスを使用した際のインスタンス化
            //var viewModel = new Form1ViewModel(new DBMock());
            Assert.AreEqual("", viewModel.ATextBoxText);
            Assert.AreEqual("", viewModel.BTextBoxText);
            Assert.AreEqual("", viewModel.ResultLabelText);

            viewModel.ATextBoxText = "2";
            viewModel.BTextBoxText = "5";
            viewModel.CalculationAction();
            Assert.AreEqual("107", viewModel.ResultLabelText);
        }
    }

    // テストでしか使用しないのでinternalとする
    // テスト用のDBクラスとしてDBMockを作成する
    // このクラスではTDDLesson.UIのDBクラスと同じ動きをさせ返却値はテスト用の返却値とする
    // この実装はMoqで行う事が出来る
    //internal class DBMock : IDB
    //{
    //    public int GetDBValue()
    //    {
    //        return 100;
    //    }
    //}

}
