/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите первую цифру");
string numberFirstStr = Console.ReadLine();
int numberFirst = Convert.ToInt32(numberFirstStr);

Console.WriteLine("Введите вторую цифру");
string numberSecondtStr = Console.ReadLine();
int numberSecond = Convert.ToInt32(numberSecondtStr);

int x = numberFirst;
int stepen = numberSecond;
{
    Console.WriteLine("степень первого числа равна " + Math.Pow(x, stepen));
}