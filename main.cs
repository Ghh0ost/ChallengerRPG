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
      Console.WriteLine ("Now, my 3 quests...");

    }
}
//Let me know if there is anything you need me to add :) //