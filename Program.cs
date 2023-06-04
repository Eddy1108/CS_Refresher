﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Refresh1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                ///Working with strings

            string characterName = "Neil";
            int characterAge = 83;

            //String Concatenation
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old.");
            Console.WriteLine("He really liked the name " + characterName + ".");
            Console.WriteLine("But he didnt like being " + characterAge + ".");

            Console.WriteLine("\n");

            //String Interpolation
            Console.WriteLine($"There once was a man named {characterName}");
            Console.WriteLine($"He was {characterAge} years old.");
            Console.WriteLine($"He really liked the name {characterName}.");
            Console.WriteLine($"But he didnt like being {characterAge}.");

            Console.ReadLine();
            Console.Clear();

                ///Common variables
          
            //string phrase = "This is a string";
            //char grade = 'A';
            //int age = -30;
            //uint realAge = 20;
            //float money1 = 0.1f;
            //double gpa = 3.2;
            //bool bIsRunning = false;

            //Console.ReadLine();
            //Console.Clear();

                ///More string functionality

            string text = "Testing \"Programming\" in C#";
            Console.WriteLine(text);
            Console.WriteLine("Lenght of text: " + text.Length);
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.Contains("C#"));
            Console.WriteLine(text[0]);
            Console.WriteLine(text.IndexOf("Programming"));
            Console.WriteLine(text.Substring(9, 3));


            Console.ReadLine();
            Console.Clear();

                ///Storing user input

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}! \nWhat is your age?");
            string userAge = Console.ReadLine();
            Console.WriteLine($"Ah {userAge} is a good age!");

            Console.ReadLine();
            Console.Clear();

            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 5);

            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            Console.ReadLine();
            Console.Clear();

                ///MadLibs game

            string color, pluralNoun, celebrity;
            Console.WriteLine("Enter a Color: ");
            color = Console.ReadLine();
            Console.WriteLine("Enter a Plural Noun: ");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I Love {celebrity}");

            Console.ReadLine();
            Console.Clear();

                ///Arrays in C#

            int[] luckyNumbers = { 7, 14, 21, 42 };
            Console.WriteLine(luckyNumbers[1]);
            luckyNumbers[0] = 1000;
            Console.WriteLine(luckyNumbers[0]);

            string[] food = new string[5];
            food[0] = "Hotdog";
            food[1] = "Pancakes";

            List<string> fruit = new List<string>();
            fruit.Add("Banana");
            fruit.Add("Apple");
            fruit.Add("Orange");
            fruit.Add("Potato");

            for(int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine(fruit[i]);
            }

            fruit.Remove("Potato");
            Console.WriteLine("\n");

            foreach(string s in fruit)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
            Console.Clear();



        }
    }
}