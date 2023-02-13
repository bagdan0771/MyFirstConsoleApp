using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperatorExamples();
            TryAnif();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x==10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn't 10");//this
            }
        }

        private static void TryAnif()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue == 3) &&(name =="Joe"))
            {
                Console.WriteLine("X is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");//this
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while (count <10)
            {
                count = count + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;//8,7,6,5
            }
            Console.WriteLine("The answer is " + count);//5
        }

        private static void OperatorExamples()
        {
            /*int width = 3;
            width++;
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            while (area <20)
            {
                height++;
                area = width * height;
            }

            do
            {
                width--;
                area = width * height;
            } while (area>25);
            string result = "the area";
            result = result + " is " + area;
            Console.WriteLine(result);
            bool truthValue = true;
            Console.WriteLine(truthValue);*/
            
        }
    }
}
