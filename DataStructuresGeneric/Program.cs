namespace DataStructuresGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Data Structures Program using Generics");

            while (true)
            {
                Console.WriteLine("\n1. Unordered List Generic");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string unorderedString = "Read the Text from a file split it into words and arrange it as Linked List Take a user input to search a Word in the List If the Word is not found then add it to the list and if it found then remove the word from the List In the end save the list into a file";
                        string[] strings = unorderedString.Split(' ');
                        Lists<string> list1 = new Lists<string>();
                        foreach (string s in strings)
                        {
                            list1.Append(s);
                        }
                        list1.Display();
                        Console.Write("Enter the word you want to search : ");
                        string search = Console.ReadLine();
                        list1.Search(search);
                        if (list1.flag == 0)
                        {
                            Console.WriteLine("\nAdding \"" + search + "\" in the linked list\n");
                            list1.Append(search);
                        }
                        if (list1.flag == 1)
                        {
                            list1.DeleteValue(search);
                        }
                        list1.Display();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
            }
        }
    }
}