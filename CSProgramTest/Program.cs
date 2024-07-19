namespace CSProgramTest
{
    internal class Program
    {
        #region 사칙연산
        /// <summary>
        /// 두 수의 합을 구합니다.
        /// </summary>
        public int AddSolution(int num1, int num2)
        {
            return num1 + num2; //두 수의 합을 구하기 위해 연산자 '+'기호를 사용한다.
        }

        /// <summary>
        /// 두 수의 차를 구합니다.
        /// </summary>
        public int SubSolution(int num1, int num2)
        {
            return num1 - num2; //두 수의 차을 구하기 위해 연산자 '-'기호를 사용한다.
        }

        /// <summary>
        /// 두 수의 곱을 구합니다.
        /// </summary>
        public int MulSolution(int num1, int num2)
        {
            return num1 * num2; //두 수의 곱을 구하기 위해 연산자 '*'기호를 사용한다.
        }

        /// <summary>
        /// 두 수의 몫을 구합니다. 몫은 정수로 표현합니다.
        /// </summary>
        public int DivSolution(int num1, int num2)
        {
            return num1 / num2; //두 수의 정수 몫을 구하기 위해 연산자 '/'기호를 사용한다.
        }
        #endregion

        /// <summary>
        /// 두 수를 비교합니다. 같으면 1을 반환 다르면 -1을 반환
        /// </summary>
        public int CompareSolution(int num1, int num2)
        {
            return num1 == num2 ? 1 : -1; //반환값이 1 또는 -1 둘로 나타나기에 조건연산자인 '? :'사용한다.
        }

        static void Main(string[] args)
        {
            Console.WriteLine("!@#$%^&*(\\'\"<>?:;");
        }
    }
}
