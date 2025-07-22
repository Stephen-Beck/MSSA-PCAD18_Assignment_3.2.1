/*
Create a 2D array to store integers and print them in matrix format with proper formatting.

Input: {{2,3,4},{1,4,6}}

Output:
    | 2 | 3 | 4 |
    | 1 | 4 | 6 |
*/

using System.Text;

namespace Assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 2, 3, 4 }, { 1, 4, 16 } };
            PrintMatrix(array);
        }

        static void PrintMatrix(int[,] array)
        {
            StringBuilder sb = new();

            // Find the largest number in the array
            // Cast to IEnumerable<int> and then use Max() (( from Google ))
            int max = array.Cast<int>().Max();

            // Using Foreach
            //int max = 0;
            //foreach (int i in array)
            //{
            //    if (i > max)
            //        max = i;
            //}

            // Get length of largest number
            int maxLength = max.ToString().Length;


            //print rows
            for (int r = 0; r < array.GetLength(0); r++)
            {
                sb.Clear(); // reset string for new row
                sb.Append("|");

                // print columns for each row
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    sb.Append($" {array[r, c].ToString().PadLeft(maxLength)} |");
                }

                Console.WriteLine(sb);
            }
        }
    }
}
