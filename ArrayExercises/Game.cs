using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/* 
 
*Array Exercises
*Write a function that lets the user enter 5 values into an array
*Add a function that prints the array
*Write a function that prints the sum of the elments in an integer array
*Write a function that prints the highest integer in an array
*Write a function that prints the lowest integer in an array
*Write a function that prints the array in reverse order
*/


//Int32.Parse()
//string test = "5";
//int x = 0;
//if (Int32.TryParse(test, out int num))
//{
//    x = num;
//}

/*value[i] = Convert.ToInt32*/


namespace ArrayExercises
{
    internal class Game
    {
       

        public void Run()
        {
            int[] ints = GetValues();

            PrintArray(ints);
            PrintReverse(ints);
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);

            Console.ReadLine();

        }

        static int[] GetValues()
        {

            //Get the users input

            int[] value = new int[5];
            string input;

            Console.WriteLine(" Type 5 numbers ");
            for (int i = 0; i < value.Length; i++)
            {
               
                input = Console.ReadLine();
               
                if (Int32.TryParse(input, out int num))
                {
                    value[i] = num; 
                }
                
            }
            Console.Clear();




            return value;
        }
        // print array
        int[] PrintArray(int[] array)
        {
            Console.WriteLine(" This is your array  ");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + " ");

            }



            Console.WriteLine("");
            Console.WriteLine("---------------------- ");
                return null;
        }


        // print the sum
        int PrintSum(int[] array)
        {
           
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum = sum + array[i];
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine(" This is the sum of all the numbers in the array");
            Console.WriteLine(sum);


            return sum;
        }

        // print the highest number
        int PrintHighest(int[] array)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine(" This is the highest number in your array ");
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                max = array[i];
            }
            Console.WriteLine(max);
                return 0;
        }
        // prints the lowest number
        int PrintLowest(int[] array)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine(" This is the lowest number in your array ");
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine(min);
            return 0;

        }
        // prints it in reverse
        int[] PrintReverse(int[] array)
        {
            
            Console.WriteLine(" This is your array in reverse ");
            for (int num = array.Length - 1; num >= 0; num--)
            {
                Console.WriteLine(array[num]);
            }

            return null;
        }

        

    }

}
