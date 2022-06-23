using System;
using System.Collections.Generic;


namespace Blackjack
{
    class Program
    {

        static String[,] cardDeck = { {"Ace of Spades", "1 or 11" }, {"Two of Spades", "2"}, {"Three of Spades", "3"}, 
            {"Four of Spades", "4"}, {"Five of Spades", "5"}, {"Six of Spades", "6"}, {"Seven of Spades", "7"},
            {"Eight of Spades", "8"}, {"Nine of Spades", "9"}, {"Ten of Spades", "10"}, {"Jack of Spades", "10"},
            {"Queen of Spades", "10"}, {"King of Spades", "10"}, {"Ace of Clubs", "1 or 11"}, {"Two of Clubs", "2"},
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
            static List<string> playerCards = new List<string>();
            static List<string> playercardNames = new List<string>();
            static List<int> playercardValue = new List<int>();
            
        public static void Main(string[] args){
            
            bool b = true;
            Console.Title = "Caedyn's Blackjack Program v3.0";

            do {
            
                Console.WriteLine("Welcome to Blackjack.");

                Cards();
                Choices("The cards are being dealt. Take two cards?\n(y or n)\n\nPress 'c' to see the deck of cards.", "You take two cards", "You tried.", "Here are all the cards:\n");

                Console.ReadKey();
                randomNums.Clear();
                playerCards.Clear();
                norepeatCards.Clear();
                Console.Clear();
            
            }

            while (b == true);

        }

        public static void Choices(string question, string optionOne, string optionTwo, string optionThree) {

            Console.WriteLine(question);
            char userOption;

            userOption = Console.ReadKey().KeyChar;

            if (userOption == 'y') {

                Console.Clear();    
                Console.WriteLine(optionOne);
                playergetsCards();

            }

            else if (userOption == 'n') {

                Console.Clear();
                Console.WriteLine(optionTwo);
                Thread.Sleep(1500);
                Console.WriteLine("I guess...?");
                Thread.Sleep(1000);
                Console.WriteLine("Press any key to return to the start.");
                Thread.Sleep(2000);
                Console.WriteLine("You kind of suck at this game. :/");

            }

            else if (userOption == 'c') {
                
                Console.Clear();
                Console.WriteLine(optionThree);
                int z = norepeatCards.Count;

                    for(int i = 0; i < 52; i++) {
                    
                        Console.WriteLine(norepeatCards[i]);

                    }

                Console.WriteLine("\nThere are " + z + " cards.");
                        
            }

            else if (userOption == 's') {
                
                Console.Clear();
                Console.WriteLine("Hi Santos.");
                        
            }

            else if (userOption == 'k') {
                
                Console.Clear();
                Console.WriteLine("Kate was here.");
                        
            }

            else if (userOption == 't') {
                
                Console.Clear();
                Console.WriteLine("Tessa wasn't here.");
                        
            }

            else if (userOption == 'e') {
                
                Console.Clear();
                Console.WriteLine("Mr. Eien Kobayashi in the flesh. Or I guess not flesh.\nHe's here though I guess.");
                        
            }

            else if (userOption == '`') {
                
                Console.Clear();
                Console.WriteLine("Never gonna give you up. Never gonna let you down.");
                /*Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣶⣿⣿⣿⣿⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⠿⠟⠛⠻⣿⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣆⣀⣀⠀⣿⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠻⣿⣿⣿⠅⠛⠋⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢼⣿⣿⣿⣃⠠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣟⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣛⣛⣫⡄⠀⢸⣦⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣴⣾⡆⠸⣿⣿⣿⡷⠂⠨⣿⣿⣿⣿⣶⣦⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣾⣿⣿⣿⣿⡇⢀⣿⡿⠋⠁⢀⡶⠪⣉⢸⣿⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⣿⣿⡏⢸⣿⣷⣿⣿⣷⣦⡙⣿⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣇⢸⣿⣿⣿⣿⣿⣷⣦⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣵⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            ASCII cannot be read by terminal. Needs to be turned into UTF or something*/
                    
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
    
            while (i < 52) {

                randomNumber = numGen.Next(0, 52);
                everything = (cardDeck [randomNumber, 0 ] + " = " + cardDeck [randomNumber, 1]);

                    if (!randomNums.Contains(randomNumber)) {
                        
                        randomNums.Add(randomNumber);
                        norepeatCards.Add(everything);
                        i++;
                    
                    }

            }
                
        }

        public static void playergetsCards() {
          
            Random cardGen = new Random();
            int randomCard = cardGen.Next(0,52);
            int i = 0;

            while (i < 2) {

                randomCard = cardGen.Next(0, 52);

                if (randomNums.Contains(randomCard)) {

                    Console.WriteLine(norepeatCards[randomCard]);
                    playerCards.Add(norepeatCards[randomCard]);
                    randomNums.Remove(randomCard);    
                    i++;          

                }

            }

            bool z = true;
            char userOption;

            do {

                userOption = Console.ReadKey().KeyChar;

                if (userOption == 'y') {

                    randomCard = cardGen.Next(0, 52);

                    if (randomNums.Contains(randomCard)) {

                        Console.Clear();
                        playerCards.Add(norepeatCards[randomCard]);
                        randomNums.Remove(randomCard);           
                        
                        for (int t = 0; t < playerCards.Count; t++) {

                            Console.WriteLine(playerCards[t]);

                        }

                    }

                }

                else if (userOption == 'n') {

                    z = false;

                }

            }
            
            while (z == true);

            //Somehow find a way to make a variable which adds finds the total amount of
            //index rows of playerCards list and add up the values of those indexes

            //You can possibly make two different lists for the player's cards. 
            //One to store the name
            //and one to store the value

        }

        public static void dealergetsCards() {

            

        }
           
    }
        
}

        
        
    

        