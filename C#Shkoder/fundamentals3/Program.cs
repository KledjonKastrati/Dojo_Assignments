// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.ComponentModel;
using System.Runtime.InteropServices;

List<string> lista = new List<string>(){
    "Harry", "Steve", "Carla", "Jeanne"
};
List<string> lista2 = new List<string>(){
    "Harry2", "Steve", "Carla2", "Jeanne2"
};

// nje funksion qe MERR nje list dhe kthen asgje, por printon cdo item te listes


static void PrintoListen(List<string> listaQeDoMerret){

    foreach (var item in listaQeDoMerret)
    {
        System.Console.WriteLine(item);
    }
}
static void PrintoListenInt(List<string> listaQeDoMerret){

    foreach (var item in listaQeDoMerret)
    {
        System.Console.WriteLine(item);
    }
}

PrintoListen(lista);
PrintoListen(lista2);
PrintoListenInt(lista2);


// krijo nje funksion qe merr nje liste me int, kthen shume (int) dhe gjen kte shumen

static int GjejShumen(List<int> listaMeInt){
    int sum = 0;

    foreach (var item in listaMeInt)
    {
        sum+= item;
    }


    return sum;
}

List<int>  TestIntList = new List<int>() {2,7,12,9,3};

List<int>  TestIntList2 = new List<int>() {2,7,12,9,3,5};
// int vleraQeKthehet = 33
int vleraQeKthehet =GjejShumen(TestIntList);
// vlera2 = 38
int vlera2= GjejShumen(TestIntList2);

// System.Console.WriteLine(3);
System.Console.WriteLine(vleraQeKthehet);

// krijoni nje liste qe merr nje liste me int, gjej vleren me te madhe dhe e kthen ate 


static int FindMax(List<int> listaQeMerret){

    int Max= listaQeMerret[0];

    foreach (var item in listaQeMerret)
    {
        if (item > Max)
        {
            Max = item;
        }
    }
    return Max;

}
// int vleraMaksimum = 12;
   int vleraMaksimum = FindMax(TestIntList2);

   System.Console.WriteLine(vleraMaksimum);



static List<int> SquareValues(List<int> IntList)
{



    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i]= IntList[i]* IntList[i];
    }
    return IntList;


}




List<int> vektoriNeKatror=SquareValues(TestIntList);
//  PrintoListenInt(vektoriNeKatror);
foreach (var item in vektoriNeKatror)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine(vektoriNeKatror);

//  krijo nje funksion qe merr list me int dhe zevendeson cdo vlere negative me 0, dhe kthen listen 
static List<int> zevendesoNegativet(List<int> listaTest){

    for (int i = 0; i < listaTest.Count; i++)
    {
        if (listaTest[i]<0)
        {
            listaTest[i]=0;
        }
    }
    
    return listaTest;

}

List<int> TestIntArray= new List<int>(){-1,2,3,-4,5};

List<int> listaZevendesuar = zevendesoNegativet(TestIntArray);

// PrintoListenInt(listaZevendesuar);
foreach (var item in listaZevendesuar)
{
    System.Console.WriteLine(item);
}

// krijo nje funks qe merr dictionary <string,string> dhe printo cdo value kthen void 

static void PrintDict(Dictionary<string,string> dictValue){

    foreach (var item in dictValue)
    {
        System.Console.WriteLine($"key is : {item.Key} and value is {item.Value}" );
    }
}

Dictionary<string,string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName","Tony Stark");
TestDict.Add("Powers", "Money and intelligence");


PrintDict(TestDict);

// krijo nje funks qe mer nje dictionary<string, string> dhe kthen void dhe printon key e nje vlere te caktuar

static void FindKey(Dictionary<string,string> dictValue,string fjala){

    foreach (var item in dictValue)
    {
        
        if (item.Value==fjala)
        {
            System.Console.WriteLine($"value : {fjala} eshte tek key {item.Key}");
        }
    }
}
FindKey(TestDict,"Iron Man2");

   static Dictionary<string,int> GenerateDictionary(List<string> listaMeFjale, List<int> listaMeInt){
    Dictionary<string,int> DictionaryQeDoKrijohet = new Dictionary<string,int>();

    for (int i = 0; i < listaMeFjale.Count; i++)
    {
        // listaQeDoKrijohet.Add("Harry2".-1)
        DictionaryQeDoKrijohet.Add(listaMeFjale[i],listaMeInt[i]);
    
    }
    return DictionaryQeDoKrijohet;

   }

   Dictionary<string,int> newDictionary = GenerateDictionary(lista2,TestIntArray);

   foreach (var item in newDictionary)
   {
    System.Console.WriteLine($"{item.Key} me vlere {item.Value}");
   }

