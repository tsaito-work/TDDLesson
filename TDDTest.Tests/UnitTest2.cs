using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDLesson.UI;

namespace TDDTest.Tests
{
    [TestClass]
    public class UnitTest2
    {
        // ChainingAssertion.MSTestを使う場合NuGetからインストール
        #region "ChainingAssertion.MSTestを使用したパターン"

        [TestMethod]
        public void TestMethod1()
        {

            // Add呼び出しの結果が3になるテストケース
            // Assert.AreEqual(3, Class1.Add(1, 2));
            // 値の判定であれば↑を↓に書き直せる
            Class1.Add(1,2).Is(3);

            // 例外のメッセージ判定
            var ex = AssertEx.Throws<InputException>(() => Class1.Add(-1, 2));
            ex.Message.Is("マイナス値は入力できません");

        }

        #endregion

        #region "cheiningAssationを使用しないパターン"

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    // Add呼び出しの結果が3になるテストケース
        //    Assert.AreEqual(3, Class1.Add(1, 2));
        //}

        //// このテストメソッドはInputExceptionが出ていた場合成功となる
        //[TestMethod]
        //[ExpectedException(typeof(InputException))]
        //public void 例外のテスト()
        //{
        //    // 正常に例外が発生するケース
        //    Assert.AreEqual(3, Class1.Add(-1, 2));
        //    // 例外が発生しないケース
        //    //Assert.AreEqual(3, Class1.Add(1, 2));
        //}

        #endregion
    }
}
