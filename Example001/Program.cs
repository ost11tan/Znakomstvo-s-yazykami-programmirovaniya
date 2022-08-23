Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Результат = {0}",sqr);
Console.WriteLine($"Результат = {sqr}"); //$ нужен,чтоб захватывать переменную,а не строку


 // int result=Convert.ToInt32(Math.Pow(number, 2)); // конdертация из дабл в инт
Console.WriteLine($"Результат={Math.Pow(number,2)}");// вывод с помощью библиотеки math

