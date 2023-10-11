namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            #region For
            //Console.Write("Enter Number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0)
            //        sum++;

            //    if (sum == 3)
            //        break;

            //}
            //if (sum > 2)
            //    Console.WriteLine("Murrek Eded");
            //else
            //    Console.WriteLine("Sade Eded");

            #endregion

            #region While

            //Console.Write("Enter Number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int counter = 1;
            //while (counter <= number)
            //{
            //    if (number % counter == 0)
            //        sum++;
            //    if (sum == 3)
            //        break;
            //    counter++;
            //}
            //if (sum > 2)
            //    Console.WriteLine("Murrek Eded");
            //else
            //    Console.WriteLine("Sade Eded");

            #endregion

            #endregion


            #region Task 2

            //Console.Write("Enter Value : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (; number % 2 == 0 && number > 0;)
            //{
            //    number /= 2;
            //}

            //if (number == 1)
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);



            //Console.Write("Enter Value : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //while (number % 2 == 0 && number > 0)
            //    number /= 2;

            //if (number == 1)
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);


            #endregion


            #region Task 3 
            //Console.Write("Enter Value : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int counter = 0;
            //for (; number != 0; counter++)
            //{
            //    number /= 10;
            //}
            //Console.WriteLine(counter);

            Console.Write("Enter Value : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            
            while (number != 0)
            {
                number /= 10;
                counter++;
            }
            Console.WriteLine(counter);
            #endregion
        }
    }
}