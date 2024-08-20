using System.Text;

namespace Day_7
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// 문자열 my_string과 문자 letter이 매개변수로 주어집니다. 
        /// my_string에서 letter를 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
        /// </summary>
        public string solution(string my_string, string letter)
        {
            string answer = "";

            for (int i = 0; i < my_string.Length; i++)
            {
                if (letter == my_string[i].ToString())
                    continue;

                answer += my_string[i].ToString();
            }

            return answer;
        }

        /// <summary>
        /// 두 배열이 얼마나 유사한지 확인해보려고 합니다. 
        /// 문자열 배열 s1과 s2가 주어질 때 같은 원소의 개수를 return하도록 
        /// solution 함수를 완성해주세요.
        /// </summary>
        public int solution(string[] s1, string[] s2)
        {
            int answer = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i].Equals(s2[j]))
                        answer++;
                }
            }

            return answer;
        }

        /// <summary>
        /// 문자열 my_string이 매개변수로 주어집니다.
        /// my_string을 거꾸로 뒤집은 문자열을 return하도록 solution 함수를 완성해주세요.
        /// </summary>
        public string solution(string my_string)
        {
            string answer = "";

            for(int i = my_string.Length - 1; i >= 0; i--)
            {
                answer += my_string[i];
            }

            return answer;
        }

        /// <summary>
        /// 사분면은 한 평면을 x축과 y축을 기준으로 나눈 네 부분입니다. 
        /// 사분면은 아래와 같이 1부터 4까지 번호를매깁니다.
        /// x 좌표와 y 좌표가 모두 양수이면 제1사분면에 속합니다.
        /// x 좌표가 음수, y 좌표가 양수이면 제2사분면에 속합니다.
        /// x 좌표와 y 좌표가 모두 음수이면 제3사분면에 속합니다.
        /// x 좌표가 양수, y 좌표가 음수이면 제4사분면에 속합니다.
        /// x 좌표 (x, y) 를 차례대로 담은 정수 배열 dot이 매개변수로 주어집니다.
        /// 좌표 dot이 사분면 중 어디에 속하는지 1, 2, 3, 4 중 하나를 return 하도록 
        /// solution 함수를 완성해주세요.
        /// </summary>
        public int solution(int[] dot)
        {
            int answer = 0;

            if (dot[0] > 0 && dot[1] > 0)
                answer = 1;
            else if (dot[0] < 0 && dot[1] > 0)
                answer = 2;
            else if (dot[0] < 0 && dot[1] < 0)
                answer = 3;
            else if (dot[0] > 0 && dot[1] < 0)
                answer = 4;

            return answer;
        }
    }
}