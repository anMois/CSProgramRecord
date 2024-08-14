using System.Text;

namespace Day_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = solution("hello", 3);

            Console.WriteLine(str);
        }

        /// <summary>
        /// 문자열 my_string과 정수 n이 매개변수로 주어질 때,
        /// my_string에 들어있는 각 문자를 n만큼 반복한 문자열을 return 하도록 
        /// solution 함수를 완성해보세요.
        /// </summary>
        public string solution(string my_string, int n)
        {
            char[] words = new char[my_string.Length];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < my_string.Length; i++)
            {
                words[i] = my_string[i];
                for (int j = 0; j < n; j++)
                {
                    sb.Append(words[i]);
                }
            }

            return sb.ToString();
        }
    }
}
