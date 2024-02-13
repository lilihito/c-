using System;

using System.Collections.Generic;



namespace PersonWeightApp

{

    class Person

    {

        public string Name { get; set; }

        public int Weight { get; set; }

    }



    class Program

    {

        static void Main(string[] args)

        {

            List<Person> people = new List<Person>();



            Console.WriteLine("Welcome to the Person Weight Application!");



            bool adding = true;

            while (adding)

            {

                Person person = new Person();



                Console.Write("Enter the person's name: ");

                person.Name = Console.ReadLine();



                Console.Write("Enter the person's weight: ");

                int weight;

                if (int.TryParse(Console.ReadLine(), out weight))

                {

                    person.Weight = weight;

                }

                else

                {

                    Console.WriteLine("Invalid weight input. Please enter a valid integer.");

                    continue;

                }



                people.Add(person);



                Console.Write("Do you want to add another person? (yes/no): ");

                string addAnother = Console.ReadLine().ToLower();

                adding = addAnother == "yes";

            }



            Console.WriteLine("\nList of People:");



            int totalWeight = 0;

            foreach (Person person in people)

            {

                Console.WriteLine($"Name: {person.Name}, Weight: {person.Weight}");

                totalWeight += person.Weight;

            }



            Console.WriteLine($"\nTotal weight of all people: {totalWeight}");



            Console.WriteLine("\nThank you for using the Person Weight Application!");

        }

    }

}
