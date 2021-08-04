using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();


            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i <num; i++)
            {

                string[] split = Console.ReadLine().Split(' ');
                PhoneBook.Add(split[0], split[1]);
            }

            Console.WriteLine("enter Queries");

            List<string> queries = new List<string>();

            for (int i=0; i<int.MaxValue; i++)
            {
                
                string query = Console.ReadLine();

                if(!string.IsNullOrEmpty(query))
                {
                    queries.Add(query);
                }
                else
                {
                    break;
                }
            }
            
            

            for (int i=0; i < queries.Count; i++)
            {
                string number;

                if (PhoneBook.TryGetValue(queries[i], out number))
                {
                    Console.WriteLine(queries[i] +" " + number);
                }
                else
                {
                    Console.WriteLine("Not found");

                }
            }      
            
            Console.ReadLine();













        }
    }
}
