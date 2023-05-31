string? userInput;

static void DisplayResults(string results)
{
    Console.WriteLine($"\noutput: {results}");
}

static string? DisplayMessageAndCaptureInput()
{
    Console.WriteLine("\nType Input:");
    return Console.ReadLine();
}


static string ReverseString(string? input)
{
    char[] arrayOfUnicodeChars = input!.ToArray();
    Array.Reverse(arrayOfUnicodeChars);
    return new string((char[])arrayOfUnicodeChars);
}

static string IsAPalindrome(string? input) 
{ 
    string? reversedString = ReverseString(input);

    if (reversedString == input) 
        return "Yes";
    return "No";

}

static string ReverseWordsOrder(string? input) 
{
    string[] stringArray = input!.Split(" ");
    Array.Reverse(stringArray);
    return string.Join(" ", stringArray);
}

static string ReverseEachWord(string? input) 
{
    List<string> reversedStrings = new();
    string[] stringArray = input!.Split(" ");

    foreach (var item in stringArray)
    {
        reversedStrings.Add(ReverseString(item));
    }

    return string.Join(" ", reversedStrings);
}

static string CountCharacterOccurence(string? input) 
{
    string results = "\n";
    List<char> charToCompare = new();

    string trimedString = input!.Replace(" ","");

    foreach (var item in trimedString)
    {
        if (!charToCompare.Contains(item))
        {
            charToCompare.Add(item);
            results += $"{item} - {trimedString.Count(x => x == item)}\n";
        }
    }
    return results;
}

Console.WriteLine(
"Hello, what would you like to do?\n" +
"1. Reverse a string?\n" +
"2. Check if a string is a Palindrome?\n" +
"3. Reverse the order of words?\n" +
"4. Reverse each word?\n" +
"5. Count the occurence of characters?\n\n" +
"Please choose between 1-5");

switch (Console.ReadLine())
{
    case "1":
        userInput = DisplayMessageAndCaptureInput();
        DisplayResults(ReverseString(userInput));
        break;

    case "2":
        userInput = DisplayMessageAndCaptureInput();
        DisplayResults(IsAPalindrome(userInput));
        break;

    case "3":
        userInput = DisplayMessageAndCaptureInput();
        DisplayResults(ReverseWordsOrder(userInput));
        break;

    case "4":
        userInput = DisplayMessageAndCaptureInput();
        DisplayResults(ReverseEachWord(userInput));
        break;

    case "5":
        userInput = DisplayMessageAndCaptureInput();
        DisplayResults(CountCharacterOccurence(userInput));
        break;

    default:
        userInput = DisplayMessageAndCaptureInput();
        DisplayResults(IsAPalindrome(userInput));
        break;
}
