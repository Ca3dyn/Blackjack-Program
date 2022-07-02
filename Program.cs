using System;
using System.Collections.Generic;


namespace Blackjack
{
    class Program
    {

        static String[,] cardDeck = { {"Ace of Spades", "11" }, {"Two of Spades", "2"}, {"Three of Spades", "3"}, 
            {"Four of Spades", "4"}, {"Five of Spades", "5"}, {"Six of Spades", "6"}, {"Seven of Spades", "7"},
            {"Eight of Spades", "8"}, {"Nine of Spades", "9"}, {"Ten of Spades", "10"}, {"Jack of Spades", "10"},
            {"Queen of Spades", "10"}, {"King of Spades", "10"}, {"Ace of Clubs", "11"}, {"Two of Clubs", "2"},
            {"Three of Clubs", "3"}, {"Four of Clubs", "4"}, {"Five of Clubs", "5"}, {"Six of Clubs", "6"}, 
            {"Seven of Clubs", "7"}, {"Eight of Clubs", "8"}, {"Nine of Clubs", "9"}, {"Ten of Clubs", "10"}, 
            {"Jack of Clubs", "10"}, {"Queen of Clubs", "10"}, {"King of Clubs", "10"}, {"Ace of Hearts", "11"},
            {"Two of Hearts", "2"}, {"Three of Hearts", "3"}, {"Four of Hearts", "4"}, {"Five of Hearts", "5"}, 
            {"Six of Hearts", "6"}, {"Seven of Hearts", "7"}, {"Eight of Hearts", "8"}, {"Nine of Hearts", "9"}, 
            {"Ten of Hearts", "10"}, {"Jack of Hearts", "10"}, {"Queen of Hearts", "10"}, {"King of Hearts", "10"}, 
            {"Ace of Diamonds", "11"}, {"Two of Diamonds", "2"}, {"Three of Diamonds", "3"}, {"Four of Diamonds", "4"}, 
            {"Five of Diamonds", "5"}, {"Six of Diamonds", "6"}, {"Seven of Diamonds", "7"}, {"Eight of Diamonds", "8"}, 
            {"Nine of Diamonds", "9"}, {"Ten of Diamonds", "10"}, {"Jack of Diamonds", "10"}, 
            {"Queen of Diamonds", "10"}, {"King of Diamonds", "10"} };
            
            static List<int> randomNums = new List<int>();
            static List<string> norepeatCards = new List<string>();
            static List<string> playerCards = new List<string>();
            static List<int> randomnumOrder = new List<int>();
            
        public static void Main(string[] args){
            
            bool b = true;
            Console.Title = "Caedyn's Blackjack Program v3.0";

            //I need to make it so aces are worth 11 at first but if the totalValue of the player's
            //cards goes over 21 and an ace is in their hand then make it automatically -10 or something

            do {
            
                Console.WriteLine("Welcome to Blackjack.");

                Cards();
                Choices("The cards are being dealt. Take two cards?\n(y or n)\n\nPress 'c' to see the deck of cards.", "You take two cards", "You tried.", "Here are all the cards:\n");

                Console.ReadKey();
                randomNums.Clear();
                playerCards.Clear();
                norepeatCards.Clear();
                randomnumOrder.Clear();
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
                Thread.Sleep(750);
                Console.WriteLine("I guess...?");
                Thread.Sleep(500);
                Console.WriteLine("Press any key to return to the start.");

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
    
            while (i < 52) {

                randomNumber = numGen.Next(0, 52);

                    if (!randomNums.Contains(randomNumber)) {
                        
                        randomnumOrder.Add(randomNumber);
                        randomNums.Add(randomNumber);
                        norepeatCards.Add(cardDeck[randomnumOrder[i] , 0] + " = " + cardDeck[randomnumOrder[i] , 1]);
                        i++;
                    
                    }

            }
                
        }

        public static void playergetsCards() {
          
            Random cardGen = new Random();
            int randomCard = cardGen.Next(0,52);
            int totalValue = new int();
            int i = 0;
            
            
            while (i < 2) {

                randomCard = cardGen.Next(0, 52);

                for(int h = 0; h < 52; h++) {
                    
                    //string total = toint32.cardDeck[randomnumOrder[h] , 1];
                    //Find a way to print out the values of cards and make it
                    //into an int which can be added together and combined into one

                }

                if (randomNums.Contains(randomCard)) {

                    Console.WriteLine(cardDeck[randomnumOrder[i] , 0] + " = " + cardDeck[randomnumOrder[i] , 1]);
                    playerCards.Add(cardDeck[randomnumOrder[i] , 0] + " = " + cardDeck[randomnumOrder[i] , 1]);
                    randomNums.Remove(randomCard); 
                    int value = Convert.ToInt32(cardDeck[randomnumOrder[i] , 1]);
                    totalValue += value;
                    i++;          

                }

            }

            Console.WriteLine("\nYour total value is: " + totalValue);
            char userOption;

            while (i < 52) {

                userOption = Console.ReadKey().KeyChar;
                randomCard = cardGen.Next(0, 52);

                if (totalValue <= 21) {                  

                    if (userOption == 'y') {

                        if (randomNums.Contains(randomCard)) {

                            Console.Clear();
                            playerCards.Add(cardDeck[randomnumOrder[i] , 0] + " = " + cardDeck[randomnumOrder[i] , 1]);
                            randomNums.Remove(randomCard);
                            int value = Convert.ToInt32(cardDeck[randomnumOrder[i] , 1]);
                            totalValue += value;     
                            i++;      
                            
                            for (int t = 0; t < playerCards.Count; t++) {
                            
                                Console.WriteLine(cardDeck[randomnumOrder[t] , 0] + " = " + cardDeck[randomnumOrder[t] , 1]);
                            
                            }

                            Console.WriteLine("\nYour total value is: " + totalValue);

                        }

                    }

                    if (userOption == 'n') {
                        
                        Console.Clear();
                        
                        for (int t = 0; t < playerCards.Count; t++) {
                            
                            Console.WriteLine(cardDeck[randomnumOrder[t] , 0] + " = " + cardDeck[randomnumOrder[t] , 1]);
                            
                        }

                        Console.WriteLine("You ended with " + totalValue + " points.");
                        break;
                        

                    }
                }

                if (totalValue > 21) {
                    
                    Console.WriteLine("You lost the game. Your total value was over 21");
                    userOption = Console.ReadKey().KeyChar;

                    if (userOption == '?') {

                        Console.Clear();
                        string? hack = null;
                        Console.WriteLine("What, do you have something to say?");
                        hack = Console.ReadLine();

                        if (hack == "imacheater") {

                            Console.Clear();
                            Console.WriteLine("Okay. You know what. You win. \nHave some coins or something. \n\n*You won 10 nickels*");
                            break;

                        }

                        else {

                            Console.WriteLine("Thats really cool. Now go back and play again.");

                        }
                        
                    }

                    Console.ReadKey();
                    break;
                    
                }
            }

        }

    }
        
}

        
        
    

        