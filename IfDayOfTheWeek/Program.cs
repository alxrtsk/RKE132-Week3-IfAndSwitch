
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if  (weekDay == 0)
{
    Console.WriteLine("I'ts Sunday");
}
else if (weekDay == 1)
{
    Console.WriteLine("I'ts Monday");
}
else if (weekDay == 2)
{
    Console.WriteLine("I'ts Tuesday");
}
else if (weekDay == 3)
{
    Console.WriteLine("I'ts Wednesday");
}
else if (weekDay == 4)
{
    Console.WriteLine("I'ts Thursday");
}
else if (weekDay == 5)
{
    Console.WriteLine("I'ts Friday");
}
else 
{
    Console.WriteLine("I'ts Saturday");
}

Console.WriteLine("Have a nice day!");
