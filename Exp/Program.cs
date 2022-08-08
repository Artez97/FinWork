string[] array;
Console.WriteLine("Введите строки через пробел");
string row = Console.ReadLine();
array = row.Split(' ');
var res = new string[array.Length];
var size = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        res[size] = value;
        size++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, res, 0, size));
Console.ReadKey(true);
