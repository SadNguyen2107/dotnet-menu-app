namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Choice choice = Choice.AllChoices;
            do
            {
                // Print Menu
                Menu.PrintMenu();

                // Get User Choice Input
                choice = Menu.GetInput();

                // Handle Choice Input
                Menu.HandleChoice(choice);
            } while (choice != Choice.Exit);
        }
    }
}