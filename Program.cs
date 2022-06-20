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
            
            static List<int> randomNums = new List<int>();
            static List<string> norepeatCards = new List<string>();

        public static void Main(string[] args){
            
            bool z = true;
            Console.Title = "Caedyn's Blackjack Program v3.0";

            do {
            
                Console.WriteLine("Welcome to Blackjack.");

                Cards();
                Choices("The cards are being dealt. Take two cards?\n(y or n)\nInsert c to see list of all generated cards.", "You take two cards", "Why did you not take the cards?\nTry again, you utterly failed the game. I'm disappointed in you.", "Here are all the cards:");

                Console.ReadKey();
                randomNums.Clear();
                Console.Clear();
            
            }

            while (z == true);

        }

        public static void Choices(string question, string optionOne, string optionTwo, string optionThree) {

            Console.WriteLine(question);
            char userOption;

            userOption = Console.ReadKey().KeyChar;

            if (userOption == 'y') {

                Console.Clear();    
                Console.WriteLine(optionOne);
                dealingCards();

            }

            else if (userOption == 'n') {

                Console.Clear();
                Console.WriteLine(optionTwo);

            }

            else if (userOption == 'c') {
                
                Console.Clear();
                Console.WriteLine(optionThree);
                int z = norepeatCards.Count;

                    for(int i = 0; i < 52; i++) {
                    
                        Console.WriteLine(norepeatCards[i]);

                    }

                Console.WriteLine("There are " + z + " cards.");
                        
            }

            else if (userOption == '`') {
                
                Console.Clear();
                Console.WriteLine("Never gonna give you up. Never gonna let you down.");
                    
            }

            else if (userOption != 'y' || userOption != 'n' || userOption != 'c' || userOption != '`')  {
            
                Console.Clear();
                Console.WriteLine("Please input a valid character.");
                Console.WriteLine("Press any key to return to the start.");
            } 
        
        } 

        public static void Cards() {

            Random numGen = new Random();
            int i = 0;
            int randomNumber = numGen.Next(0, 52);
            string everything = (cardDeck [randomNumber, 0] + " = " + cardDeck [randomNumber, 1]);
    
            while (i <= 51) {

                randomNumber = numGen.Next(0, 52);
                everything = (cardDeck [randomNumber, 0 ] + " = " + cardDeck [randomNumber, 1]);

                    if (!randomNums.Contains(randomNumber)) {
                        
                        randomNums.Add(randomNumber);
                        norepeatCards.Add(everything);
                        i++;
                    
                    }

            }
                
        }

        public static void dealingCards() {
          
            Random cardGen = new Random();
            int randomCard = cardGen.Next(0,52);
            // Put this somewhere later: Console.WriteLine(norepeatCards[randomCard]);

             if (randomNums.Contains(randomCard)) {

                    Console.WriteLine("The norepeatCards card is: " + norepeatCards[randomCard]);
                    randomNums.Remove(randomCard);
                    norepeatCards.RemoveAt(randomCard);
                    Console.WriteLine("it has finished removing the randomInt from the lists.");
                    Console.WriteLine("The norepeatCards card is: " + norepeatCards[randomCard]);             

                }

            //make it so if the list contains the item give it to the player via maybe
            //a list and then remove it from the original list
            //if no repeat num list contains a number, save the number then print out that 
            //id number of the carddeck list and remove that index number from both lists.

            }
           
        }
        
    }

        
        
    

        