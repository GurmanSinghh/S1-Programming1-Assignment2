using System;

namespace Assignment_2
{
    class Program
    {


        //QUESTION 1 


       /* static void Main(string[] args)
        {
            {
                Displaymenu();
            }
        }
        private static void Displaymenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("----------------");
            Console.WriteLine("3. Calculate The Sum");
            Console.WriteLine("4. Calculate The Sum Of Squares");
            Console.WriteLine("5. Calculate The Sum Of Cubes");
            Console.WriteLine(" ");
            Console.WriteLine("-> Press Zero To Exit");
            Console.WriteLine(" ");

            int userInput;

            Console.WriteLine("Please Enter The Number Of Your Choice: ");

            userInput = Int32.Parse(Console.ReadLine());


        }
    }
}*/


        //QUESTION 2


      /*  static void Main(string[] args)
        {
            {
                Displaymenu();
            }
        }
        private static void Displaymenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("----------------");
            Console.WriteLine("3. Calculate The Sum");
            Console.WriteLine("4. Calculate The Sum Of Squares");
            Console.WriteLine("5. Calculate The Sum Of Cubes");
            Console.WriteLine(" ");
            Console.WriteLine("-> Press Zero To Exit");
            Console.WriteLine(" ");

            int userInput;

            do
            {
                Console.Write("Please Enter The Number Of Your Choice: ");

                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 0:
                        Console.WriteLine("Press Any Key To Confirm Exit");
                        break;
                    case 3:
                        Console.WriteLine("Calculate The Sum");
                        break;
                    case 4:
                        Console.WriteLine("Calculate The Sum Of Squares");
                        break;
                    case 5:
                        Console.WriteLine("Calculate The Sum Of Cubes");
                        break;
                    default:
                        Console.WriteLine("That's An Invalid Input");
                        break;
                }
            } while (userInput != 0);
        }
    }
}*/



        //QUESTION 3


       /* public static void Main(string[] args)
         {
             Displaymenu();

             int userInput;

             userInput = Int32.Parse(Console.ReadLine());
             if (userInput == 3)
                 Console.WriteLine("The Sum Is: " + CalculateTheSum(5));
         }
         public static void Displaymenu()
         {
             Console.WriteLine("Calculation Menu");
             Console.WriteLine("----------------");
             Console.WriteLine("3. Calculate The Sum ");
             Console.WriteLine("4. Calculate The Sum Of Squares");
             Console.WriteLine("5. Calculate The Sum Of Cubes");
             Console.WriteLine(" ");
             Console.WriteLine("-> Press Zero To Exit");
            Console.WriteLine(" ");
             Console.Write("Please Enter The Number Of Your Choice: ");

  }
         public static int CalculateTheSum(int n)
         {
             int sumOfNumbers = 0;
             int number = 0;

             for (int i = 0; i < n; i++)
             {
                 Console.Write("Enter A Number: ");
                 number = Int32.Parse(Console.ReadLine());

                 sumOfNumbers += number;
             }
             return sumOfNumbers;
         }
     }
 }*/



        //QUESTION 4

      /*   public static void Main(string[] args)
         {
             Displaymenu();

             int userInput;

             userInput = Int32.Parse(Console.ReadLine());
             if (userInput == 4)
                 Console.WriteLine("The Sum Is: " + CalculateTheSumOfSquares(2));
         }
         public static void Displaymenu()
         {
             Console.WriteLine("Calculation Menu");
             Console.WriteLine("----------------");
             Console.WriteLine("3. Calculate The Sum ");
             Console.WriteLine("4. Calculate The Sum Of Squares");
             Console.WriteLine("5. Calculate The Sum Of Cubes");
             Console.WriteLine(" ");
             Console.WriteLine("-> Press Zero To Exit");
            Console.WriteLine(" ");
             Console.Write("Please Enter The Number Of Your Choice: ");

         }
         public static int CalculateTheSumOfSquares(int n)
         {
             int sumOfSquares = 0;
             int side = 0;

             for (int i = 0; i < n; i++)
             {
                 Console.Write("Enter A Square To Sum: ");
                 side = Int32.Parse(Console.ReadLine());

                 sumOfSquares += side*side;
             }
             return sumOfSquares;
         }
     }
 }*/




        //QUESTION 5


        /*public static void Main(string[] args)
        {
            Displaymenu();

            int userInput;

            userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 5)
                Console.WriteLine("The Sum Is: " + CalculateTheSumOfCubes(7));
        }
        public static void Displaymenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("----------------");
            Console.WriteLine("3. Calculate The Sum ");
            Console.WriteLine("4. Calculate The Sum Of Squares");
            Console.WriteLine("5. Calculate The Sum Of Cubes");
            Console.WriteLine(" ");
            Console.WriteLine("-> Press Zero To Exit");
            Console.WriteLine(" ");
            Console.Write("Please Enter The Number Of Your Choice: ");
            
            

        }
        public static int CalculateTheSumOfCubes(int n)
        {
            int sumOfCubes = 0;
            int side = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter A Cube To Sum: ");
                side = Int32.Parse(Console.ReadLine());

                sumOfCubes += side * side;
            }
            return sumOfCubes;
        }
    }
}*/





























