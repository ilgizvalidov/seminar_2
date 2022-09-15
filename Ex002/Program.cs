void zadacha11 ()
{
    int Number = new Random().Next(100,1000);
    Console.WriteLine($"рандомное число равно {Number}" );
    int Result = (Number/10) - (Number/10%10) + (Number%10);
    Console.WriteLine ($"результат равен  {Result}");
}

zadacha11 ();