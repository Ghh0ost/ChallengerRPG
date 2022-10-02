using System;
class Program {
    public static void Main(string[] args)
    {
      string stringYes = "yes";
      string stringNo = "no";
      int playerHp = 100;
      int enemyHp = 200;
      int enemyDmg = 40;

      //sup bro, whats your name
      Console.WriteLine("Welcome to Challenger!");
      Console.WriteLine("My name is Nara, a friendly travelling Merchant at your service");
      Console.WriteLine("By the looks of it, you are an adventure seeker?");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine ("Please type yes or no: ");
      Console.ForegroundColor = ConsoleColor.White;
      string playerStart = Console.ReadLine().ToLower();
      if (playerStart == stringYes){
        Console.WriteLine ("Perfect, I have 2 wonderful quests lined up for you my friend, ");
        }
      if (playerStart == stringNo){
        Console.WriteLine ("Then why are you here?");
        Console.WriteLine("If you aren't here to partake what are you here for?");
        Console.WriteLine("...");
        Console.WriteLine("You know what, I dont care. Just get out.");
        System.Environment.Exit(1);
        }
        
      if (playerStart != stringYes & playerStart != stringNo){
        Console.WriteLine("...");
        Console.WriteLine("You humans really do confuse me...");
        System.Environment.Exit(1);
        }
      
      Console.WriteLine("But first, I need your name: ");
      string playerName = Console.ReadLine().ToUpper();
       Console.Write("Hello, "  );
       Console.ForegroundColor = ConsoleColor.Magenta;
       Console.Write( playerName);
       Console.ForegroundColor = ConsoleColor.White;
       Console.Write(", what a fitting name you have for adventuring! ");
      Console.WriteLine ("Now for my 2 quests...");
       Console.WriteLine("");

      //settings
      Console.WriteLine ("Hold on a moment, you don't even know how to play yet! Silly me, ");
        Console.WriteLine ("You will be presented with quesions that should have a pretty obvious answer but if you aren't sure respond with:");
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
      
      //QuEsTs
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine ("The Prince has been missing for some time now. The King is worried sick!");
      Console.WriteLine("Knowing his only heir is at the mercy of unknown dangers, makes the King weak with fear for the fate of his Kingdom!");
      Console.WriteLine ("If the Prince isn't rescued soon the King shall grow weaker and a Kingdom may be left without a King, or a Prince to ascend the throne.");
      Console.WriteLine("He needs a Knight in shining armour! Will it be you?");
      Console.WriteLine ("");
      
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("My next quest involves smugglers and sailing the high seas!");
      Console.WriteLine("Pirates have escaped their arrest and have out-sailed many a Navy ship attempting to apprehend them but one Navy Captain shall stop at nothing to have their heads rolling...");
      Console.WriteLine("Do you think you can become a fugitive of the law and smuggle goods across the Seven seas?");
      Console.WriteLine("");
      
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("So, ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(playerName);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" who are you? ");
      
      Console.WriteLine("A valiant Knight or a vagrant Pirate?");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine ("Please type Knight or Pirate to select your quest: ");
      Console.ForegroundColor = ConsoleColor.White;
      //who is you my bro?
    string playerRole = Console.ReadLine().ToUpper();
    Console.WriteLine("I think being a " + playerRole + " suits you!"); 

      //knight path chosen
      if (playerRole == "KNIGHT"){
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("Castle of the great King and Knight ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(playerName + "'S");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(" headquaters");
        Console.WriteLine (@" 
               /\                                                        /\
              |  |                                                      |  |
             /----\                                                    /----\
            [______]                                                  [______]
             |    |         _____                        _____         |    |
             |[]  |        [     ]                      [     ]        |  []|
             |    |       [_______][ ][ ][ ][][ ][ ][ ][_______]       |    |
             |    [ ][ ][ ]|     |  ,----------------,  |     |[ ][ ][ ]    |
             |             |     |/'    ____..____    '\|     |             |
              \  []        |     |    /'    ||    '\    |     |        []  /
               |      []   |     |   |o     ||     o|   |     |  []       |
               |           |  _  |   |     _||_     |   |  _  |           |
               |   []      | (_) |   |    (_||_)    |   | (_) |       []  |
               |           |     |   |     (||)     |   |     |           |
               |           |     |   |      ||      |   |     |           |
             /''           |     |   |o     ||     o|   |     |           ''\
            [_____________[_______]--'------''------'--[_______]_____________]");
        Console.WriteLine("");}
      
      //pirate path chosen
      if (playerRole == "PIRATE"){
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Captain ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write (playerName +"'S " );
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Pirate ship");
        Console.WriteLine(@"

              |/    w          
             / (   (|   \
            /( (/   |)  |\
     ____  ( (/    (|   | )  ,
    |----\ (/ |    /|   |'\ /^;
   \---*---Y--+-----+---+--/(
    \------*---*--*---*--/
     '~~ ~~~~~~~~~~~~~~~");}   

//knight start
    if (playerRole == "KNIGHT"){
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("You find yourself outside 2 large wooden doors, behind it you hear wailing akin to a petulant child.");
      Console.WriteLine(@"
     ___,--,___      ___,--,___ 
    / | | | | | \  / | | | | | \
    | | | | | | |  | | | | | | |
    | | | | | | |  | | | | | | |
    | | | | | <&>  <&> | | | | |
    | | | | | | |  | | | | | | |
    | | | | | | |  | | | | | | |
    | | | | | | |  | | | | | | |
    | | | | | | |  | | | | | | | 
    ----------------------------");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine ("");
      Console.WriteLine("No no no! I need my son back, he's the only good thing that WENCH gave me!");
      Console.WriteLine("UNHAND me! How dare you ask me to calm down!");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("");
      Console.Write("You decide to knock on the door; you're not sure why but this place seems familiar; then you hear a stern voice say ");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write ("ENTER!");
      Console.WriteLine ("");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine ("The doors open to reveal a lavish throne room, a man lounges on a much-too-large throne, his Crown lopsided on his rather small head. His furrowed brow lifts as his eyes settle on you.");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write ("KNIGHT ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(playerName);
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("! Oh am I glad to see you!");
      Console.WriteLine ("");
      
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine ("The man stands and rushes towards you, his glittery Crown hitting the floor with a crack, he doesnt seem to care if it's broken.");
      Console.WriteLine ("He grasps your hands in his and stares at you with a smile, his eyes pleading, ");
      
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("I need your expertise to find my son. He has been missing for over a week now! I fear the worst for my only son and heir,");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine ("He dramatically drapes his arm over his eyes looking even more insincere than he sounds.");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("I need a big strong Knight in shining armour to save my dearest son! Will you find him for me?");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine ("He flashes you some puppy-dog eyes, do you accept his plea or are you not the knight for the job?");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine ("Please type Yes or No (case sensitive): ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      
      string knightdecision1 = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.Cyan;
      if (knightdecision1 == "Yes"){
        Console.WriteLine("Oh thank you so much my dear Knight! My son was last spotted on our neighbouring island, go search there first.");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("He winks at you and pats your shoulder as he leaves through the heavy doors behind you, he seems in a much better mood now...");
        Console.WriteLine ("");
        Console.WriteLine ("");
        Console.WriteLine ("After assembling a small party of sailors you set out for the next neighbouring island, Escapar.");
        Console.WriteLine ("On arrival you spy a Pirate ship, this island is frequented by people of many trades but pirates are a rarity in this corner of the ocean.");
        Console.WriteLine ("You eye it with suspicion but have no reason to repremand them.");
        Console.WriteLine ("");
        Console.WriteLine("You decide its a good time for a new weapon, you've been lugging this old lonsword around for the past 2 years. The king pays pretty well so a new weapon sounds like a good investment.");
        Console.WriteLine("");
      //merchant shop buying weapons//
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Welcome to my humble establishment, in line for a new weapon? I'm your man!");
      if (playerRole == "KNIGHT"){
        Console.WriteLine("Now this is new in. A beautiful longsword with the gleam of a warrior's will.");
        Console.WriteLine("This bow has seen many a battle however, its quality is still top notch.");
        Console.WriteLine("This shortsword has been in this shop for centuries, just waiting for someone worthy enough to weild it.");
      Console.WriteLine("So, what will it be?");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine ("Please type 1, 2 or 3: ");
      string playerWeapon = Console.ReadLine().ToLower();
Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("An excelent choice honourable knight!");
      }
      //story continues//
        Console.WriteLine("");
        Console.WriteLine ("After leaving the Bladesmith's, you begin to ask around the towns people giving a detailed description of the Prince to each but your search comes up fruitless. Frustrated you decide to take a break in a nearby tavern.");
        Console.WriteLine ("Having only sat down for less than 5 minutes, the tavern door opens with a bang and two rough men look very pleased with themselves as they drag a weary-looking figure behind them.");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine ("");
        Console.WriteLine ("Captain! We caught this rapscallion trying to steal our food stock, cheeky bugger! What shall we do with him? Take him with us and then throw him into the volcano?");
          Console.Write ("Or make 'im walk the plank!?");
          Console.ForegroundColor = ConsoleColor.DarkBlue;
          Console.Write(" The other chimes in excidedly.");
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.Write ("NO! Let go of me you dirty pirates!!");
         Console.ForegroundColor = ConsoleColor.DarkBlue;
         Console.Write ("The figure wrenches his arm from one of the pirates' grasp but the other scoops him up into his burly arms.");
        Console.WriteLine ("You'd recognise that entitled screech anywhere. The Prince writhes and wriggles in the pirates arms but to no avail.");
        Console.WriteLine ("");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine ("Drop him. Now!");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine ("A voice, full of authority, calls from behind you,");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine ("What made you imbeciles think I would be interested in some street trash?");
          Console.Write ("STREET TRASH?!");
          Console.ForegroundColor = ConsoleColor.DarkBlue;
          Console.Write ("The Prince shreeks incredulously.");
         Console.WriteLine ("You're rather enjoying the show when a familiar sound reaches your ears; a sword being unsheathed.");
         Console.ForegroundColor = ConsoleColor.DarkBlue;
         Console.WriteLine ("Will you swoop in and save the prince or leave him to his fate?");
         Console.ForegroundColor = ConsoleColor.Black;
         Console.WriteLine ("Please type Yes or No: ");
         Console.ForegroundColor = ConsoleColor.Magenta;
        //to save or not to save that is the question
         string toSave = Console.ReadLine();
         if (toSave == stringYes){
           Console.WriteLine ("Faster than you can comprehend, you have pulled your own sword from its scabbard and caught the Pirate Captain's sword as it caresses the Prince's chin.");
          bool fightInitiated = true;
            while (fightInitiated == true){
              Console.WriteLine("The Captain catches looks at your sword with distaste.");
              Console.ForegroundColor = ConsoleColor.Cyan;
              Console.WriteLine("Sir, are you willing to duel for this man's honour? Because you're going that way,");
              Console.ForegroundColor = ConsoleColor.DarkBlue;
              Console.WriteLine("The Captain side-eyes you; his crew shuffle to his aide but he raises a hand. They reluctantly back off but the captain seems sure of his abilities.");
              Console.WriteLine("You dont want to drag this out any longer and lunge at him, your blade grazes his arm, slicing through his perfectly tailored jacket; blood begins to soak his forearm but he only looks amused.");
              Console.ForegroundColor = ConsoleColor.Cyan;
              Console.WriteLine("oooh! A " + );
            }
         }


           
       if (knightdecision1 == stringNo){
        Console.ForegroundColor = ConsoleColor.DarkBlue;
          Console.WriteLine("The King's eyebrows furrow furiously and he fixes his mouth in a sneer,");
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("Then why are you here! You are a useless Knight! LEAVE!! I cant stand the sight of you.");
         System.Environment.Exit(1);
         }
//ends knight path// 
    } 
      
//Pirate start//
    if (playerRole == "PIRATE"){
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Captain?.... Captain?");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("You grogily open your eyes to the shine of morning sun coming through your porthole window. A voice beside you has awoken you from your slumber.");
      Console.WriteLine("You roll over on your hard mattress and meet the eyes of a familiar face.");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("'Good Morning, Nate.'");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("You say with a smile. Nate, your first mate and partner sits on the edge of your bed already dressed and ready for the day.");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write("Good Morning, Captain ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.Write(playerName);
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write(", sleep well?");
      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("'Yes thank you, what's on the adgenda today?'");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("Nate, looks around the room until his eyes settle across the room on a map weighted on your desk.");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("How about we finally go to that Volcanic island? Its only another island away, we may find that the legends are true and the dragon really does harbour a mound of gold in a mysterious cave?");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Sounds intriguing, a mound of gold or a boring trip to the mainland? Will you take up his offer?");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine ("Please type Yes or No (case sensitive): ");
      Console.ForegroundColor = ConsoleColor.Magenta;
      string piratedecision1 = Console.ReadLine();
       if (piratedecision1 == "Yes"){
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("Oh wonderful! Shall we go and inform the crew?");
         Console.ForegroundColor = ConsoleColor.DarkRed;
         Console.WriteLine("Nate looks ecstatic; its adorable.");
         Console.ForegroundColor = ConsoleColor.Magenta;
         Console.WriteLine("'You go on ahead, I'm still waking up,'");
         Console.ForegroundColor = ConsoleColor.DarkRed;
         Console.WriteLine("Nate nods enthusiastically and practically bounces out of your cabin.");
       }
      if (piratedecision1 == "No"){
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine ("Oh, okay...");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine ("Nate looks rather solumn as he leaves your cabin, you feel bad but it's still too early for you. You go back to sleep.");
         System.Environment.Exit(1);
      }
    }
     if (playerRole == "PIRATE"){
      
     }

      
      
    















      
  }
}





//Let me know if there is anything you need me to add.//