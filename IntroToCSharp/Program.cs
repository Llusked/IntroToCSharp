using System;

namespace AIE
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int height = 0, width = 0;


            Console.WriteLine("Width?");
            string userWidth = Console.ReadLine();
            Console.WriteLine("Height?");
            string userHeight = Console.ReadLine();

            int.TryParse(userHeight, out height);
            int.TryParse(userWidth, out width);

            Console.WriteLine("volume of rec is"+height * width);

         string numberInput = Console.ReadLine();
          int userNumber = 0;
          int.TryParse(numberInput, out userNumber);
         Console.WriteLine("you Wrote the number" + userNumber);
        Console.WriteLine("If Squared, it would be " + userNumber * userNumber);

           
            
            
            //string testNumber = "1";
            //int userNumber = -1;
            //int points = 0;

            //int.TryParse(testNumber, out userNumber);

            //Console.WriteLine("What is the first color of the rainbow?");
            //string AnsOneInput = Console.ReadLine();
            //if (AnsOneInput != "Red")
            //{
            //    points = points + 1;
            //}

            //Console.WriteLine("you got" + points + "out of ");
            
            
         
            
            
            
            
            
            
            Console.WriteLine("Hello World");
            Console.WriteLine("Hannah Howard");

            //Type Name (Value)
            int age = 18;

            Console.WriteLine(age);

            

            Console.WriteLine("What's your name?");
            string NameInput = Console.ReadLine();
            Console.WriteLine("Your name is " + NameInput + "? Thats a nice name, mine is Hannah!");

            Console.WriteLine("What is your favorite piece of candy");
            string FavCandyInput = Console.ReadLine();
            Console.WriteLine("Your Favorite is " + FavCandyInput);

            if (FavCandyInput == "Reese's")
            {
                Console.WriteLine("Oh, I like that one too!!");
            }
            else if (FavCandyInput == "Snickers")
            {
                Console.WriteLine("I'm not a fan of Snickers...");
            }
            else
            {
                Console.WriteLine("Not sure if I like that one or not");
            }

            Console.WriteLine("If you were a vegetable, what vegetable would you be?");
            string VegeInput = Console.ReadLine();
            Console.WriteLine("You picked a " + VegeInput);

            if(VegeInput == "Cucumber")
            {
                Console.WriteLine("Me too!! I'd also pick a" + VegeInput);
            }
            else
            {
                Console.WriteLine("A " + VegeInput + ", Intresting... I'd personally choose a cucumber lol");
            }

            Console.WriteLine("How many years have you been playing games?");
            string YearsPlayedInput = Console.ReadLine();
            Console.WriteLine("You said " + YearsPlayedInput);

            if(YearsPlayedInput == "1")
            {
                Console.WriteLine("You're just getting started, keep up the good work!");
            }
            else
            {
                Console.WriteLine(YearsPlayedInput + ", that's a good amount of years");
            }

            Console.WriteLine("What was the first game you played?");
            string FirstGameInput = Console.ReadLine();
            Console.WriteLine("You said " + FirstGameInput);






          

        }   
    }
}
