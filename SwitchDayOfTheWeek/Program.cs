int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0-6

switch(weekDay) //väärtus, mida kontrollitakse
{
    case 0: //case 0:  == if(weekday ==0)
        Console.WriteLine("Sunday!");
    break;
        case 1:
        Console.WriteLine("Monday!");
        break;
        case 2:
        Console.WriteLine("Tuesday!");
        break;
        case 3:
        Console.WriteLine("Wednesday!");
        break;
        case 4:
        Console.WriteLine("Thursday!");
        break;
        case 5:
        Console.WriteLine("Friday!");
        break;
        case 6:
        Console.WriteLine("Saturday!");
        break;
        default: Console.WriteLine("Oops. Your calendar must be broken.");
        break;

}
Console.WriteLine("Have a nice day!");