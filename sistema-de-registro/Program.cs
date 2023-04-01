internal class Program
{
    private static void Main(string[] args)
    {
        string[] userName = new string[10] { "Diego", "", "", "", "", "", "", "", "", "" };

        int arrayCurrent = 1;
        string userType;

        Console.WriteLine("*********** Welcome to the C# restaurant ***********");
        while (arrayCurrent < 10)
        {
       
            Console.WriteLine("\nBot: Are you registered user ?  Write 'yes', or write 'no' to register");
            userType = Console.ReadLine();

            switch (userType)
            {
                case "yes" or "y":
                    Console.WriteLine("Hello, you are a registered user, please enter your exact username");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you selected is: " + userToSearch);

                    int index = Array.IndexOf(userName, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("!!!User not found, try again or register");

                    }
                    else
                    {
                        Console.Write("Welcome {0}, it's a pleasure to give you food. \n \n", userName[index]);
                    }
                break;
                case "no" or "n":
                    Console.WriteLine("Please write your username ");
                    userName[arrayCurrent] = Console.ReadLine();
                    Console.WriteLine("Your user has been saved succesfull \n"
                         + "Your User Name is: {0}", userName[arrayCurrent]);
                    arrayCurrent++;
                break;
            }
        }
        Console.WriteLine("The restaurant is full, try again next year.");
        int auxIndex = 0;
        foreach (string element in userName)
        {
            Console.WriteLine("User number: {0} and username: {1}.", auxIndex + 1, element);
            auxIndex++;
        } ;
        Environment.Exit(0);
    }
}