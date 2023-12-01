
int[] intArray = new int[] {0,1,2,3,4,5,6,7,8,9};

string[] namesArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};

bool[] boolArray = new bool[10];
for(int i = 0; i < boolArray.Length; i++)
{
    if(i % 2 == 0)
    {
        boolArray[i] = true;
    } else {
        boolArray[i] = false;
    }
}

List<string> Flavors = new List<string>();
Flavors.Add("Vanilla");
Flavors.Add("Strawberry");
Flavors.Add("Chocolate");
Flavors.Add("Mint Chip");
Flavors.Add("Cookies and Cream");
Flavors.Add("Orange Cream");

Console.WriteLine($"Length of Flavors List: {Flavors.Count}");

Console.WriteLine($"Third flavor in the List: {Flavors[2]}");

Flavors.RemoveAt(2);

Console.WriteLine($"Length of Flavors List: {Flavors.Count}");

Dictionary<string,string> myDictionary = new Dictionary<string,string>();

Random rand = new Random();
for(int i = 0; i < namesArray.Length; i++)
{
    myDictionary.Add(namesArray[i], Flavors[rand.Next(0,Flavors.Count)]);
}

foreach(KeyValuePair<string,string> entry in myDictionary)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}