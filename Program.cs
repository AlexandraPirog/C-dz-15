Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<8)
{
   if (num==6|| num==7)
   {
    Console.WriteLine("Выходной");
   }
   else
   {
    System.Console.WriteLine("Будний день");
   }
}
else
{
    System.Console.WriteLine("Ошибка");
}








/*Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = (num<8 && num == 6 && num == 7)? "Выходной":"Будний день";
System.Console.WriteLine(result);*/

// Во втором варианте попыталась сделать через string, но он не учитывает вариант, когда пользователь вводит число больше 7, захотелось показать его, потому что решения какие-то однотипные получились. Возможно есть решение через массив, но пока что в C# я с ними не разобралась :))

/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/