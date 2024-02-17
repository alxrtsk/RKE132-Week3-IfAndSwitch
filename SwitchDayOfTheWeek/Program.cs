int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); // 0-6

switch(weekDay) //väärtus mida kontrollitakse
{
    case 0: // case 0: == if(weekDay == 0)
        Console.WriteLine("I'ts Sunday");
        break;
    case 1:
        Console.WriteLine("I'ts Monday");
        break;
    case 2:
        Console.WriteLine("I'ts Tuesday");
        break;
    case 3:
        Console.WriteLine("I'ts Wednesday");
        break;
    case 4:
        Console.WriteLine("I'ts Thursday");
        break;
    case 5:
        Console.WriteLine("I'ts Friday");
        break;
    case 6:
        Console.WriteLine("I'ts Saturday");
        break;
    default: Console.WriteLine("Oops your calendar must be broken");
        break;
}

Console.WriteLine("Have a nice day!");