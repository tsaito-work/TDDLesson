namespace TDDLesson.UI
{
    public class Class1
    {
        public static int Add(int a, int b)
        {
            // 例外ケース
            if(a < 0)
            {
                throw new InputException("マイナス値は入力できません");
            }

            return a + b;
        }
    }
}
