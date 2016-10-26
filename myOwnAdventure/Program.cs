using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;//Starts action of the user to play game
            int state = 1;//first state
//           
            string handburger="";
            string cheeseHandburger="";
            while (playGame)
            {
                // Switch statement that tells the state of the game, includes the cases the user choose,
                //the state and the actions the user performs
                switch (state)
                {
                   
                    case 1:
                        Console.WriteLine("What is your Name? ");
                        string name = Console.ReadLine();
                        state = 2;
                        break;
                    case 2:
                   
                        Console.WriteLine("Do you want to eat Handbugger? ");
                        handburger = Console.ReadLine();

                     if (handburger == "Yes")
                         {
                           state = 4;
                                        

                         }
                     else
                         {

                            state = 3;
                         }

                     break;

               case 3:
                        Console.WriteLine("Thanks for coming, have a nice day");
                        playGame = false;
                        break;

                    case 4:
                        Console.WriteLine("Do you want Cheese Handburger or regular Handburger? ");
                        cheeseHandburger = Console.ReadLine();
                        if (cheeseHandburger == "Cheese Burger")
                        {
                            state = 5;

                        }

                        else
                        {
                            state = 6;
                        }

                        break;// Breaks the state
                    case 5:

                        Console.WriteLine("Cheese Handburger costs $6:00, you can make your payment");
                        playGame = false;// Statement that terminates the user's action out of case statement
                        break;

                    case 6:
                        Console.WriteLine("Regular Handburger costs $6:00, you can make your payment");
                        playGame = false;// Statement that terminates the user's action out of case statement
                        break;

                                              

                }


            }

        }
    }
}
