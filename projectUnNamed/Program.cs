using System;
namespace UnNamed
{
    internal class Program
    {
        static readonly string rootGladiator = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\";
        static readonly string textGladiator = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\gladiator.txt";
        static readonly string rootDNG= @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\";
        static readonly string textDNG = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\dng.txt";
        static readonly string rootMerc = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\";
        static readonly string textMerc = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\merc.txt";
        static readonly string rootColl = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\";
        static readonly string textColl = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\coll.txt";
        static readonly string rootMedi = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\";
        static readonly string textMedi = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\medi.txt";
        static readonly string rootSldr = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\";
        static readonly string textSldr = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\sldr.txt";
        static readonly string rootWrr = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\";
        static readonly string textWrr = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\warrior.txt";
        static readonly string rootMage = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\";
        static readonly string textMage = @"C:\Users\recep\source\repos\projectUnNamed\projectUnNamed\mage.txt";
        static void Main(string[] args)
        {
            string[] answersAccept = { "Yes", "yes", "Y", "y" };
            string[] answersReject = { "No", "no", "N", "n" };
            string[] kinds = { "Cleveron", "Langereon", "Crossbred" };
            Console.WriteLine("Welcome stranger.");
            Console.ReadKey();
            Console.WriteLine("Do you want to be the main character of this story?");
            Console.Write("--->");
            string mainChar = Console.ReadLine();
            if (mainChar == answersAccept[0] || mainChar == answersAccept[1] || mainChar == answersAccept[2] || mainChar == answersAccept[3])
            {
                Console.WriteLine("Good to hear! Before we start I want to tell somethings about your world.");
                Console.ReadKey();
                Console.WriteLine("You leave in the planet called 'Aestrum'.");
                Console.ReadKey();
                Console.WriteLine("Long before you born were great calamity befell upon your ancestors.");
                Console.ReadKey();
                Console.WriteLine("Thousands maybe millons lost their lives in that disaster.");
                Console.ReadKey();
                Console.WriteLine("Few lucky survivors called that as 'Big Extinction'.");
                Console.ReadKey();
                Console.WriteLine("We are now in the year 1200 (after B.E.)");
                Console.ReadKey();
                Console.WriteLine("You are a...");
                Console.ReadKey();
                Console.WriteLine("Cleveron, your kind good at physical strenght and durability.");
                Console.WriteLine("Langereon, your kind has superior intelligence.");
                Console.WriteLine("Crossbred");
                Console.Write("---> ");
                string answerKind = Console.ReadLine();
                if (answerKind == kinds[0]){
                    double charMgk = 0;
                    Console.WriteLine("You spent your life as...");
                    Console.ReadKey();
                    Console.WriteLine(" (1) Gladiator in areans");
                    Console.WriteLine(" (2) Tank in dungeon raids");
                    Console.WriteLine(" (3) Mercenary");
                    Console.WriteLine("--->");
                    int cleveron1 = Convert.ToInt32(Console.ReadLine());
                    if (cleveron1 == 1)
                    {
                        double charHp = 120;
                        double charStr = 60;
                        double charWsd = 5;
                        double charInt = 20;
                        if (File.Exists(textGladiator))
                        {
                            string text = File.ReadAllText(textGladiator);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.WriteLine("Your don't have magic power");
                        
                        Console.ReadKey();
                    }
                    else if (cleveron1 == 2)
                    {
                        double charHp = 170;
                        double charStr = 30;
                        double charWsd = 50;
                        double charInt = 30;
                        if (File.Exists(textDNG))
                        {
                            string text = File.ReadAllText(textDNG);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.WriteLine("Your don't have magic power");
                        Console.ReadKey();
                    }
                    else if (cleveron1 == 3)
                    {
                        double charHp = 100;
                        double charStr = 80;
                        double charInt = 40;
                        double charWsd = 25;
                        if (File.Exists(textMerc))
                        {
                            string text = File.ReadAllText(textMerc);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.WriteLine("Your don't have magic power");
                        Console.ReadKey();
                    }
                }else if (answerKind == kinds[1])
                {
                    Console.WriteLine("You spent your life as...");
                    Console.ReadKey();
                    Console.WriteLine(" (1) Student in capital college");
                    Console.WriteLine(" (2) Sorcerer in dungeon raids");
                    Console.WriteLine(" (3) Follower of ancestral Sfuwu techniques");
                    int langereon1 = Convert.ToInt32(Console.ReadLine());
                    if (langereon1 == 1)
                    {
                        double charHp = 60;
                        double charStr = 20;
                        double charWsd = 80;
                        double charInt = 90;
                        double charMgc = 55;
                        if (File.Exists(textColl))
                        {
                            string text = File.ReadAllText(textColl);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.WriteLine("Your magic power: " + charMgc);
                        Console.ReadKey();
                    }else if (langereon1 == 2)
                    {
                        double charHp = 75;
                        double charStr = 30;
                        double charWsd = 70;
                        double charInt = 70;
                        double charMgc = 40;
                        if (File.Exists(textDNG))
                        {
                            string text = File.ReadAllText(textDNG);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.WriteLine("Your magic power: " + charMgc);
                        Console.ReadKey();

                    }
                    else if (langereon1 == 3)
                    {
                        double charHp = 60;
                        double charStr = 30;
                        double charWsd = 30;
                        double charInt = 70;
                        double charMgc = 30;
                        if (File.Exists(textMedi))
                        {
                            string text = File.ReadAllText(textMedi);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your magic power: " + charMgc);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.ReadKey();
                        Console.WriteLine("Select your sfuwu path.");
                        Console.ReadKey();
                        Console.WriteLine(" (1) Mind-body connection");
                        Console.WriteLine(" (2) Life & death");
                        Console.WriteLine(" (3) Clairvoyance");
                        //sfuwu paths
                        int langereon2 = Convert.ToInt32(Console.ReadLine());
                        if (langereon2 == 1)
                        {
                            Console.WriteLine("You can harden your skin for resistance.");
                            Console.ReadKey();
                            Console.WriteLine("And you can strengthen your muscles for a short period.");
                            Console.ReadKey();
                            Console.WriteLine("Also you can ease your wounds.");
                            Console.ReadKey();

                        }
                        else if (langereon2 == 2)
                        {
                            Console.WriteLine("You can bring back a dead body to life for short period. It will obey you no matter what.");
                            Console.ReadKey();
                            Console.WriteLine("You can use it on every body but you use your HP for it that means larger and stronger bodies will cost you more.");
                            Console.ReadKey();
                            Console.WriteLine("Also you can bring back yourself as well. But after you doing this, you can no longer use sfuwu. ");
                            Console.ReadKey();


                        }
                        else if (langereon2 == 3)
                        {
                            Console.WriteLine("You can see anothers thoughts, stats, weaknesses.");
                            Console.ReadKey();
                            Console.WriteLine("You can see paths that others can't see");
                            Console.ReadKey();
                        }

                    }
                }else if (answerKind == kinds[3])
                {
                    Console.WriteLine("You spent your life as... ");
                    Console.ReadKey();
                    Console.WriteLine(" (1) Soldier of your empire.");
                    Console.WriteLine(" (2) Warrior in the dungeon raids.");
                    Console.WriteLine(" (3) Student in capital college. ");
                    int crossBred = Convert.ToInt32(Console.ReadLine());
                    if (crossBred == 1)
                    {
                        double charHp = 90;
                        double charStr = 60;
                        double charWsd = 40;
                        double charInt = 40;
                        double charMgc = 20;
                        if (File.Exists(textSldr))
                        {
                            string text = File.ReadAllText(textSldr);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your magic power: " + charMgc);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.ReadKey();
                    }else if (crossBred == 2)
                    {
                        double charHp = 80;
                        double charStr = 60;
                        double charWsd = 60;
                        double charInt = 40;
                        double charMgc = 10;
                        if (File.Exists(textWrr))
                        {
                            string text = File.ReadAllText(textWrr);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your magic power: " + charMgc);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.ReadKey();
                    }else if (crossBred == 3)
                    {
                        double charHp = 60;
                        double charStr = 30;
                        double charWsd = 60;
                        double charInt = 50;
                        double charMgc = 45;
                        if (File.Exists(textMage))
                        {
                            string text = File.ReadAllText(textMage);
                            Console.WriteLine(text);
                        }
                        Console.WriteLine("Your HP: " + charHp);
                        Console.WriteLine("Your STR: " + charStr);
                        Console.WriteLine("Your Wisdom: " + charWsd);
                        Console.WriteLine("Your magic power: " + charMgc);
                        Console.WriteLine("Your intelligent: " + charInt);
                        Console.ReadKey();
                    }
                }


            }
            else if (mainChar == answersReject[0] || mainChar == answersReject[1] || mainChar == answersReject[2] || mainChar == answersReject[3])
            {
                Console.WriteLine("I'm so sory to hear that...");
                Console.ReadKey();
                Console.WriteLine("You can come back when ever you want for this story.");
                Console.ReadKey();
                Console.WriteLine("Press ESC to exit ");
                while (Console.ReadKey(false).Key != ConsoleKey.Escape)
                {
                    Environment.Exit(1);
                }
            }

        }
    }
}
