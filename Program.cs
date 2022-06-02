﻿using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {

        public static void Main(string[] args){
            
            bool z = true;
           
            do {
            
            Console.Title = "Caedyn's Blackjack Program v3.0";
            Console.WriteLine("Welcome to Blackjack.");
            Console.WriteLine("Press any key to deal cards and start the game.");

            Choices("Enter 1, 2, or 3.", "This represents a hit.", "This represents a pass.", "Here are all the cards:");

            Console.ReadKey();
            Console.Clear();
            
            }
            while (z == true);
        }

        public static void Choices(string question, string optionOne, string optionTwo, string optionThree) {


            try {

            int userOption;
            Console.WriteLine(question);

            userOption = Convert.ToInt16(Console.ReadLine());

            if (userOption == 1) 
            {

            Console.Clear();    
            Console.WriteLine(optionOne);
         
            }

            else if (userOption == 2) 
            {

            Console.Clear();
            Console.WriteLine(optionTwo);

            }

            else if (userOption == 3)
            {
                
                Console.Clear();
                Console.WriteLine(optionThree);
                Cards();
                     
            }

            else if (userOption != 1 || userOption != 2 || userOption != 3)  {
               
                Console.Clear();
                Console.WriteLine("why would you do this. are you dum. thats not 1, 2, or 3. Go bak or perish.");
                //learn how to catch the error when strings are input instead of ints


            } 
            }
           
            catch {

            Console.Clear();
            Console.WriteLine("Error. You did a thing.");

            }
        }

        public static string Cards() {

            String[,] cardDeck = { {"Ace of Spades", "1 or 11" }, {"Two of Spades", "2"}, {"Three of Spades", "3"}, 
            {"Four of Spades", "4"}, {"Five of Spades", "5"}, {"Six of Spades", "6"}, {"Seven of Spades", "7"},
            {"Eight of Spades", "8"}, {"Nine of Spades", "9"}, {"Ten of Spades", "10"}, {"Jack of Spades", "10"},
            {"Queen of Spades", "10"}, {"King of Spades", "10"}, {"Ace of Clubs", "1 or 11"}, {"Two of Clubs", "20"},
            {"Three of Clubs", "3"}, {"Four of Clubs", "4"}, {"Five of Clubs", "5"}, {"Six of Clubs", "6"}, 
            {"Seven of Clubs", "7"}, {"Eight of Clubs", "8"}, {"Nine of Clubs", "9"}, {"Ten of Clubs", "10"}, 
            {"Jack of Clubs", "10"}, {"Queen of Clubs", "10"}, {"King of Clubs", "10"}, {"Ace of Hearts", "1 or 11"},
            {"Two of Hearts", "2"}, {"Three of Hearts", "3"}, {"Four of Hearts", "4"}, {"Five of Hearts", "5"}, 
            {"Six of Hearts", "6"}, {"Seven of Hearts", "7"}, {"Eight of Hearts", "8"}, {"Nine of Hearts", "9"}, 
            {"Ten of Hearts", "10"}, {"Jack of Hearts", "10"}, {"Queen of Hearts", "10"}, {"King of Hearts", "10"}, 
            {"Ace of Diamonds", "1 or 11"}, {"Two of Diamonds", "2"}, {"Three of Diamonds", "3"}, {"Four of Diamonds", "4"}, 
            {"Five of Diamonds", "5"}, {"Six of Diamonds", "6"}, {"Seven of Diamonds", "7"}, {"Eight of Diamonds", "8"}, 
            {"Nine of Diamonds", "9"}, {"Ten of Diamonds", "10"}, {"Jack of Diamonds", "10"}, 
            {"Queen of Diamonds", "10"}, {"King of Diamonds", "10"} };


            Random numGen = new Random();
            int h = 0;
            int i = 0;
           
            HashSet<int> repeatedNums = new HashSet<int>();

            int testNumber = numGen.Next(0, 52);
            string everything = (cardDeck [testNumber, 0] + " = " + cardDeck [testNumber, 1]);

            while (i <= 52) {

                testNumber = numGen.Next(0, 52);
                everything = (cardDeck [testNumber, 0] + " = " + cardDeck [testNumber, 1]);

                if (!repeatedNums.Contains(testNumber)) {
                    
                    repeatedNums.Add(testNumber);
                    Console.WriteLine(everything);
                    i++;
                    h++;
                
                }

            else if(i == 52) {

                break;
                
            }

            }

            return everything;
                
        }

        public static string drawnCards() {
          
           return "ur mom"; 
           
           }
    }
}

        