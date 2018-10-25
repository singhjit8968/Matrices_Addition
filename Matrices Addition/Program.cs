using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_Addition
{
    class Program
    {
        static void Main(string[] args)
        {

            //Defining Variables to store arrays and to run loops.
            int i, j;
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];

            //creating Random instance for getting Random values.
            Random random = new Random();

            //Loop to store values in array1 and array 2
            for(i =0; i<=2; i++)
            {
                for(j=0; j<=2; j++)
                {
                    array1[i,j] = random.Next(-10, 10);
                    array2[i, j] = random.Next(-10, 10);
                }
            }

            //using colors to change text colors on console.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMatrix A is:");

            //Printing Array1
            for ( i = 0; i<=2; i++)
            {
                for( j = 0; j<=2; j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nMatrix B is:");

            //Printing Array2
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAddition of Both Matrices C (A+B) is: ");

            //Adding and storing both arrays to array3
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    array3[i, j] = array1[i, j] + array2[i, j];
                }
            }

            //Printing array3 
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    Console.Write(array3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //holding user screen
            Console.Read();
        }
    }
}
