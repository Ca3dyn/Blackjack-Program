using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {

        static String[,] cardDeck = { {"Ace of Spades", "1 or 11" }, {"Two of Spades", "2"}, {"Three of Spades", "3"}, 
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

        static List<string> norepeatCards = new List<string>();

        static List<int> randomNums = new List<int>();

        public static void Main(string[] args){

            bool z = true;
            do {
            
            Console.Title = "Caedyn's Blackjack Program v3.0";
            Console.WriteLine("Welcome to Blackjack.");

            Cards();
            Choices("The cards are being dealt. Take two cards?\n(y or n)\nInsert c to see list of all generated cards.", "You take two cards", "You suck at card games.\nTry again.", "Here are all the cards:");

            Console.ReadKey();
            norepeatCards.Clear();
            randomNums.Clear();
            Console.Clear();

            }

            while (z == true);

        }

        public static void Choices(string question, string optionOne, string optionTwo, string optionThree) {

            char userOption;
            Console.WriteLine(question);

            userOption = Console.ReadKey().KeyChar;

            if (userOption == 'y') {

                Console.Clear();    
                Console.WriteLine(optionOne);
                dealCards();
        
            }

            else if (userOption == 'n') {

                Console.Clear();
                Console.WriteLine(optionTwo);

            }

            else if (userOption == 'c') {
                
                Console.Clear();
                Console.WriteLine(optionThree);

                int z = norepeatCards.Count;
                Console.WriteLine("This array has: " + z + " lines.");

                for(int i = 0; i < 52; i++) {
                
                Console.WriteLine(norepeatCards[i]);

                }
      
            }

            else if (userOption == '`') {
                
                Console.Clear();
                Console.WriteLine("Never gonna give you up. Never gonna let you down.");
                    
            }

            else if (userOption != 'y' || userOption != 'n' || userOption != 'c')  {
            
                Console.Clear();
                Console.WriteLine("Please input a valid character.\nPress any key to return to the start.");

            } 
        }

    

        public static void Cards() {

            Random numGen = new Random();
            int i = 0;
            int randomNum = numGen.Next(0, 52);
            string everything = (cardDeck [randomNum, 0] + " = " + cardDeck [randomNum, 1]);
    
            while (i < 52) {

                randomNum = numGen.Next(0, 52);
                everything = (cardDeck [randomNum, 0 ] + " = " + cardDeck [randomNum, 1]);

                if (!randomNums.Contains(randomNum)) {
                    
                    randomNums.Add(randomNum);
                    norepeatCards.Add(everything);
                    i++;
                
                }

            }
                
        }


        public static void dealCards() {

            Random randomCard = new Random();
            int randomInt = randomCard.Next(0, 52);
            int i = 0;

            //while (i <= 3) {

                randomInt = randomCard.Next(0, 52);

                if (randomNums.Contains(randomInt)) {

                    Console.WriteLine("The norepeatCards card is: " + norepeatCards[randomInt]);
                    randomNums.Remove(randomInt);
                    norepeatCards.RemoveAt(randomInt);
                    Console.WriteLine("it has finished removing the randomInt from the lists.");
                    Console.WriteLine("The norepeatCards card is: " + norepeatCards[randomInt]);
                    Console.WriteLine("The above text should be empty.");
                    i++;
                

                }
                
            //}

        }

    }
}

        
    

        