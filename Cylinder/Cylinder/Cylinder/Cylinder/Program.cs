using System;

namespace Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            float radius;

            Console.WriteLine(" Please input the height ");
            height = Convert.ToSingle( Console.ReadLine());

            Console.WriteLine(" Please input the radius ");
            radius = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(" Surface area = " + (((2 * MathF.PI) * radius * height) + (2 * MathF.PI * (MathF.Pow(radius, 2))))) ;
            Console.WriteLine(" Volume = " + MathF.PI * (MathF.Pow(radius, 2) * height));

           // int a = 7;
           // int b = 2;

           // int result = a / b;
           // Console.WriteLine(result);

            int aNumber = Int32.MaxValue;
            aNumber = aNumber - 1;
            Console.WriteLine(aNumber);



            int a = 3;
            int b = ++a; // Both 'a' and 'b' will now be 4.

            int c = 5;
            int d = c++;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);










            Console.ReadLine();










        }
    }
}
