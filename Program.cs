using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Trumps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileToRead = new StreamReader("U:/cats.txt");
            string[] Lines = new string[30];
            for (int i = 0; i < Lines.Length; i++)
            {
                Lines[i] = fileToRead.ReadLine();
                //Console.WriteLine(Lines[i]);
            }
            string[] Individual = new string[Lines.Length];
            string[] Size = new string[Lines.Length];
            string[] Rarity = new string[Lines.Length];
            string[] GoodTemper = new string[Lines.Length];
            string[] Cuteness = new string[Lines.Length];
            string[] TopTrumpsMischiefRting = new string[Lines.Length];
            string[] Country = new string[Lines.Length];
            string[][] Categories = new string[Lines.Length][];
            
            for (int i = 1; i < Lines.Length; i++)
            {
                Lines[i].Trim();
                Lines[i].Replace(" ", "");
                Categories[i] = Lines[i].Split(',');
                Individual[i] = Categories[i][0];
                Size[i] = Categories[i][1];
                Rarity[i] = Categories[i][2];
                GoodTemper[i] = Categories[i][3];
                Cuteness[i] = Categories[i][4];
                TopTrumpsMischiefRting[i] = Categories[i][5];
                Country[i] = Categories[i][6];
            }
            List<int> Deck1 = new List<int>();
            List<int> Deck2 = new List<int>();
            List<int> ints = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < Lines.Length; i++)
            {
                ints.Add(i);
            }
            while (ints.Count > 1)
            {
                int choice = rand.Next(2);
                //Console.WriteLine(choice);
                if (choice == 0)
                {
                    Deck1.Add(ints[ints[0]]);
                    ints.RemoveAt(ints[0]);
                }
                else
                {
                    Deck2.Add(ints[ints[0]]);
                    ints.RemoveAt(ints[0]);
                }
            }
            if (Deck2.Count < 30)
            {
                for (int i = 0; i < ints.Count; i++)
                {
                    Deck1.Add(ints[i]);
                }
            }
            else
            {
                for (int i = 0; i < ints.Count; i++)
                {
                    Deck2.Add(ints[i]);
                }
            }
            while (Deck1.Count < Deck2.Count)
            {
                Deck1.Add(Deck2[0]);
                Deck2.RemoveAt(0);
            }
            while (Deck1.Count > Deck2.Count)
            {
                Deck2.Add(Deck1[0]);
                Deck1.RemoveAt(0);
            }
            //Console.WriteLine(Deck2.Count);
            //Console.WriteLine(Deck1.Count);
            for (int i = 0; i < Deck1.Count; i++)
            {
                //Console.WriteLine(Deck1[i]);
                //Console.WriteLine(Deck2[i]);
                //Console.WriteLine();
            }
            int choice2 = rand.Next(2);
            if (choice2 == 0)
            {
                Console.WriteLine("Player 1 goes first");
                int card = Deck1[0];
                Console.WriteLine("Individual: " + Individual[card + 1]);
                Console.WriteLine("1. Size: " + Size[card + 1]);
                Console.WriteLine("2. Rarity: " + Rarity[card + 1]);
                Console.WriteLine("3. Good Temper: " + GoodTemper[card + 1]);
                Console.WriteLine("4. Cuteness: " + Cuteness[card + 1]);
                Console.WriteLine("5. Top trumps mischief Rating: " + TopTrumpsMischiefRting[card + 1]);
                Console.WriteLine("Country: " + Country[card + 1]);
                Console.WriteLine();

                Console.WriteLine("Which category would you like to pick?");
                int category = int.Parse(Console.ReadLine());
                if (category == 1)
                {
                    int Size1 = int.Parse(Size[card + 1]);
                    int card2 = Deck2[0];
                    int Size2 = int.Parse(Size[card2 + 1]);
                    Console.WriteLine(Size2);
                    if (Size1<Size2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
                else if (category == 2)
                {
                    int Rarity1 = int.Parse(Rarity[card + 1]);
                    int card2 = Deck2[0];
                    int Rarity2 = int.Parse(Rarity[card2 + 1]);
                    Console.WriteLine(Rarity2);
                    if (Rarity1 < Rarity2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
                else if (category == 3)
                {
                    //Console.WriteLine(card);
                    int Rarity1 = int.Parse(Rarity[card + 1]);
                    int card2 = Deck2[0];
                    //Console.WriteLine(card2);
                    int Rarirty2 = int.Parse(Rarity[card2 + 1]);
                    //Console.WriteLine(Rarirty2);
                    if (Rarity1 < Rarirty2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
                else if (category == 4)
                {
                    int Cuteness1 = int.Parse(Cuteness[card + 1]);
                    int card2 = Deck2[0];
                    int Cuteness2 = int.Parse(Cuteness[card2 + 1]);
                    //Console.WriteLine(Cuteness2);
                    if (Cuteness1 < Cuteness2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
                else
                {
                    int Mischief1 = int.Parse(TopTrumpsMischiefRting[card + 1]);
                    int card2 = Deck2[0];
                    int Mischief2 = int.Parse(TopTrumpsMischiefRting[card2 + 1]);
                    //Console.WriteLine(Mischief2);
                    if (Mischief1 < Mischief2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
            }
            else
            {
                Console.WriteLine("Player 2 goes first");
                int card = Deck2[0];
                Console.WriteLine("Individual: " + Individual[card]);
                Console.WriteLine("Size: " + Size[card]);
                Console.WriteLine("Rarity: " + Rarity[card]);
                Console.WriteLine("Good Temper: " + GoodTemper[card]);
                Console.WriteLine("Cuteness: " + Cuteness[card]);
                Console.WriteLine("Top trumps mischief Rating: " + TopTrumpsMischiefRting[card]);
                Console.WriteLine("Country: " + Country[card]);
                int category = int.Parse(Console.ReadLine());
                if (category == 1)
                {
                    int Size2 = int.Parse(Size[card]);
                    int card2 = Deck2[0];
                    int Size1 = int.Parse(Size[card2]);
                    //Console.WriteLine(Size1);
                    if (Size1 < Size2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
                else if (category == 2)
                {
                    int Rarity2 = int.Parse(Rarity[card]);
                    int card2 = Deck2[0];
                    int Rarity1 = int.Parse(Rarity[card2]);
                    //Console.WriteLine(Rarity1);
                    if (Rarity1 < Rarity2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
                else if (category == 3)
                {
                    //Console.WriteLine(card);
                    int Rarirty2 = int.Parse(Rarity[card + 1]);
                    int card2 = Deck2[0];
                    //Console.WriteLine(card2);
                    int Rarity1 = int.Parse(Rarity[card2 + 1]);
                    //Console.WriteLine(Rarirty2);
                    if (Rarity1 < Rarirty2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
                else if (category == 4)
                {
                    int Cuteness2 = int.Parse(Cuteness[card + 1]);
                    int card2 = Deck2[0];
                    int Cuteness1 = int.Parse(Cuteness[card2 + 1]);
                    //Console.WriteLine(Cuteness2);
                    if (Cuteness1 < Cuteness2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
                else
                {
                    int Mischief2 = int.Parse(TopTrumpsMischiefRting[card + 1]);
                    int card2 = Deck2[0];
                    int Mischief1 = int.Parse(TopTrumpsMischiefRting[card2 + 1]);
                    //Console.WriteLine(Mischief2);
                    if (Mischief1 < Mischief2)
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                }
            }
        }
    }
}
