using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Pet_Supplies
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a dog leash product");
            Console.WriteLine("Press 2 to add cat food product");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    var dogLeash = new DogLeash();

                    Console.WriteLine("Enter the name of the leash");
                    dogLeash.Name = Console.ReadLine();
                    
                    Console.WriteLine("what is the price of " + dogLeash.Name + " leash?");
                    dogLeash.Price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("What is the quantity of the " + dogLeash.Name + " leash?");
                    dogLeash.Quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the length in inches of the " + dogLeash.Name + " leash?");
                    dogLeash.LengthInches = int.Parse(Console.ReadLine());

                    Console.WriteLine("What material is the " + dogLeash.Name + " leash made of?");
                    dogLeash.Material = Console.ReadLine();

                    Console.WriteLine("Describe the " + dogLeash.Name + " leash");
                    dogLeash.Description = Console.ReadLine();

                    Console.WriteLine("Press 1 to add a dog leash product");
                    Console.WriteLine("Press 2 to add cat food product");
                    userInput = Console.ReadLine();

                    Console.WriteLine(JsonSerializer.Serialize(dogLeash));

                }
                if (userInput == "2")
                {
                    var catFood = new CatFood();

                    Console.WriteLine("Enter the name of the food");
                    catFood.Name = Console.ReadLine();

                    Console.WriteLine("what is the price of " + catFood.Name + " food?");
                    catFood.Price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("What is the quantity of the " + catFood.Name + " food?");
                    catFood.Quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the weight in pounds of the " + catFood.Name + " food?");
                    catFood.WeightPounds = int.Parse(Console.ReadLine());

                    Console.WriteLine("is " + catFood.Name + " Kitten food Y/N?");
                    catFood.KittenFood = Console.ReadLine().ToUpper() == "Y";

                    Console.WriteLine("Describe the " + catFood.Name + " food");
                    catFood.Description = Console.ReadLine();


                    Console.WriteLine("Press 1 to add a dog leash product");
                    Console.WriteLine("Press 2 to add cat food product");
                    userInput = Console.ReadLine();

                    Console.WriteLine(JsonSerializer.Serialize(catFood));

                }
            }


        }

    }

}
       
