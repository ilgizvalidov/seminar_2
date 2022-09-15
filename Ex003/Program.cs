void Kraton (int arg1, int arg2)
{
    if (arg1 % arg2 == 0) Console.WriteLine ("второе число кратно первому");
    else Console.WriteLine("второе число не кратно первому, остаток от деления равен " + arg1%arg2);
}

try
{
    Console.WriteLine("введите первое целое число число");
    int Number1 = Convert.ToInt32(Console.ReadLine ());
    Console.WriteLine("Введите второе целое число");
    int Number2 = Convert.ToInt32 (Console.ReadLine());
    
    Kraton(Number1, Number2);
}
catch
{
    Console.WriteLine("вы ввели не целое число");
}

