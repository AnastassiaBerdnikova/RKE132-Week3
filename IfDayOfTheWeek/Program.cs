//proovime tuvastada mis nädalapäev täna on

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 1)
{
    Console.WriteLine("Monday");
}
else if (weekDay == 2)
{
    Console.WriteLine("Tuesday");
}
else if (weekDay == 3)
{ Console.WriteLine("Wednesday"); 
}
else if (weekDay == 4)
{
    Console.WriteLine("Thursday");
}
else if (weekDay == 5)
{
    Console.WriteLine("Friday");
}
else if (weekDay == 6)
{
    Console.WriteLine("Saturday");
}
else
{
    Console.WriteLine( "Sunday");
}

Console.WriteLine("Have a nice day!");