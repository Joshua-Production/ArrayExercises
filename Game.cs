using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        int[] GetValues()
        {

            //Get the users input

            string[] value = new string[5];

            Console.WriteLine("type what valuse you want for the array");
            value[0] = Console.ReadLine();
            value[1] = Console.ReadLine();
            value[2] = Console.ReadLine();
            value[3] = Console.ReadLine();
            value[4] = Console.ReadLine();

            // Int32.Parse()
            string test = "";
            int a = 0;
            int b = 1;
            int c = 2;
            int d = 3;
            int e = 4;
                
            if (Int32.TryParse(test, out int num))
            {
                a = num;
                b = num;
                c = num;
                d = num;
                e = num;

                



            }
            test = "";
            
            
            return null;
        }

        int[] PrintArray(int[] array)
        {
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
