using Microsoft.VisualBasic;

namespace Day_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// 정수 배열 array가 매개변수로 주어질 때, 
        /// 가장 큰 수와 그 수의 인덱스를 담은 배열을 return 하도록 solution 함수를 완성해보세요
        /// </summary>
        public int[] BigNumSolution(int[] array)
        {
            int[] answer = new int[2];

            int bigNum = array.Max();
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array.Max())
                    index = i;
            }

            //array의 메소드를 사용하지 않을 떄
            //int bigNum = 0;
            //int index = 0;
            //
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > bigNum)
            //    {
            //        bigNum = array[i];
            //        index = i;
            //    }    
            //}

            answer[0] = bigNum;
            answer[1] = index;

            return answer;
        }

        /// <summary>
        /// 문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때, 
        /// 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다.
        /// 예를 들어 strings가 ["sun", "bed", "car"]이고 n이 1이면 
        /// 각 단어의 인덱스 1의 문자 "u", "e", "a"로 strings를 정렬합니다.
        /// 
        /// strings는 길이 1 이상, 50이하인 배열입니다.
        /// strings의 원소는 소문자 알파벳으로 이루어져 있습니다.
        /// strings의 원소는 길이 1 이상, 100이하인 문자열입니다.
        /// 모든 strings의 원소의 길이는 n보다 큽니다.
        /// 인덱스 1의 문자가 같은 문자열이 여럿 일 경우, 
        /// 사전순으로 앞선 문자열이 앞쪽에 위치합니다.
        /// </summary>
        public string[] solution(string[] strings, int n)
        {
            BubbleSort(strings, n);

            return strings;
        }

        public void BubbleSort(string[] arr, int n)
        {
            int size = arr.Length;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    char left = arr[j][n];
                    char right = arr[j + 1][n];

                    if (left > right)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    else if (left == right &&
                        arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// 정수 n이 주어질 때, 
        /// n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
        /// </summary>
        public int EvenSumSolution(int n)
        {
            int answer = 0;

            for (int i = 0; i<= n; i++)
            {
                if (i % 2 == 0)
                    answer += i;
            }

            return answer;
        }

        /// <summary>
        /// 정수가 들어 있는 배열 num_list가 매개변수로 주어집니다.
        /// num_list의 원소의 순서를 거꾸로 뒤집은 배열을 return하도록 solution 함수를 완성해주세요.
        /// </summary>
        public int[] solution(int[] num_list)
        {
            Array.Reverse(num_list);

            return num_list;
        }
    }
}
