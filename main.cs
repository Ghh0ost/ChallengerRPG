using System;

  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Challenger!");
      Console.WriteLine("My name is Nara, a friendly traveling Merchant at your service");
      Console.WriteLine("By the looks of it, you are an adventure seeker? ");
      Console.WriteLine ("Perfect, I have 3 Quests lined up for you my friend, ");
      Console.WriteLine("But first, I need your name: ");
      string playerName = Console.ReadLine().ToUpper();
      Console.WriteLine("Hello, " + $"{playerName}, what a fitting name you have for adventuring!");
      Console.WriteLine ("Now for my 3 quests...");
       Console.WriteLine("");

      Console.WriteLine ("Hold on a moment, you dont even know how to play yet! Silly me, ");
      Console.WriteLine ("Here's what to do: ");
      Console.WriteLine ("You will be presented with quesions that should have a pretty obvious answer but if you arent sure respond with:");
      Console.WriteLine ("Yes");
      Console.WriteLine("No");
      Console.WriteLine("A");
      Console.WriteLine("B");
      Console.WriteLine("C");
      Console.WriteLine("D");
      Console.WriteLine("Whichever seems more appropriate");
      Console.WriteLine("...");
      Console.WriteLine("Using your common sense is always useful too");
      Console.WriteLine ("");
      Console.WriteLine ("");
      Console.WriteLine ("Anyways, now for my quests: ");
      Console.WriteLine ("");

      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine ("The Prince has been missing for some time now. The King is worried sick!");
      Console.WriteLine("Knowing his only heir is at the mercy of unknown dangers, makes the king weak with fear for the fate of his kingdom!");
      Console.WriteLine ("If the Prince isn't rescued soon the king shall grow weaker and a kingdom may be left without a king, or a prince to accend the throne.");
      Console.WriteLine("He needs a knight in shining armour! Will it be you?");
      Console.WriteLine ("");
      
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("My next quest involves smugglers and sailing the high seas!");
      Console.WriteLine("Pirates have escaped thier arrest and have out-sailed many a Navy ship attempting to aprehend them but one Navy captain shall stop at nothing to have their heads rolling...");
      Console.WriteLine("Do you think you can become a fugitive of the law and smuggle goods across the Seven seas?");
      Console.WriteLine("");

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("And last, but certainly not least, a rebelious young woman seeks your friendship.");
      Console.WriteLine("After becoming bored of her privileged life, she finds you, a lowly merchant.");
      Console.WriteLine("She seeks adventure and excitment!She's adamant you're perfect for the job,");
      Console.WriteLine("So, will you join her on an adventure of a liftime?");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("So, " + $"{playerName}, who are you?") ;
      Console.WriteLine("A valiant Knight? A vagrant Pirate? Or an ambitious Adventurer?  ");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine ("Please type Knight, Pirate or Adventurer to select your quest: ");

      string knightPath = ("Knight");
      if 

      
    }
}
//Let me know if there is anything you need me to add. I'm not familiar with C# and am slowly learning it at home and havent figured out if statments yet //