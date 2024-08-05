namespace Day_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divsolution(3,2));
        }

        /// <summary>
        /// 정수 num1과 num2가 매개변수로 주어집니다. 
        /// 두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int CompareSolution(int num1, int num2)
        {
            return num1 == num2 ? 1 : -1; //반환값이 1 또는 -1 둘로 나타나기에 조건연산자인 '? :'사용한다.
        }

        /// <summary>
        /// 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에
        /// 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.
        /// </summary>
        public static int Divsolution(int num1, int num2)
        {
            float div = (float)num1 / num2;

            return (int)(div * 1000);
        }
    }
}
