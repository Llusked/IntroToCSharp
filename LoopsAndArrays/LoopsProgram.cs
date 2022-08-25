using System;

namespace AIE

{
      class Program
      {

    //        public static int simpleArraySum(List<int> ar)
    //{
    //    int[] userPick = new int[ar.Count];
    //    int sum = userPick.Sum();
    //    for (int i = 0; i < userPick.Length; i++)
    //    {
    //        sum = userPick[i];
    //    }
        
    //}

         static void Main()
         {
         
          //int.TryParse(favNumber, out userNumber);
          //
          //int[] Numbers = new int[3];

         //
         // Console.WriteLine("What are your Favorite Numbers?");
         // Console.WriteLine("Whats the first number?");
         // string userOne = Console.ReadLine();
         // int[] Numbers= new int[3];
         // int.TryParse(userOne, out Numbers[0]);
         // Console.WriteLine("you chose " + userOne);
         // Console.WriteLine("Whats the second number?");
         //  userOne = Console.ReadLine();
         // int.TryParse(userOne, out Numbers[1]);
         // Console.WriteLine("you chose " + userOne);
         // Console.WriteLine("Whats the third number?");
         // userOne = Console.ReadLine();
         // int.TryParse(userOne, out Numbers[2]);
         // Console.WriteLine("you chose " + userOne);
         //
         // Console.WriteLine("your favorite numbers are " + Numbers[0] + ", " + Numbers[1] + ", " + Numbers[2]);


          // {
          //     Console.WriteLine("This is Fizz Buzz");
          //
          //     for (int i = 0; i < 20; i++)
          //     {
          //         if (i % 3 == 0 && i % 5 == 0)
          //         {
          //             Console.WriteLine("FizzBuzz");
          //         }
          //
          //          if (i % 3 == 0)
          //         {
          //          Console.WriteLine("Fizz");
          //         }
          //             else if(i % 5 == 0 )
          //             {
          //                Console.WriteLine("Buzz");
          //             }
          //             else
          //              {
          //             Console.WriteLine(i);
          //             }
          //     }
          //    
          //    
          // }











            Random rnd = new Random(); 
            int randNum = rnd.Next() % 10;
            
            for(int i = 0; i < randNum; i++)
            {
                Console.WriteLine("What is your guess?");
                string userGuess = Console.ReadLine();
                int userNumber = 0;
                int.TryParse(userGuess, out userNumber);

                if (userNumber == randNum)
                {
                    Console.WriteLine("That's the number!");
                }

                else if (userNumber > randNum)
                {
                    Console.WriteLine("Nope, that's too high");
                }

                else
                {
                    Console.WriteLine("Nope, that's too low");
                }

            }
                




            




            //Arrays
          //char singleChar = 'a';
          //char[] characters = { 'A', 'B', 'C', }; //len of 3
          //char[] blankChars = new char[3]; //len of 3
          //
          //Console.WriteLine(characters[0]);
          //characters[1] = '!';
          //Console.WriteLine(characters[1]);

            //Loops

            //1 initializer
            //2 condition
            //3 iteration
          // for (int i = 0; i < characters.Length; i = i + 1)
          // {
          //     Console.WriteLine(characters[i]);
          // }
          //
          // foreach (char cutChar in characters)
          // {
          //      Console.WriteLine(cutChar);
          // }
          // for(int i = characters.Length - 1; i >= 0; i = i -1)
          // {
          //     Console.WriteLine(characters[1]);
          // }


         }
      }
}