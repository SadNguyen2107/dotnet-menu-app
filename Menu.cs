using System.Reflection.Metadata;

namespace Program
{
    public enum Choice
    {
        Exit,
        DrawTriangle,
        DrawSquare,
        DrawRectangle,
        AllChoices
    }
    public class Menu
    {
        public static void DrawTriangle()
        {
            Console.WriteLine("Draw the triangle");
            Console.WriteLine("******");
            Console.WriteLine("*****");
            Console.WriteLine("****");
            Console.WriteLine("***");
            Console.WriteLine("**");
            Console.WriteLine("*");
        }

        public static void DrawSquare()
        {
            Console.WriteLine("Draw the square");
            Console.WriteLine("* * * * * *");
            Console.WriteLine("* * * * * *");
            Console.WriteLine("* * * * * *");
            Console.WriteLine("* * * * * *");
            Console.WriteLine("* * * * * *");
            Console.WriteLine("* * * * * *");
        }

        public static void DrawRectangle()
        {
            Console.WriteLine("Draw the rectangle");
            Console.WriteLine("* * * * * *");
            Console.WriteLine("* * * * * *");
            Console.WriteLine("* * * * * *");
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");

        }

        public static Choice GetInput()
        {
            Choice choice = Choice.Exit;

            // Get User input
            // Range From Exit -> DrawRectangle
            Int32 choice_int = 0;
        askChoiceInput:
            Console.Write("Enter your choice: ");
            bool isNum = Int32.TryParse(Console.ReadLine(), out choice_int);
            if (!isNum || (Choice)choice_int >= Choice.AllChoices)
            {
                Console.Clear();        // Clear Terminal
                Console.WriteLine("Invalid Input!");
                PrintMenu();
                goto askChoiceInput;
            }

            choice = (Choice)choice_int;
            return choice;
        }

        public static void HandleChoice(Choice choice)
        {
            switch (choice)
            {
                case Choice.DrawTriangle:
                    DrawTriangle();
                    break;

                case Choice.DrawSquare:
                    DrawSquare();
                    break;

                case Choice.DrawRectangle:
                    DrawRectangle();
                    break;

                case Choice.Exit:
                    // Exit The Program 
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }

        }
    }
}