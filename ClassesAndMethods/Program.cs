using System;

namespace AIE
{

    //Created a piggybank
    //know a deposit finction
    // class DigitalPiggyBank
    // {
    //     private float balance;
    //
    //     public void Deposit(float amount)
    //     {
    //         //Adding new amount to the current balance
    //         balance = balance + amount;
    //     }
    //
    //     public float Withdraw()
    //     {
    //         float temp = balance;
    //         balance = 0;
    //         return temp;
    //     }
    // }





    class Program
    {
        

        // program entry point
        static void Main()
        {
            Enemy zombie = new Enemy();
            Fighter player = new Fighter();



            bool isGameRunnig = true;

            Console.WriteLine("You have incountered a zombie");

            // game loop - gameplay stuff happens in here
            for (int i = 0; i < 20 && isGameRunnig; i++)
            {
                // player takes their turn
                // TODO: zero out their temp defense
                Console.WriteLine("What would you like to do? 1 - Attack 2 - Defend 3 - Heal");
                string Move = Console.ReadLine();
                Console.WriteLine("Turn No." + i);
                if (Move == "1")
                {
                    zombie.TakeDamage(player.attack);
                    Console.WriteLine("You attacked");
                    Console.WriteLine("Zombie HP:" + zombie.health);
                }
                else if (Move == "2")
                {
                    player.tempDefense = 1;
                    Console.WriteLine("Zombie HP:" + zombie.health);
                    Console.WriteLine("You Defended");
                }
                else if (Move == "3")
                {
                    player.potion = 2;
                    Console.WriteLine("Zombie HP:" + zombie.health);
                    Console.WriteLine("You healed");
                }

                // zombie takes their turn
                player.TakeDamage(zombie.attack);
                Console.WriteLine("Zombie attacks player HP:" + player.health);

                if (player.health <= 0)
                {
                    Console.WriteLine("Player has died");
                    Console.WriteLine("You've Lost");
                    isGameRunnig = false;
                    break;
                }
                else if (zombie.health <= 0)
                {
                    Console.WriteLine("Zombie is dead");
                    Console.WriteLine("You've won");
                    isGameRunnig = false;
                    break;
                }


                        // check if there's a winner
                        // if winner, exit
                        // if not, go to next reptition
            }











            //if (player.health <= 0)
            //{
            //    Console.WriteLine("Player has died");
            //    Console.WriteLine("You've Lost");
            //    isGameRunnig = false;




            //    for (int i = 0; i < 25; i++)
            //    {
            //        zombie.TakeDamage(7);
            //        Console.WriteLine("Zombie has " + player.health + "health");
            //    }
            //    if (zombie.health <= 0)
            //    {
            //        Console.WriteLine("Zombie is dead");
            //        Console.WriteLine("You've won");
            //        isGameRunnig = false;
            //    }

            //}
            // else if (player.health = )
            // {
            //
            // }



            // DigitalPiggyBank dylanPiggyBank = new DigitalPiggyBank();
            //
            // dylanPiggyBank.Deposit(465.76f);
            // 
            // float myCash = dylanPiggyBank.Withdraw();
            // Console.WriteLine(myCash);
        }
    }
}