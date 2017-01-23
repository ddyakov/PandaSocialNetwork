using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaSocialNetworkApplication
{
    using PandaSocialNetworkLibrary;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("WELCOME TO THE PANDA SOCIAL NETWORK!");
            PandaSocialNetwork pandaSocialNetwork = new PandaSocialNetwork();

            List<string> help = new List<string>();
            help.Add("<--------------!!!----------------->");
            help.Add("help: display the useful commands");
            help.Add("addPanda: creata a panda and add it to the social network");
            help.Add("hasPanda: check if the panda is in the social network");
            help.Add("makeFriends: make pandas friends ");
            help.Add("areFriends: check if pandas are friends");
            help.Add("friendsOf: display the given panda's friends");
            help.Add("connectionLevel: display the connection level between pandas");
            help.Add("areConnected: check if pandas are connected");
            help.Add("genderCount: display the number of gender pandas");
            help.Add("clear: clear the console");
            help.Add("exit: exit the social network");
            help.Add("<--------------!!!----------------->");

            Console.WriteLine("Type help to begin!");

            do
            {
                string input = Console.ReadLine();
                string[] commands = input.Split(' ');

                switch (commands[0])
                {
                    case "help":
                        Console.WriteLine();
                        foreach (var helpCommand in help)
                        {
                            Console.WriteLine(helpCommand);
                        }
                        Console.WriteLine();
                        break;
                    case "addPanda":
                        {
                            Panda panda = null;

                            if (commands[3] == "Male" || commands[3] == "male")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Male);
                            }
                            else if (commands[3] == "Female" || commands[3] == "female")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Female);
                            }
                            else
                            {
                                throw new ArgumentException("gender must not be null");
                            }

                            pandaSocialNetwork.AddPanda(panda);
                            break;
                        }
                    case "hasPanda":
                        {
                            Panda panda = null;

                            if (commands[3] == "Male" || commands[3] == "male")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Male);
                            }
                            else if (commands[3] == "Female" || commands[3] == "female")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Female);
                            }
                            Console.WriteLine(pandaSocialNetwork.HasPanda(panda));
                            break;
                        }
                    case "makeFriends":
                        {
                            Panda panda = null;
                            Panda panda2 = null;

                            if (commands[3] == "Male" || commands[3] == "male")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Male);
                            }
                            else if (commands[3] == "Female" || commands[3] == "female")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Female);
                            }

                            if (commands[6] == "Male" || commands[6] == "male")
                            {
                                panda2 = new Panda(commands[4], commands[5], GenderType.Male);
                            }
                            else if (commands[6] == "Female" || commands[6] == "female")
                            {
                                panda2 = new Panda(commands[4], commands[5], GenderType.Female);
                            }

                            pandaSocialNetwork.MakeFriends(panda, panda2);
                            break;
                        }
                    case "areFriends":
                        {
                            Panda panda = null;
                            Panda panda2 = null;

                            if (commands[3] == "Male" || commands[3] == "male")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Male);
                            }
                            else if (commands[3] == "Female" || commands[3] == "female")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Female);
                            }

                            if (commands[6] == "Male" || commands[6] == "male")
                            {
                                panda2 = new Panda(commands[4], commands[5], GenderType.Male);
                            }
                            else if (commands[6] == "Female" || commands[6] == "female")
                            {
                                panda2 = new Panda(commands[4], commands[5], GenderType.Female);
                            }

                            Console.WriteLine(pandaSocialNetwork.AreFriends(panda, panda2));
                            break;
                        }
                    case "friendsOf":
                        {
                            Panda panda = null;

                            if (commands[3] == "Male" || commands[3] == "male")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Male);
                            }
                            else if (commands[3] == "Female" || commands[3] == "female")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Female);
                            }

                            List<Panda> friendsOf = pandaSocialNetwork.FriendsOf(panda);
                            Console.WriteLine(string.Join(", ", friendsOf));
                            break;
                        }
                    case "connectionLevel":
                        {
                            Panda panda = null;
                            Panda panda2 = null;

                            if (commands[3] == "Male" || commands[3] == "male")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Male);
                            }
                            else if (commands[3] == "Female" || commands[3] == "female")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Female);
                            }

                            if (commands[6] == "Male" || commands[6] == "male")
                            {
                                panda2 = new Panda(commands[4], commands[5], GenderType.Male);
                            }
                            else if (commands[6] == "Female" || commands[6] == "female")
                            {
                                panda2 = new Panda(commands[4], commands[5], GenderType.Female);
                            }

                            Console.WriteLine(pandaSocialNetwork.ConnectionLevel(panda, panda2));
                            break;
                        }
                    case "areConnected":
                        {
                            Panda panda = null;
                            Panda panda2 = null;

                            if (commands[3] == "Male" || commands[3] == "male")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Male);
                            }
                            else if (commands[3] == "Female" || commands[3] == "female")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Female);
                            }

                            if (commands[6] == "Male" || commands[6] == "male")
                            {
                                panda2 = new Panda(commands[4], commands[5], GenderType.Male);
                            }
                            else if (commands[6] == "Female" || commands[6] == "female")
                            {
                                panda2 = new Panda(commands[4], commands[5], GenderType.Female);
                            }

                            Console.WriteLine(pandaSocialNetwork.AreConnected(panda, panda2));
                            break;
                        }
                    case "genderCount":
                        {
                            Panda panda = null;

                            if (commands[3] == "Male" || commands[3] == "male")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Male);
                            }
                            else if (commands[3] == "Female" || commands[3] == "female")
                            {
                                panda = new Panda(commands[1], commands[2], GenderType.Female);
                            }

                            GenderType g = GenderType.Male;

                            if (commands[5].ToLower() == "male")
                            {
                                g = GenderType.Male;
                            }
                            else if(commands[5].ToLower() == "female")
                            {
                                g = GenderType.Female;
                            }

                            Console.WriteLine(pandaSocialNetwork.HowManyGenderInNetwork(int.Parse(commands[4]), panda, g));
                            break;
                        }
                    case "clear":
                    case "cls":
                        Console.Clear();
                        break;
                    case "exit":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid command!");
                        break;
                }
            } while (true);
        }
    }
}
