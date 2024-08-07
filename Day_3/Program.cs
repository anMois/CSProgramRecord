namespace Day_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 3, 4 };

            Console.WriteLine(solution(arr));
        }

        /// <summary>
        /// 정수 num1, num2가 매개변수로 주어질 때, 
        /// num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int RemainderSolution(int num1, int num2)
        {
            return num1 % num2;
        }

        /// <summary>
        /// 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다.
        /// 예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다. 
        /// 정수 배열 array가 매개변수로 주어질 때, 중앙값을 return 하도록 solution 함수를 완성해보세요.
        /// </summary>
        public int ArrayMidSolution(int[] array)
        {
            Array.Sort(array);

            int mid = array.Length / 2;

            return array[mid];
        }

        /// <summary>
        /// 정수 n이 매개변수로 주어질 때, 
        /// n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int[] EvenNumbersolution(int n)
        {
            int size = n % 2 == 0 ? n / 2 : n / 2 + 1;
            int[] answer = new int[size];
            int count = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    answer[count++] = i;
                }                  
            }

            return answer;
        }

        /// <summary>
        /// 최빈값은 주어진 값 중에서 가장 자주 나오는 값을 의미합니다.
        /// 정수 배열 array가 매개변수로 주어질 때,
        /// 최빈값을 return 하도록 solution 함수를 완성해보세요.
        /// 최빈값이 여러 개면 -1을 return 합니다.
        /// </summary>
        public static int solution(int[] array)
        {
            int answer = 0;
            Dictionary<int, int> counts = new();
            int num = 1;

            //매개변수로 받은 배열을 돌린다.
            for(int i = 0; i < array.Length; i++)
            {
                if (!counts.ContainsKey(array[i]))
                    counts.Add(array[i], num);                        
            }



            ////배열의 값을 카운트한다.
            //카운트 한 값을 비교한다.
            return answer;
        }
    }
}
