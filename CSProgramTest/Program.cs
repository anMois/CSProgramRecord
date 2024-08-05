namespace Day_1
{
    public class Program
    {
        #region Day_1
        /// <summary>
        /// 정수 num1과 num2가 주어질 때, num1과 num2의 합을 return하도록 soltuion 함수를 완성해주세요.
        /// </summary>
        public int AddSolution(int num1, int num2)
        {
            return num1 + num2; //두 수의 합을 구하기 위해 연산자 '+'기호를 사용한다.
        }

        /// <summary>
        /// 정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 soltuion 함수를 완성해주세요.
        /// </summary>
        public int SubSolution(int num1, int num2)
        {
            return num1 - num2; //두 수의 차을 구하기 위해 연산자 '-'기호를 사용한다.
        }

        /// <summary>
        /// 정수 num1, num2가 매개변수 주어집니다. num1과 num2를 곱한 값을 return 하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int MulSolution(int num1, int num2)
        {
            return num1 * num2; //두 수의 곱을 구하기 위해 연산자 '*'기호를 사용한다.
        }

        /// <summary>
        /// 정수 num1, num2가 매개변수로 주어질 때, num1을 num2로 나눈 몫을 return 하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int DivSolution(int num1, int num2)
        {
            return num1 / num2; //두 수의 정수 몫을 구하기 위해 연산자 '/'기호를 사용한다.
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("!@#$%^&*(\\'\"<>?:;");
        }
    }
}
