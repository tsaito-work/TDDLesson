namespace TDDLesson.UI
{
    // DBクラス
    public class DB: IDB
    {
        // DBの返却値を返すメソッド
        public int GetDBValue()
        {
            // 実際はここでデータベースに接続
            return 200;
        }
    }
}
