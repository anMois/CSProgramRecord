namespace Day_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1,2,7,10,11};
            int[] arr2 = new int[] { 9,-1,0};

            Console.WriteLine(solution(arr1));
            Console.WriteLine(solution(arr2));
        }

        /// <summary>
        /// 정수 num1, num2가 매개변수로 주어질 때, 
        /// num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int solution(int num1, int num2)
        {
            return num1 % num2;
        }

        /// <summary>
        /// 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다.
        /// 예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다. 
        /// 정수 배열 array가 매개변수로 주어질 때, 중앙값을 return 하도록 solution 함수를 완성해보세요.
        /// </summary>
        public static int solution(int[] array)
        {
            Array.Sort(array);

            int mid = array.Length / 2;

            return array[mid];
        }
    }
}
