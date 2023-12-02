// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Challenge 1
// incorrect type match bool and string, removed quotes to make a proper boolean
// Optionally: could have changed type bool to type string
// original: bool amProgrammer = "true";
bool amProgrammer = true;

// integers cannot be decimal values, updated int to double
// optionally: could have removed the .9 to make an integer, but chose to make it a double to prevent data loss
// original" int Age = 27.9;
double Age = 27.9;

List<string> Names = new List<string>();
// This is not how values are added to a List
// Original: Names = "Monica";
// Correct syntax:
Names.Add("Monica");

Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
// This dictionary can only accept strings, but we tried to pass in an integer
// original: MyDictionary.Add("Hi there", 0);
MyDictionary.Add("Hi there", "0");

// This is a tricky one! Hint: look up what a char is in C#
// Single quotations are designated as chars in C#, but the datatype given is string
// Original: string MyName = 'MyName';
// We need to use double quotes for strings
string MyName = "MyName";


// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
// Get an index out of range error when this runs as originally written
// i cannot start at Numbers.Count because it will start out of range
// Added - 1 to i = Numbers.Count to correct the problem
for(int i = Numbers.Count - 1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    // This will not work before a foreach loop does not use an index
    // The correct syntax is: Console.WriteLine(i);
    // Original: Console.WriteLine(MoreNumbers[i]);
}

// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        // This will not work because num is representing the value, not the location
        // To update a value in a List, we need to update it from it's location
        // This is not possible without modifying the loop into a for loop to access the index
        // Original: num = 0;
        // Solution: rewrite as a for loop to access the index location to change the value
    }
}

string MyString = "superduberawesome";

Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
