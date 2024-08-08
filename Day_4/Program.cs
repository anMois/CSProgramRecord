namespace Day_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[] { 1,2,3,4,5,6,7,8,9,10};

            //Console.WriteLine(ArryAversolution(nums));
        }

        /// <summary>
        /// 머쓱이는 선생님이 몇 년도에 태어났는지 궁금해졌습니다.
        /// 2022년 기준 선생님의 나이 age가 주어질 때,
        /// 선생님의 출생 연도를 return 하는 solution 함수를 완성해주세요
        /// </summary>
        public int BirthYearSolution(int age)
        {
            const int YEAR = 2022;
            int answer = YEAR - age + 1;

            return answer;
        }

        /// <summary>
        /// 정수 배열 numbers가 매개변수로 주어집니다. 
        /// numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
        /// </summary>
        public double ArryAversolution(int[] numbers)
        {
            double answer = 0;
            int min = numbers.Min();
            int max = numbers.Max();

            answer = (min + max) / 2.0;

            //for (int i = 0; i< numbers.Length; i++)
            //{
            //    answer += numbers[i];
            //}
            //
            //answer /= numbers.Length;

            return answer;
        }

        /// <summary>
        /// 각에서 0도 초과 90도 미만은 예각, 90도는 직각, 90도 초과 180도 미만은 둔각 180도는 평각으로 분류합니다. 
        /// 각 angle이 매개변수로 주어질 때 예각일 때 1, 예각 : 0 < angle< 90
        /// 직각일 때 2, 직각 : angle = 90
        /// 둔각일 때 3, 둔각 : 90 < angle< 180
        /// 평각일 때 4평각 : angle = 180
        /// 를 return하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int solution(int angle)
        {
            int answer = 0;

            if(angle > 0 && angle < 90)
            {
                answer = 1;
            }
            else if(angle > 90 && angle < 180)
            {
                answer = 3;
            }
            else if(angle == 90)
            {
                answer = 2;
            }
            else if(angle == 180)
            {
                answer = 4;
            }
            else
            {
                Console.WriteLine("잘못된 입력을 하였습니다.");
            }

            return answer;
        }
    }
}
