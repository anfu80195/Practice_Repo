using System;

namespace Practice_Repo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Anika's Cozy Coffee Casino ☕🎲";

            Console.WriteLine("✨ Welcome to Anika's Cozy Coffee Casino ☕🎲 ✨");
            Console.Write("What's your name? ");
            string name = Console.ReadLine()?.Trim();

            bool isAnika = string.Equals(name, "Anika", StringComparison.OrdinalIgnoreCase);

            if (isAnika)
            {
                Console.WriteLine("\nOMG hi Anika 😌✨ Your vibe has been detected.");
                Console.WriteLine("You get +10 Cozy Energy just for showing up.\n");
            }
            else
            {
                Console.WriteLine($"\nHey {name}! Welcome in 😄\n");
            }

            Random random = new Random();

            int wins = 0;
            int losses = 0;
            int cozyPoints = isAnika ? 10 : 0;

            bool running = true;
            while (running)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Pick your action:");
                Console.WriteLine("1) Roll for FREE COFFEE ☕ (1 in 5 chance)");
                Console.WriteLine("2) Roll for DOUBLE COZY ✨ (harder, bigger reward)");
                Console.WriteLine("3) Check stats 📊");
                Console.WriteLine("4) Exit 👋");
                Console.Write("Your choice: ");

                string choice = Console.ReadLine()?.Trim();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("🎲 Rolling the magic coffee die...");
                            int roll = random.Next(1, 6); // 1-5
                            Console.WriteLine($"You rolled: {roll}");

                            if (roll == 5)
                            {
                                wins++;
                                cozyPoints += 5;
                                Console.WriteLine("✅ YOU WIN A FREE COFFEE!! ☕🎉");
                                Console.WriteLine("+5 Cozy Points ✨");
                            }
                            else
                            {
                                losses++;
                                Console.WriteLine("❌ No coffee today 😭");
                                Console.WriteLine("But honestly? Still iconic.");
                            }

                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("⚠️ DOUBLE COZY MODE ACTIVATED ✨");
                            Console.WriteLine("You need to roll a 7... by rolling TWO dice.");

                            int die1 = random.Next(1, 7); // 1-6
                            int die2 = random.Next(1, 7); // 1-6
                            int total = die1 + die2;

                            Console.WriteLine($"Die 1: {die1}, Die 2: {die2} → Total: {total}");

                            if (total == 7)
                            {
                                wins++;
                                cozyPoints += 15;
                                Console.WriteLine("🌟 YOU HIT 7!! DOUBLE COZY WIN!! 🌟");
                                Console.WriteLine("Reward: free coffee + book-time + blanket energy ☕📖🧣");
                                Console.WriteLine("+15 Cozy Points ✨✨✨");
                            }
                            else
                            {
                                losses++;
                                Console.WriteLine("Nope 😅 The Cozy Gods said 'not today'.");
                                Console.WriteLine("Still, respect for trying.");
                            }

                            break;
                        }

                    case "3":
                        {
                            Console.WriteLine("📊 STATS");
                            Console.WriteLine($"Wins: {wins}");
                            Console.WriteLine($"Losses: {losses}");
                            Console.WriteLine($"Cozy Points: {cozyPoints}");

                            if (wins + losses > 0)
                            {
                                double winRate = (double)wins / (wins + losses) * 100;
                                Console.WriteLine($"Win rate: {winRate:F1}%");
                            }

                            if (isAnika && cozyPoints >= 50)
                            {
                                Console.WriteLine("🏆 Anika Title Unlocked: Supreme Cozy Wizard ✨🧙‍♀️");
                            }

                            break;
                        }

                    case "4":
                        running = false;
                        Console.WriteLine("Bye bestie 👋 Stay cozy 😌✨");
                        break;

                    default:
                        Console.WriteLine("I— what was that choice 😭 Pick 1, 2, 3 or 4.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}