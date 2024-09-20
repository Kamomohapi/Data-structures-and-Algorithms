// See https://aka.ms/new-console-template for more information
using Data_Structures_and_Algorithms.ADT;

/*Console.WriteLine("Hello, World!");

Pokemon pokemon = new Pokemon();

pokemon.Name = "Motaung";
pokemon.Exp = 1012;
Console.WriteLine("The name is " + pokemon.Name + " and the exp level is " + pokemon.Exp);

int[] myArray = { 7, 12, 9, 4, 11 };
int minVal = myArray[0];

    foreach (int i in myArray)
    {
        if (i < minVal)
        {
            minVal = i;
        }
    }
 Console.WriteLine("Lowest value: " + minVal);


int[] myArr = { 64, 34, 25, 12, 22, 11, 90, 5 };
int n = myArr.Length;*/

//Insert at the end of the array

int [] arr  = new int[6];

int length = 0;

for (int i = 0; i < 3; i++)
{
    arr[length] = i + 1;
    length++;
}

/*arr[length] = 19940;
length++;*/

//Inserting at the start of an array

for(int i = 3; i >= 0; i--)
{
    arr[ i + 1] = arr[i]; // moving over all the values
}
arr[0] = 19940;
int val =  0;
