using System.Threading.Channels;

namespace C__ASS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (1)Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter a number:");
            //int x = int.Parse(Console.ReadLine());  
            //Console.WriteLine("Number = " + x);
            #endregion

            #region (2)Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //Console.WriteLine("Enter 2 numbers");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Before Change => X = " + x + "  ,  " + "y = " + y);
            //Console.WriteLine("-----------------------------------------------------");
            //x = y;
            //Console.WriteLine("After Change X Equle Y   => X = " + x + "  ,  " + "y = " + y);
            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine("Enter another two numbers ");
            // x = int.Parse(Console.ReadLine());
            // y = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine("Another number for x and y => X = " + x + "  ,  " + "y = " + y);

            #endregion

            #region (3)Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            newClass C1 = new newClass();
            newClass C2 = new newClass();
            C1.x = 10;
            C1.y = 20;
            C2.x = 30;
            C2.y = 40;
            Console.WriteLine("C1(X) = "+C1.x+"  ,  "+ "C1(Y) = "+C1.y);
            Console.WriteLine("C2(X) = " + C2.x + "  ,  " + "C2(Y) = " + C2.y);
            Console.WriteLine("-----------------------------------------------------");

            C1 = C2;

            Console.WriteLine("After C1 Equle C2");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("C1(X) = " + C1.x + "  ,  " + "C1(Y) = " + C1.y);
            Console.WriteLine("C2(X) = " + C2.x + "  ,  " + "C2(Y) = " + C2.y);
            #endregion
        }


    }
}
