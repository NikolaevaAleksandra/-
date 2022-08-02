using System;
using static System.Console;
Clear();
string[] array =
{
    "n",
    "65",
    "hey",
    "-957",
    "party",
    "1"
};
var result = new string[array.Length];
var realsize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realsize] = value;
        realsize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realsize));
