string[] array;
Console.WriteLine("Введите элементы массива через пробел и нажмите Enter: ");
var line = Console.ReadLine();
array = line!.Split(" ");
string[] resultArray = new string[array.Length];
var count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[count] = array[i];
        count++;
    }
}

if (count == 0)
{
    Console.WriteLine("Массив не содержит элементов," +
    "\nудовлетворяющих условию задачи.");
}
else
{
    Console.WriteLine("Искомый массив: " + " " + string.Join(" ", resultArray));
}