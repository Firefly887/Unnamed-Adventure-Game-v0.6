using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdvGameLibV2
{
    public class MainLogic
    {
        bool gameComplete;
        byte verbByte;
        byte nounByte;
        public static ArrayList inventory = new ArrayList();
        public static ArrayList inventoryUsed = new ArrayList();
        Verb verb = new Verb();
        Noun noun = new Noun();
        Go go = new Go();
        Use use = new Use();
        Talk talk = new Talk();
        Search search = new Search();
        Shoot shoot = new Shoot();
        string command = "";
        string[] instruction;
        int chapter;
        public static bool isHoleChap1;

        public MainLogic()
        {
            chapter = 1;
        }
        /*public int ChapterProp
        {
            get { return chapter; }
            set { chapter = value; }
        } */
        
        public void CheckInventory()
        {
            Clear();
            if (inventory.Count == 0)
                WriteLine("I have nothing in my inventory!");
            else
            {
                WriteLine("In my inventory I currently have:");
                foreach (string item in inventory)
                {
                    WriteLine($"{item}\n");
                }
            }
        }

        public void _Main()
        {
            if (chapter == 1)
            {
                WriteLine("I woke up in a concrete room with no windows or doors...");
                WriteLine("All that was in this room is a mirror and a table to keep me company...\nHow did I get out??");
            }
            while (gameComplete == false)
            {
                command = ReadLine();
                if (command.ToLower() == "quit")
                    goto EndOfLogic;
                instruction = command.Split(' ');
                if (Enum.TryParse(instruction[0], true, out verb))
                {
                    if (Enum.IsDefined(typeof(Verb), verb))
                    {
                        if (Enum.TryParse(instruction[instruction.Count() - 1], true, out noun))
                        {
                            if (Enum.IsDefined(typeof(Noun), noun))
                            {
                                noun = (Noun)Enum.Parse(typeof(Noun), instruction[instruction.Count() - 1], true);
                                verb = (Verb)Enum.Parse(typeof(Verb), instruction[0], true);
                                verbByte = (byte)verb;
                                nounByte = (byte)noun;
                                switch (verbByte)
                                {
                                    case 1:
                                        chapter = go._Go(nounByte, chapter);
                                        break;
                                    case 2:
                                    case 8:
                                    case 10:
                                        use._Use(nounByte, verbByte, chapter);
                                        break;
                                    case 3:
                                        talk._Talk(nounByte, chapter);
                                        break;
                                    case 9:
                                    case 7:
                                        search._Search(nounByte, chapter);
                                        break;
                                    case 6:
                                        if (nounByte == 6)
                                            CheckInventory();
                                        else
                                            WriteLine("I have nothing i can check.");
                                        break;
                                    case 5:
                                    case 4:
                                        shoot._Shoot(nounByte, chapter);
                                        break;
                                    default:
                                        WriteLine("I'm not sure what I am doing here...");
                                        break;
                                }
                            }
                        }
                        else
                            WriteLine("I don't know what you want me to do\nHINT!: pay attention to your surroundings to find out what you might have gotten wrong.");
                    }
                }
                else
                    WriteLine("I didn't quite hear what you said at first...\nTry again.\nHINT!: check the tutorial document for accepted verb parameters.");
            }
        EndOfLogic:
            ReadKey();
        }
    }
}
