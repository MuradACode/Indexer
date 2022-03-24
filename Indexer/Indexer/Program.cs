using Indexer.Extentions;
using Indexer.Models;
using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the name: ");
            string name = Console.ReadLine().Trim().Capitalize();
            Console.Write("Write the surname: ");
            string surname = Console.ReadLine().Trim().Capitalize();
            Console.Write("Write the age: ");
            int index = 1;
            int age = 0;
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException();
            }
            Person person = new Person(name, surname, age);

            Console.WriteLine("\nDo you want to change something?       (Type 'y' if yes    Type 'n' if no)");
            if (Console.ReadLine().Trim().ToLower() is "y")
            {
                Change:
                Console.WriteLine("-----------------------------\n1: Name\n2: Surname\n3: Age\n------------------------------ ");
                try
                {
                    index = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.Write("What do you want to change to: ");
                if (index is 3)
                {
                    try
                    {
                        age = Convert.ToInt32(Console.ReadLine());
                        person[index] = age.ToString();
                    }
                    catch (Exception)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    person[index] = Console.ReadLine();
                }
                Console.WriteLine("Want to change anything else?       (Type 'y' if yes    Type 'n' if no)");
                if (Console.ReadLine().Trim().ToLower() is "y")
                {
                    goto Change;
                }
                else if (Console.ReadLine().Trim().ToLower() is "n")
                {
                    
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else if (Console.ReadLine().Trim().ToLower() is "n")
            {

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            person.GetInfo();
        }
    }
}
