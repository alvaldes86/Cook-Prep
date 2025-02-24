using Cook_Prep;
using System.Runtime.CompilerServices;


//Console.WriteLine("Enter a word to check if it a palindrome");


//reverse string
string input = "Hello";

string output = string.Empty;

for (int i = input.Length - 1; i >= 0; i--)
{
    output += input[i];

}

//if(output.ToLower() == input.ToLower())
//{
//    Console.WriteLine("the word is a palidrome");
//    Console.WriteLine($"You entered {input}");
//    Console.WriteLine($"Reversed is {output}");
//}
//else
//{
//    Console.WriteLine("Try another word");
//}

ArrayAlgorithims utility = new ArrayAlgorithims();



string[] names = { "alain", "kire", "yoe", "alain", "pete", "kire" };

//Console.WriteLine(utility.SequentialSearch(names, "yoe"));

//Console.WriteLine($"the name was found on position {utility.SequentialSearch(names, "yoe")}");


int[] numbers = { 77, 2, 3, 4, 2, 15, 3 };

//Console.WriteLine($"the name was found on position {arrAlg.SequentialSearch(numbers, 2)}");


int[] newCopy = utility.CopyArray(numbers);
int[] arrayDifferetn = { 1, 2, 5, 1, 9 };

//Console.WriteLine(arrAlg.CompareArrays(newCopy, arrayDifferetn) ? "The arrays are equal" : "Arrays are different");

//Console.WriteLine(utility.Sum(arrayDifferetn));

//Console.WriteLine(utility.Average(numbers));


Console.WriteLine( numbers.Sum());
Console.WriteLine(numbers.Average());

Console.WriteLine(utility.SequentialSearch(names, "yoe"));
Console.WriteLine(utility.FindLowest(numbers));

Console.WriteLine(utility.SelectionSort(numbers));