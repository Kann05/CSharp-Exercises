public partial class Program
{
    private static void Main(string[] args)
    {
        string fromWord = "";
        string toWord = "";
        string replaceText;
        int fromIndex = 0;
        int toIndex = 0;
        string insertText = "";
        string action;

        System.Console.Write("Write a sentence: ");
        string text = Console.ReadLine();

        while (true)
        {
            System.Console.Write("Enter 1 of those actions to change the text (Remove, Insert, Replace): ");
            action = Console.ReadLine();

            if (action == "Remove")
            {
                System.Console.Write("Enter from Index to start removing to: ");
                fromIndex = Convert.ToInt32(Console.Read());
                System.Console.Write("Enter to Index to start removing to: ");
                toIndex = Convert.ToInt32(Console.ReadLine());
                break;
            }

            if (action == "Insert")
            {
                System.Console.Write("Enter from Index to start Inserting to: ");
                fromIndex = Convert.ToInt32(Console.Read());
                System.Console.Write("Enter the text to insert: ");
                insertText = Console.ReadLine();
                break;
            }

            if (action == "Replace")
            {
                System.Console.Write("Enter the word you want to replace: ");
                fromWord = Console.ReadLine();
                System.Console.Write("Enter the replacer word: ");
                toWord = Console.ReadLine();
                break;
            }

            else 
            {
                System.Console.WriteLine("You didnt enter a valid action, TRY AGAIN !");
            }
        }

        switch (action)
        {
            case "Remove":
                replaceText = text.Remove(fromIndex, toIndex);
                System.Console.WriteLine(replaceText);
            break;
            
            case "Insert":
                replaceText = text.Insert(fromIndex, insertText);
                System.Console.WriteLine(replaceText);
            break;

            case "Replace":
                replaceText = text.Replace(fromWord, toWord);
                System.Console.WriteLine(replaceText);
            break;
        }

    }
}