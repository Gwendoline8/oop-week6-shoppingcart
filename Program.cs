using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listItem = new List<string>();
            int choice;
            double compteur = 0 ;
            do
            {
                Console.WriteLine("Which item do you want to purchase?");
                Console.WriteLine("An apple : Press 1");
                Console.WriteLine("An orange : Press 2");
                Console.WriteLine("I have finished my command and to see it : Press 3");
                Console.WriteLine("To quit : Press 4");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        listItem.Add(" Apple ");
                        compteur=compteur+0.6;
                        break;

                    case 2:
                        Console.Clear();
                        listItem.Add(" Orange ");
                        compteur = compteur + 0.25;
                        break;

                    case 3:
                        Console.WriteLine("Total amount of your purchase : " + compteur + " euros");
                        foreach (string item in listItem)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                }
            }
            while (choice !=4);
        }
    }
}
