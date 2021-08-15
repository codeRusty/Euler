using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Euler
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Enums.Problem selectedProblem = Enums.Problem.Problem1;

            int selection = 1;
            string nextStep = "Home";

            switch (selection)
            {
                case 1:
                    ListProblems(ref selectedProblem);

                    Console.Clear();

                    Executor exec = new Executor(Creator.Create(selectedProblem));

                    //Waiting for user Input to navigate
                    Console.ReadKey();

                    HandleNavigation(ref nextStep);

                    if (nextStep == "Home")
                        goto case 1;
                    else
                        break;
                case 2:
                    goto case 1;
                default:
                    break;

            }
        }

        private static void ListProblems(ref Enums.Problem selectedProblem)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                var values = Enum.GetValues(typeof(Enums.Problem));
                Console.WriteLine("Here are the list of  Euler problems, Select the one you want to execute.\n");

                foreach (Enums.Problem val in values)
                {
                    Type type = val.GetType();
                    var memInfo = type.GetMember(type.GetEnumName(val));
                    var descriptionAttribute = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

                    if (val == selectedProblem)
                    {
                        Console.Write(">>" + val.ToString());
                    }
                    else
                    {
                        Console.Write("  " + val.ToString());
                    }
                    if (descriptionAttribute != null)
                    {
                        Console.WriteLine(" - " + descriptionAttribute.Description);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                key = Console.ReadKey(true);
                if (key.Key.ToString() == "DownArrow")
                {
                    if ((Convert.ToInt16(selectedProblem) + 1) <= values.Length)
                        selectedProblem = (Enums.Problem)Convert.ToInt16(selectedProblem) + 1;
                }
                else if (key.Key.ToString() == "UpArrow")
                {
                    if ((Convert.ToInt16(selectedProblem) - 1) > 0)
                        selectedProblem = (Enums.Problem)Convert.ToInt16(selectedProblem) - 1;
                }
            }
            while (key.KeyChar != 13);
        }

        private static void HandleNavigation(ref string nextStep)
        {
            ConsoleKeyInfo wizKey;

            do
            {
                Console.Clear();
                foreach (var val in new List<string>() { "Home", "Exit" })
                {

                    if (val == nextStep)
                    {
                        Console.WriteLine(">>" + val.ToString());
                    }
                    else
                    {
                        Console.WriteLine("  " + val.ToString());
                    }
                }
                wizKey = Console.ReadKey(true);

                if (wizKey.Key.ToString() == "DownArrow" || wizKey.Key.ToString() == "UpArrow")
                {
                    nextStep = nextStep == "Home" ? "Exit" : "Home";
                }
            }
            while (wizKey.KeyChar != 13);


        }

    }
}
