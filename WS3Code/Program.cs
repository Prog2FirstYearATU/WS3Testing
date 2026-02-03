namespace WS3Code
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(GetLargestIndex([9, 9, 9]));
            Console.WriteLine(GetLargestIndex([9, 9, 9, 10, 9, 10, 9, 11, 3, 11, 5]));


            int[] test1 = [67, 45, 64, 34, 456, 45];
            int[] expected = [67, 45, 64, 34, 45, 456];
            WS3Code.Program.MoveLargestToLast(test1);

        }


        public static int GetLargestValue(int[] values)
        {
            int largest;
            if (values.Length == 0)
            {

                largest = 0;
            }
            else
            {
                largest = values[0];

                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i] > largest)
                    {
                        largest = values[i];
                    }
                }
            }

            return largest;
        }

        public static int GetSmallestValue(int[] values)
        {
            int smallest = 0;
            if (values.Length == 0)
            {

                smallest = 0;
            }
            else
            {
                smallest = values[0];

                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i] < smallest)
                    {
                        smallest = values[i];
                    }
                }
            }

            return smallest;
        }

        public static bool IsAscending(int[] values)
        {


            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] > values[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>The index of the largest value, if the largest value is repeated it
        /// will return the largest index</returns>
        public static int GetLargestIndex(int[] values)
        {
            int answer = 0;

            if (values.Length > 1)
            {
                int largest = values[0];

                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i] >= largest)
                    {
                        largest = values[i];
                        answer = i;
                    }
                }
            }
            return answer;
        }

        public static void MoveLargestToLast(int[] values)
        {
            if (values.Length > 1)
            {
                int largestIndex = GetLargestIndex(values);
                int temporary = values[largestIndex];
                for (int i = largestIndex; i < values.Length - 1; i++)
                {
                    values[i] = values[i + 1];
                }
                values[values.Length-1] = temporary;

            }
        }
    }
}
