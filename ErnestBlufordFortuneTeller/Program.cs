using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErnestBlufordFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declared Variables
            int birthMonth;
            int age;
            int numberOfSiblings;
            int retirementStandard = 65;
            int yearstilRet = 20;
            int retire;
            double moneyInTheBank;
            string firstName;
            string lastName;
            string red = "RED";
            string orange = "ORANGE"; //To upper for input.
            string yellow = "YELLOW";
            string green = "GREEN";
            string blue = "BLUE";
            string indigo = "INDIGO";
            string violet = "VIOLET";
            string help = "";
            string color;
            string favColor;
            string choice;
            string vacay;
            string car = "Nothing";
                       
            

            Console.WriteLine("What is your First Name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name");
            lastName = Console.ReadLine();
            Console.WriteLine("In What number month were you born?");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Of all the Colors of the Rainbow... Which is your favorite? Remember...ROYGBIV");
            favColor = Console.ReadLine().ToUpper();

                //Colors and Help Menu
            switch (favColor)
            {
                 
                case "RED":
                    Console.WriteLine("Ah,red the color of fire.");
                    break;
                case "YELLOW":
                    Console.WriteLine("Ah, yellow, the color of the sun");
                    break;
                case "ORANGE":
                    Console.WriteLine("Hm...orange, the color of...an orange?  I'm a Fortune Teller, not a poet");
                    break;
                case "GREEN": 
                    Console.WriteLine("Green, vibrant grass...");
                    break;
                case "BLUE":
                    Console.WriteLine("Blue...do you think of the sky and the ocean often?");
                    break;
                case "INDIGO":
                    Console.WriteLine("Indigo...it's like blue but deeper.  Like you?");
                    break;
                case "VIOLET":
                    Console.WriteLine("Violet, it's like purple but with a dash of passion.");
                    break;


                default:
                    Console.WriteLine("Hmm...That is not a color of the Rainbow. Perhaps, you need some help? If you do, tell me.");
                    help = Console.ReadLine().ToUpper();
                    break;



            }
            if (help == "HELP")
            {
                Console.WriteLine("My Child, the colors of the Rainbow are ROYGBIV which means {0},{1},{2},{3},{4},{5},{6} and {7}", red, orange, yellow, blue, green, blue, indigo, violet);
                Console.WriteLine("Now, tell me of all the colors of the rainbow, which is your favorite?");
                favColor = color = Console.ReadLine().ToUpper();

                switch (color)
                {

                    case "RED":
                        Console.WriteLine("Ah,red the color of fire.");
                        break;

                    case "YELLOW":
                        Console.WriteLine("Ah, yellow, the color of the sun");
                        break;
                    case "ORANGE":
                        Console.WriteLine("Hm...orange, the color of...an orange?  I'm a Fortune Teller, not a poet");
                        break;
                    case "GREEN":
                        Console.WriteLine("Green, vibrant grass...");
                        break;
                    case "BLUE":
                        Console.WriteLine("Blue...do you think of the sky and the ocean often?");
                        break;
                    case "INDIGO":
                        Console.WriteLine("Indigo...it's like blue but deeper.  Like you?");
                        break;
                    case "VIOLET":
                        Console.WriteLine("Violet, it's like purple but with a dash of passion.");
                        break;

                    default:
                        Console.WriteLine("Hmm...That is not a color of the Rainbow. Perhaps, you need some help? If you do, tell me.");
                        help = Console.ReadLine().ToUpper();
                        break;


                }
            }

            Console.WriteLine("How many siblings do you have?");
            numberOfSiblings = int.Parse(Console.ReadLine());


            //Choosing Transportation
            if (favColor == "RED")
            {
                car = "Firebird";
            }
            else if (favColor == "ORANGE")
            {
                car = "Buick";
            }
            else if (favColor == "YELLOW")
            {
                car = "Sun Chariot";
            }
            else if (favColor == "GREEN")
            {
                car = "Swamp Dragon";
            }
            else if (favColor == "BLUE")
            {
                car = "Cloud";
            }
            else if (favColor == "INDIGO")
            {
                car = "Griffin";
            }
            else if (favColor == "Violet")
            {
                car = "Skeletal Horse";
            }
            else
            {
                car = "Nothing";
            }


            //Choosing Retirement Age
            yearstilRet = (age - retirementStandard);
            if (yearstilRet % 2 == 0)
            {
                retire = retirementStandard + 5;
            }
            else
            {
                retire = retirementStandard + 10;
            }

            //Choosing Vacay
            if (numberOfSiblings < 0)
            {
                vacay = "Mount Doom";
            }
            else if (numberOfSiblings == 1)
            {
                vacay = "The Shire";
            }
            else if (numberOfSiblings == 2)
            {
                vacay = "The Isle of Avalon";
            }
            else if (numberOfSiblings == 3)
            {
                vacay = "The Kingdom of Hyrule";
            }
            else if (numberOfSiblings > 3)
            {
                vacay = "Magic Mountain";
            }
            else
            {
                vacay = "Nothing";
            }

            //Money in the bank
            if((birthMonth == 1) || (birthMonth == 2) || (birthMonth == 3) || (birthMonth == 4))
            {
                moneyInTheBank = 10000.00;
            }
            else if ((birthMonth == 5) || (birthMonth == 6) || (birthMonth == 7) || (birthMonth == 8))
            {
                moneyInTheBank = 1000.00;
            }
            else if ((birthMonth == 9) || (birthMonth == 10) || (birthMonth == 11) || (birthMonth == 12))
            {
                moneyInTheBank = 1000000.00;
            }
            else if (birthMonth >12)
            {
                moneyInTheBank = 50.00;
            }
            else
            {
                moneyInTheBank = 0.00;
            }


            Console.WriteLine("Would you like for me to tell you your fortune?");
            Console.WriteLine("Or you can exit my hut, never to return.");
            Console.WriteLine("Speak plainly, for time is short!");
            Console.WriteLine("DIVINE or EXIT ?");
            choice = Console.ReadLine().ToUpper();

            if (choice != "DIVINE" || choice != "EXIT")
            {
                Console.WriteLine("That seems like you said something wrong you silly child now what do you want DIVINE or EXIT ?");
                choice = Console.ReadLine().ToUpper();
            }

            if (choice == "DIVINE")
            {
                Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4}, and a {5}.", firstName, lastName, yearstilRet, moneyInTheBank, vacay, car);
            }
            else if (choice == "EXIT")
            {
                Console.WriteLine("No one like a quitter");
                Environment.Exit(0);
                
            }
            else
            {
                Console.WriteLine("I told you to speak plain. Now you've runined everything!");
            }
            


            

        }
            
        }

        
        }
    

