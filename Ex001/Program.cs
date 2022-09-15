
  void CompareDigits ()
  {
    int  Number = new Random().Next(10,100); // используем () для отрезока от 10 до 99, так как правая граница не берется.
    int Number1 = Number/10;
    int Number2 = Number%10;
    Console.WriteLine($"Сгенерировано число {Number}"); 
    if (Number1 > Number2) 
        {
            Console.WriteLine($"первая цифра больше и равна {Number1}");
        }  
    else
        {
        if (Number2 > Number1 ) 
            {
               Console.WriteLine($"вторая цифра больше и равна {Number2}");
            }
        else 
            {
                Console.WriteLine("Это полиндром");    
            }
                
        }
  }

CompareDigits();
CompareDigits(); 