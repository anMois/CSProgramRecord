namespace Day_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Divsolution(3,2));
        }

        /// <summary>
        /// 정수 num1과 num2가 매개변수로 주어집니다. 
        /// 두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int CompareSolution(int num1, int num2)
        {
            return num1 == num2 ? 1 : -1; 
        }

        /// <summary>
        /// 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에
        /// 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.
        /// </summary>
        public int Divsolution(int num1, int num2)
        {
            float div = (float)num1 / num2;

            return (int)(div * 1000);
        }

        /// <summary>
        /// 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1,
        /// 두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다.
        /// 두 분수를 더한 값을 기약 분수로 나타냈을 때 분자와 분모를 순서대로 
        /// 담은 배열을 return 하도록 solution 함수를 완성해보세요.
        /// </summary>
        public int[] AddFractionsolution(int numer1, int denom1, int numer2, int denom2)
        {
            int[] answer = new int[] { };

            int denom;
            int number;
            int div = denom1 < denom2 ? denom2 / denom1 : denom1 / denom2;

            if(denom1 != denom2)
            {
                if(div * denom1 == denom2 || div * denom2 == denom1)
                {
                    
                }

                denom = denom1 * denom2;
                number = (numer1 * denom2) + (numer2 * denom1);
            }
            else
            {
                denom = denom1;
                number = numer1 + numer2;
            }

            answer[0] = number;
            answer[1] = denom;

            return answer;
        }

        /// <summary>
        /// 정수 배열 numbers가 매개변수로 주어집니다. 
        /// numbers의 각 원소에 두배한 원소를 가진 배열을 return하도록 
        /// solution 함수를 완성해주세요.
        /// </summary>
        public static int[] DoubleArrysolution(int[] numbers)
        {
            int[] answer = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                answer[i] = numbers[i] * 2;
            }

            return answer;
        }
    }
}
