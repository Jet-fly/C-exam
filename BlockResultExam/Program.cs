System.Console.Write("Enter string: ");
string? str = Console.ReadLine();

// Делим введённые данные на массив строк.
char[] delimeters = { ' ', ',', '.' };
string[] strArray = str.Split(delimeters);

// Вывод массива.
for (int i = 0; i < strArray.Length; i++)
{
    System.Console.WriteLine($"strArray[{i}] = " + strArray[i]);
}