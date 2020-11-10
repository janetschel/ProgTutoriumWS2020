using System;

namespace BlackJack
{
    class PlayBlackJack
    {
        static void Main(string[] args)
        {
            string input;
            var chipsCount = 10;
            
            do
            {
                chipsCount = PlayGame(chipsCount); // Spielen von Blackjack

                if (chipsCount == 0) // User kann keine Runde mehr spielen, weil er keine Chips mehr hat
                {
                    Console.WriteLine("\nDu hast leider keine Chips mehr und kannst nicht mehr weiterspielen");
                    break;
                }

                Console.Write("\nWillst du noch eine Runde Blackjack spielen? (y/n): ");
                input = Console.ReadLine();
                Console.WriteLine(); // Leerzeile
            } while (input == "y");

            Console.WriteLine($"Du hast das Spiel mit {chipsCount} Chips beendet");
        }

        static int PlayGame(int chipsCount)
        {
            // Abfrage, wie viel Chips der User setzen will
            var chipsCountUserInput = GetUserInput(chipsCount);
            
            // Der Spieler muss mindest 2 Karten nehmen
            Console.WriteLine("\nDas Spiel beginnt!\n");

            var valueOfUserCards = GetPlayerCardValue();

            if (valueOfUserCards > 21)
            {
                Console.WriteLine("Du hast leider verloren, da du über 21 Punkte hast! Dein Einsatz geht an die Bank");
                chipsCount -= chipsCountUserInput;
                return chipsCount;
            }
            
            // User hat noch nicht über 21 Punkte und hat aufgehört zu ziehen -> Computer ist an der Reihe
            var valueOfComputerCards = GetComputerCardValue();

            if (valueOfComputerCards > 21 || valueOfComputerCards < valueOfUserCards)
            {
                Console.WriteLine("\nDer Computer hat verloren, du hast gewonnen!");
                chipsCount += chipsCountUserInput; // Erhält seinen Einsatz doppelt zurück
            } else if (valueOfComputerCards >= valueOfUserCards)
            {
                Console.WriteLine("\nDu hast verloren.. der Computer hat mehr oder gleich viele Punkte als du!");
                chipsCount -= chipsCountUserInput; // Verliert seinen Input
            }

            return chipsCount;
        }

        static int GetComputerCardValue()
        {
            Console.WriteLine(); // benutzen wir nur für eine Leerzeile
            var valueOfComputerCards = 0;

            do
            {
                var currentCard = GetRandomCard();
                valueOfComputerCards += currentCard;

                Console.WriteLine($"Der Computer zieht die Karte mit der Wertigkeit {currentCard}.");
                Console.WriteLine($"Er hat jetzt insgesamt {valueOfComputerCards}");
            } while (valueOfComputerCards <= 16);

            return valueOfComputerCards;
        }

        static int GetPlayerCardValue()
        {
            var firstCardOfUser = GetRandomCard();
            var secondCardOfUser = GetRandomCard();
            
            Console.WriteLine($"Deine erste Karte hat die Wertigkeit {firstCardOfUser}");
            Console.WriteLine($"Deine zweite Karte hat die Wertigkeit {secondCardOfUser}");

            var valueOfUserCards = firstCardOfUser + secondCardOfUser; // initialer Wert

            Console.WriteLine($"Du hast jetzt insgesamt schon {valueOfUserCards} an Karten!\n");

            do
            {
                Console.Write("Willst du eine weitere Karte ziehen? (y/n): ");
                var userWantsMoreCards = Console.ReadLine();

                if (userWantsMoreCards != null && userWantsMoreCards.ToLower().Equals("y"))
                {
                    var newCard = GetRandomCard();
                    Console.WriteLine($"\nDeine neue Karte hat einen Wert von: {newCard}");
                    valueOfUserCards += newCard;
                    Console.WriteLine($"Du hast jetzt insgesamt schon {valueOfUserCards} an Karten!");
                } 
                else if (userWantsMoreCards != null && userWantsMoreCards.ToLower().Equals("n"))
                {
                    break;
                }
            } while (valueOfUserCards < 21);

            return valueOfUserCards;
        }

        static int GetUserInput(int chipsCount)
        {
            int chipsCountUserInput;

            do
            {
                Console.WriteLine($"Wie viele Chips möchtest du setzen? Du hast insgesamt {chipsCount} Chips");
                chipsCountUserInput = Convert.ToInt32(Console.ReadLine());

                if (chipsCountUserInput <= 0 || chipsCountUserInput > chipsCount)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte probiere es nochmal.");
                }
            } while (chipsCountUserInput <= 0 || chipsCountUserInput > chipsCount);

            return chipsCountUserInput;
        }

        static int GetRandomCard()
        {
            var random = new Random();
            return random.Next(2, 12);
        }
    }
}