void Kvadrat (int arg1, int arg2)
{
    if (arg1*arg1 == arg2) Console.WriteLine ($" Число {arg2} является квадратом числа {arg1}");    
   
    else if (arg2*arg2 == arg1) Console.WriteLine ($"Число {arg1} является квадратом числа {arg2}"); 
         else Console.WriteLine ("ни одно число не является квадратом другого");
}

try {
    Console.WriteLine ("Введите первое целое число");
    int Number1 = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("Введите второе целое число");
    int Number2 = Convert.ToInt32 (Console.ReadLine ()); 
    Kvadrat (Number1, Number2);
   
}    

catch {
    Console.WriteLine ("вы ввели не целое число");
}