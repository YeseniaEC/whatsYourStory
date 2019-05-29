using System;

namespace TextAdventure
{
    class Program
    {
        static void Main ( string[ ] args )
        {
            Console.WriteLine ( "Text Adventure" );
            GameTitle ( );
        }

        public static void GameTitle ( )
        {
            string title = @" 
                 _____         _    ___      _                 _                  
                |_   _|       | |  / _ \    | |               | |                 
                  | | _____  _| |_/ /_\ \ __| |_   _____ _ __ | |_ _   _ _ __ ___ 
                  | |/ _ \ \/ / __|  _  |/ _` \ \ / / _ \ '_ \| __| | | | '__/ _ \
                  | |  __/>  <| |_| | | | (_| |\ V /  __/ | | | |_| |_| | | |  __/
                  \_/\___/_/\_\\__\_| |_/\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|
                                                                                                                                    ";
            Console.WriteLine (title);
            Console.WriteLine ("Press 'Enter' to begin." );
            Console.ReadLine ();
            Console.Clear ( );
            First ( );
        }

        public static void First ( )
        {
            string choice;
            Console.WriteLine ("You wake up in class with an angry Mr. Storm standing over you...");
            Console.WriteLine ("What do you do?");
            Console.WriteLine ("1. Punch him.");
            Console.WriteLine ("2. Cry.");
            Console.WriteLine ("3. Pee a little.");
            Console.Write("Choice: ");
            choice = Console.ReadLine ( ).ToLower ( );
            Console.Clear ( );

            switch ( choice )
            {
                case "1":
                case "punch him":
                case "punch":
                    {
                        Console.WriteLine (" Your fist pounds into Mr. Storm's face.");
                        Console.WriteLine ( "All the other students in class cheer your name." );
                        Console.WriteLine ( "Mrs. Storm hears the commotion and comes to investigate..." );
                        Console.WriteLine ( "When she sees her husband crying in the corner, she shoots you with her laser eyes." );
                        Console.WriteLine ( "Press 'Enter' to continue..." );
                        Console.ReadLine ( );
                        GameOver ( );
                        break;
                    }
                case "2":
                case "cry":
                    {
                        Console.WriteLine ("Mr. Storms face becomes the color of ripe tomatoes.");
                        Console.WriteLine ("'You wanna cry? Do it out in the hall!' He screams at the top of his lungs.");
                        Console.WriteLine ( "Press 'Enter' to continue..." );
                        Console.ReadLine ( );
                        Second ( );
                        break;
                    }
                case "3":
                case "pee":
                case "pee a little":
                    {
                        Console.WriteLine ( "Mr. Storms sniffs the air, the other students begin plugging their noses." );
                        Console.WriteLine ( "'Did you just ... ? Get out of here!' He screams at the top of his lungs." );
                        Console.WriteLine ( "Press 'Enter' to continue..." );
                        Console.ReadLine ( );
                        Second ( );
                        break;
                    }
                default:
                    {
                        Console.WriteLine ("I don't understand that command...");
                        Console.WriteLine ( "Press 'Enter' to try again..." );
                        Console.ReadLine();
                        First ( );
                        break;
                    }
            }
        }
        public static void Second ( )
        {
            Random rnd = new Random ( );
            string[ ] secondOptions =
            {
                "In the hallway, you see that the cops are searching lockers!",
                "In the hallway you see your stalker walking towards you.",
                "In the hallway, the fire alarm goes off."
            };
            int randomNumber = rnd.Next ( 0, 3 );
            string secText = secondOptions[randomNumber];

            string secChoice;

            Console.WriteLine ( secText );
            Console.WriteLine ( "Do you try to hide in the bathroom; Yes or No?" );
            Console.Write ( "Choice: " );

            secChoice=Console.ReadLine ( ).ToLower ( );
            if ( secChoice =="yes" || secChoice == "y")
            {
                Third ( );
            } else if ( secChoice == "no" || secChoice == "n" )
            {
                Console.WriteLine ("A meteor slams into the school at that exact moment, killing you instantly");
                Console.WriteLine ( "Press 'Enter' to continue..." );
                Console.ReadLine ( );
                GameOver ( );
            } else
            {
                Console.WriteLine ( "I don't understand that command..." );
                Console.WriteLine ( "Press 'Enter' to try again..." );
                Console.ReadLine ( );
                Second ( );
            }

        }
        public static void Third ( )
        {
            int age;
            Console.WriteLine ("You burst into the bathroom and all of your friends and family are there.");
            Console.WriteLine ("They yell 'Surprise!' and you remember it's your birthday.");
            Console.WriteLine ("How old are you today?");
            Console.Write( "Age: ");
            int.TryParse ( Console.ReadLine ( ), out age );

            while(age <100 )
            {
                Console.WriteLine ("Seriously? You look older than that!");
                Console.WriteLine ("How old are you really?");
                Console.Write ( "Age: " );
                int.TryParse ( Console.ReadLine ( ), out age );
            }

            Console.WriteLine ("Wow, you're old! You must have been held back a lot!");
            Console.WriteLine ( "Press 'Enter' to continue..." );
            Console.ReadLine ( );
            YouWin ( );
        }
        public static void Fourth ( )
        {

        }

        public static void GameOver ( )
        {
            Console.Clear ( );
            Console.WriteLine ("At your funeral, they sing songs of your bravery. \nThen, they remember who's funeral they are attending and they take it all back...");
            Console.WriteLine ("Better luck next time.");
            Console.WriteLine ("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear ( );
            GameTitle ( );
        }
        public static void YouWin ( )
        {
            Console.Clear ( );
            Console.WriteLine ( "Your birthday party was a big hit. \nThe cake gave everyone superpowers! \nYou will all live for one hundred more years!!!" );
            Console.WriteLine ( "Great Job! You won!" );
            Console.WriteLine ( "Press 'Enter' to try again." );
            Console.ReadLine ( );
            Console.Clear ( );
            GameTitle ( );
        }
    }
}
