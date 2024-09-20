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


// Int32.Parse()
//string test = "5";
//int x = 0;
//if (Int32.TryParse(test, out int num))
//{
//  x = num;
//}

/*value[i] = Convert.ToInt32*/


namespace ArrayExercises
{
    internal class Game
    {
        //making the GetUserInput

        public void Run()
        {
            int[] ints = GetValues();

            PrintArray(ints);
            PrintReverse(ints);
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);



        }

        static int[] GetValues()
        {

            //Get the users input

            int[] value = new int[5];
            string input;
            

            for (int i = 0; i < value.Length; i++)
            {
                input = Console.ReadLine();
               
                if (Int32.TryParse(input, out int num))
                {
                    value[i] = num; 
                }
            }
            
           
           

            return value;
        }

        int[] PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            return null;
        }



        int PrintSum(int[] array)
        {


            return 0;
        }

        int PrintHighest(int[] array)
        {
            return 0;
        }

        int PrintLowest(int[] array)
        {
            return 0;

        }
        int[] PrintReverse(int[] array)
        {
            return null;
        }



    }

}
