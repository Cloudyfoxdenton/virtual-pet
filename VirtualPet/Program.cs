using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        public static Pet myPet = new Pet();
        public static string userPetname = String.Empty;

        static bool introDone = false;
        static bool quit = false;



        static void Main(string[] args)
        {
            do
            {
                SoundPlayer startLine = new SoundPlayer(@"C:\\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\VirtualPet\VirtualPet\sounds\unused.wav");
                {
                    startLine.PlaySync();
                }
                Console.WriteLine("Hello!");
                Console.WriteLine("You are now taking the first step to the amazing world of pet ownership");
                Console.WriteLine("We have analyzed your dreams and figured out your dream pet.");
                Console.WriteLine("You will be meeting him today!");

                Console.WriteLine("press enter to continue");


                Console.ReadKey();
                Console.WriteLine("(o___o) !!! ");
                Console.WriteLine("There he is!! Any idea what you're going to name him?");
                Console.WriteLine("Type in a name!");
                userPetname = Console.ReadLine();

                Console.WriteLine("Awesome! " + userPetname + " seems happy to see you!!!");
                Console.WriteLine("press enter to continue");
                Console.ReadKey();

                Console.WriteLine("(^__^) yeey!!! ");
                Console.WriteLine(" His life is rather short and fleeting.");
                Console.WriteLine("He's looking to you for guidance and protection.");
                Console.WriteLine("The length of his life is dependent on you!");
                Console.WriteLine("press enter to continue");
                Console.ReadKey();

                Console.WriteLine("Good luck and have fun!!");

                introDone = true;

            } while (introDone == false);

            Console.Clear();

            string[] options = new string[] { "1. feed", "2. Clean up after", "3. Play with! ", "4. Kick!"," 5. Put to bed!", " 0. Exit application" };

            Console.WriteLine("(^___^) " + userPetname + "Can't wait to play with you!!");
            Console.WriteLine("Here are your options!: ");

            for (int i = 1; i < (i + 2); i++)
            {
                Console.WriteLine("Hunger " + myPet.petHunger);
                Console.WriteLine("Dirty " + myPet.petPoop);
                Console.WriteLine("Boredom " + myPet.petBoredom);
                Console.WriteLine("Exhaustion: " + myPet.petEnergy);
                Console.WriteLine("Lifeforce: " + myPet.petAge);
                

                foreach (string optionsList in options)
                {
                    Console.WriteLine(optionsList);
                }

                int userOption = int.Parse(Console.ReadLine());

                switch (userOption)
                {
                    case 0:
                        Console.WriteLine("Alrighty! Thank you for playing! Bye bye!");
                        Console.WriteLine("Press enter to exit the program!");
                        Console.ReadKey();
                        quit = true;
                        break;
                    case 1:
                        Console.WriteLine("You feed " + userPetname);
                        if (myPet.petHunger <= 90)
                        {
                            Console.WriteLine("(^___^) Thank for food!!! ");

                            SoundPlayer eating = new SoundPlayer(@"C:\\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\VirtualPet\VirtualPet\sounds\Eat.wav");
                            {
                                eating.PlaySync();
                            }
                            myPet.Feed();
                            break;
                        }
                        else
                        {
                            Console.WriteLine(userPetname + " doesn't seem hungry.. I'd wait a while.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("You clean up after" + userPetname);
                        if (myPet.petPoop >= 0)
                        {
                            Console.WriteLine("(^w^) Thank for clean!!");
                            SoundPlayer cleanUp = new SoundPlayer(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\VirtualPet\VirtualPet\sounds\Clean.wav");
                            {
                                cleanUp.PlaySync();
                            }
                            myPet.Clean();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I don't think it can get much cleaner than this...");
                        }
                        break;
                    case 3:
                        Console.WriteLine("You play with " + userPetname);

                        if (myPet.petBoredom >= 0)
                        {
                            Console.WriteLine("( ^w^ ) So much fun!!! ");
                            SoundPlayer playTime = new SoundPlayer(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\VirtualPet\VirtualPet\sounds\Play.wav");
                            {
                                playTime.PlaySync();
                            }
                            myPet.Play();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("He seems uninterested...");
                        }
                        break;
                    case 4:
                        Console.WriteLine("You kick " + userPetname + " !" + " Why would you do that?!?");
                        Console.WriteLine("(O___O;) ");
                        myPet.Kick();
                        break;

                    case 5:
                        Console.WriteLine("You tuck " + userPetname + " in bed...");
                        if (myPet.petEnergy >= 70)
                        {
                            Console.WriteLine(" But he isn't tired... ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(" He looks so comfy!!  ");
                            SoundPlayer sleepyTime = new SoundPlayer(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\VirtualPet\VirtualPet\sounds\sleepytime.wav");
                            {
                                sleepyTime.PlaySync();
                            }
                            myPet.ToBed();
                        }
                        break;

                    default:
                        Console.WriteLine("You decide to do nothing? " + userPetname + " seems confused but content");
                        Console.WriteLine("Please try using one of the available options?");
                        break;
                }

                if (quit == true)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    myPet.petAge -= 5;
                }

                if (myPet.petHunger <= 0)
                {
                    SoundPlayer deathStarve = new SoundPlayer(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\VirtualPet\VirtualPet\sounds\Diedstarvation.wav");
                    {
                        deathStarve.PlaySync();
                    }
                    Console.Clear();
                    Console.WriteLine("Uh oh... he isn't moving. I think he may have starved to death...");
                    Console.WriteLine("Was giving you a pet a bad idea?");

                    break;
                }

                if (myPet.petAge <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Like most good things, your pet's life has come to an end.");
                    Console.WriteLine("He truly enjoyed his time with you!");
                    Console.WriteLine("Hopefully, his memory will live on within your heart forever!");
                    Console.WriteLine("press enter to quit");
                    break;
                }


            }

           
          
        }
    }
}
