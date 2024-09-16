using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        TaskController task = new TaskController();
        Console.WriteLine("Welcome to the main menu:");
        int input = 0;
        do
        {
            displayMenu();
            input = getChoice();
            executeUserChoice(input, task);
        }while (input != 0);

    }
    //display the main menu input choices to select by the user 
    public static void displayMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("1: Show the Program Price");
        Console.WriteLine("2: Calculate Total Package");
        Console.WriteLine("3: Iteration");
        Console.WriteLine("4: String Manipulation");
        Console.WriteLine("0: Quit");
    }

    //get the choices from the user 
    public static int getChoice()
    {
        Console.WriteLine("Enter your choice:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        return userInput;
    }


    public static void executeUserChoice(int choice, TaskController task)
    {
        switch (choice)
        {
            case 0:
                break;
            case 1:
                task.showProgramPriceByAge();
                break;
            case 2:
                task.calculateTotalPrice();
                break;
            case 3:
                task.loopIteration();
                break;
            case 4:
                task.fetchThirdWord();
                break;
            default:
                Console.WriteLine("Choose only 1 to 4 options");
                break;
        }
    }
}