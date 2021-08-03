using System;
using System.Collections.Generic;
using System.Text;

namespace More_practice
{
    class Person
    {
        public int age;


        public Person ( int initialAge)
        {
            if (initialAge > 0)
            {


                age = initialAge;
            }
            else if(initialAge < 0)
            {
                age = 0;
              
                Console.WriteLine("Age is not valid, setting age to 0.");
                
            }
            
        }

        public void yearPasses()
        {
            age = age + 1;
        }
        public void amIOld()
        {
            if(age < 13 && age >= 0)
            {
                Console.WriteLine("You are young.");
            }
            else if(age >= 13 && age <18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }





    }
}
