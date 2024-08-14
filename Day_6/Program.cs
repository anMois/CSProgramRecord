using System.Text;

namespace Day_6
{
    public class Program
    {
        static void Main(string[] args)
        {
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

        /// <summary>
        /// 문자열 배열 strlist가 매개변수로 주어집니다. 
        /// strlist 각 원소의 길이를 담은 배열을 retrun하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int[] solution(string[] strlist)
        {
            int[] answer = new int[strlist.Length];

            for (int i = 0; i < strlist.Length; i++)
            {
                answer[i] = strlist[i].Length;
            }

            return answer;
        }

        /// <summary>
        /// 문자열 str1, str2가 매개변수로 주어집니다. 
        /// str1 안에 str2가 있다면 1을 없다면 2를 return하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int solution(string str1, string str2)
        {
            int answer = 0;

            if(str1.Contains(str2))
                answer = 1;
            else
                answer = 2;

            return answer;
        }
    }
}
