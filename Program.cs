// See https://aka.ms/new-console-template for more information
var lines = File.ReadAllLines("input.txt");

int[] left = [];
int[] right = [];
foreach (var line in lines)
{
    var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    left = [.. left, int.Parse(parts[0])];
    right = [.. right, int.Parse(parts[1])];
}

Array.Sort(left);
Array.Sort(right);

int result = 0;
for (int i = 0; i < left.Length; i++)
{
    result += Math.Abs(left[i] - right[i]);
}

Console.WriteLine(result);