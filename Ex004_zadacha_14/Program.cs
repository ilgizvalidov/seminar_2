// задача 14. Написать программу, которая принимает на вход число и проверяет его на кратность одновременно 7 и 23


void Kraton (int arg1)
{
    if (arg1 % 7 == arg1 % 23) Console.WriteLine ("да"); // если число делится на 7 и 23 без остатка (остаток равен 0) то чило кратное паре 7 и 23
    else Console.WriteLine("нет"); 
    
}

try
{
    Console.WriteLine ("введите целое число");
    int Number = Convert.ToInt32 (Console.ReadLine());
    Kraton (Number);
}
catch 
{
    Console.WriteLine ("введите целое число");
}