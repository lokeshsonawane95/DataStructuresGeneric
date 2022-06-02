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
                Console.WriteLine("2. Ordered List");
                Console.WriteLine("3. Balanced Parentheses");
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
                    case 2:
                        int[] numbers = { 6, 5, 9, 8, 7, 1, 0, 2, 3, 4 };
                        Lists<int> list2 = new Lists<int>();
                        foreach (int num in numbers)
                        {
                            //Console.Write(s);
                            list2.OrderedList(num);
                        }
                        list2.Display();
                        Console.Write("Enter the value you want to search : ");
                        int searchValue = Convert.ToInt32(Console.ReadLine());
                        list2.Search(searchValue);
                        if (list2.flag == 0)
                        {
                            Console.WriteLine("Inserting \"" + searchValue + "\" in the linked list");
                            list2.OrderedList(searchValue);
                        }
                        if(list2.flag == 1)
                        {
                            list2.DeleteValue(searchValue);
                        }
                        list2.Display();
                        break;
                    case 3:
                        BalancedParentheses<char> balancedParantheses = new BalancedParentheses<char>();
                        Console.WriteLine("Enter the expression containing parentheses i.e. ( and ) : ");
                        string expression = Console.ReadLine();
                        char[] expressionArray = expression.ToCharArray();
                        for (int i = 0; i < expressionArray.Length; i++)
                        {
                            if (expressionArray[i] == '(')
                            {
                                balancedParantheses.Push(expressionArray[i]);
                                balancedParantheses.Display();
                            }
                            if (expressionArray[i] == ')')
                            {
                                if (balancedParantheses.Peek() == ' ')
                                {
                                    Console.WriteLine("Entered expression \"" + expression + "\" does not contains balanced parentheses");
                                    return;
                                }
                                if (balancedParantheses.Peek() == '(')
                                {
                                    balancedParantheses.Pop();
                                    balancedParantheses.Display();
                                }
                            }
                        }
                        //After all the closing parentheses are finished i.e. )
                        if (balancedParantheses.Peek() == '(')
                        {

                            Console.WriteLine("Entered expression \"" + expression + "\" does not contains balanced parentheses");
                        }
                        else
                        {
                            Console.WriteLine("Entered expression \"" + expression + "\" contains balanced parentheses");
                        }
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